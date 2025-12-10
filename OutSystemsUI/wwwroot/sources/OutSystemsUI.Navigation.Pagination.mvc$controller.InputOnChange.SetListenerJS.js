export default function ($parameters, $actions, $roles, $public) {
let value = $parameters.Value;
const totalPages = $parameters.TotalPages;
const enterPressed = 13; // enter-key
let inputElem = document.getElementById($parameters.InputElementId);

var checkValue = function() {
    if(value > 0 && value <= totalPages) {
    // Go to Selected Page
    value = (value - 1) * $parameters.MaxRecords;
    } else if(value > totalPages) {
        // Go to Last Page
        value = totalPages * $parameters.MaxRecords;
    } else {
        // Go to First page
        value = 0;
    }
};

var inputOnKeypress = function(e){
    if (e.keyCode === enterPressed) {
        checkValue();
        $actions.GoTo(value);
    }
    inputElem.removeEventListener('keydown', inputOnKeypress); 
};

if($parameters.IsBlur === false) {
    inputElem.addEventListener('keydown', inputOnKeypress);
    $parameters.KeypressCallbackObj = inputOnKeypress;
} else {
    checkValue();
    $actions.GoTo(value);
}

$parameters.GotoValue = value;
};




