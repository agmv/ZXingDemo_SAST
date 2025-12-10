export default function ($parameters, $actions, $roles, $public) {
var content = document.getElementById($parameters.ContentId);
var wrapper = document.getElementById($parameters.TooltipWrapperId);
var tooltip = document.getElementById($parameters.TooltipId) ? document.getElementById($parameters.TooltipId) : '';
var tooltipBackground = document.getElementById($parameters.TooltipBackgroundId)
    ? document.getElementById($parameters.TooltipBackgroundId)
    : '';
var isActive = false;
var isExpanded;

function tooltipBgClick(e) {
    e.preventDefault();
    e.stopPropagation();

    $actions.ToggleTooltip(false);
    tooltipBackground.removeEventListener('click', tooltipBgClick, true);
}


if ($parameters.IsHover) {
    content.addEventListener('focus', function () {
        $actions.ToggleTooltip(true);
    });
    content.addEventListener('focusout', function(e){
        $actions.ToggleTooltip(false);
        e.target.blur();
    });
    wrapper.addEventListener('mouseover', function (e) {
        $actions.ToggleTooltip(true);
        // To enable Esc listener on mouseover
        e.target.focus();
    });
    wrapper.addEventListener('mouseleave', function () {
        $actions.ToggleTooltip(false);

        if (tooltipBackground !== '') {
            tooltipBackground.addEventListener('click', tooltipBgClick, true);
        }
    });
} else {
    if (tooltipBackground !== '') {
        tooltipBackground.addEventListener('click', tooltipBgClick, true);
    }

    content.addEventListener(
        'click',
        function (e) {
            $actions.ToggleTooltip(true);

            setTimeout(function () {
                tooltipBackground = document.getElementById($parameters.TooltipBackgroundId)
                    ? document.getElementById($parameters.TooltipBackgroundId)
                    : '';
                tooltipBackground.removeEventListener('click', tooltipBgClick, true);
                tooltipBackground.addEventListener('click', tooltipBgClick, true);
            }, 0);
        },
        true
    );
    isActive = true;
}

var onKeyDownPress = function (e) {
    isExpanded = content.getAttribute('aria-expanded');

    //If esc or Tab, Close Tooltip
    if ((isExpanded === 'true' && e.keyCode == '27') || (document.activeElement === tooltip && e.keyCode == '9')) {
        $actions.ToggleTooltip(!isExpanded);
        isActive = !isExpanded;
    }

    //If enter or space use the tooltip to validate
    if (e.keyCode == '13') {
        $actions.ToggleTooltip(true);
        isActive = true;
    }
};

wrapper.addEventListener('keydown', onKeyDownPress);
};




