export default function ($parameters, $actions, $roles, $public) {
var elemId = document.getElementById($parameters.ElemId);
var isExpanded;

var onKeyDownPress = function(e){
    isExpanded = elemId.getAttribute('aria-expanded');
    
    //If ESC and expanded, hide the status 
    if(isExpanded === "true" && e.keyCode == "27") {
        $actions.ShowStatus();
        e.preventDefault();
        e.stopPropagation();
    }
    
    //If Enter or Space toggle status visibility
    if (e.keyCode == "32" || e.keyCode == "13") {
        $actions.ShowStatus();
        e.preventDefault();
        e.stopPropagation();
    }
};

elemId.addEventListener('keydown', onKeyDownPress);
};




