export default function ($parameters, $actions, $roles, $public) {
var accordion = document.getElementById($parameters.WidgetId);
var checkAccordionElements = accordion.querySelectorAll(':scope > div > .section-expandable.is--open');

// Close All but first, if user has multipleItems as false, but more than one section-expandable as Expanded 
if($parameters.MultipleItems === false){
    for(var i = 0; i < checkAccordionElements.length; i++) {
        if(i !== 0) {
            checkAccordionElements[i].CollapseItem();
        }
    }
}
};




