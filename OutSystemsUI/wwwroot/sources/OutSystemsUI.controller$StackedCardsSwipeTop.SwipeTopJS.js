export default function ($parameters, $actions, $roles, $public) {
var element;

var swipeActionInterval = setInterval(function(){
    
    element = document.getElementById($parameters.WidgetId);

    if( element !== null) {
        element.querySelector('.stackedcards-container').topAction();
        clearInterval(swipeActionInterval);
    }
    
}, 100)
};




