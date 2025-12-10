export default function ($parameters, $actions, $roles, $public) {
var element = document.getElementById($parameters.WidgetId);
var elementNodes = element.querySelectorAll('.section-expandable');

// Check if exist elements inside accordion
if(elementNodes.length > 0){
    for(i = 0; i < elementNodes.length; i++){
        elementNodes[i].updateAccordion($parameters.MultipleItems);
    } 
}

};




