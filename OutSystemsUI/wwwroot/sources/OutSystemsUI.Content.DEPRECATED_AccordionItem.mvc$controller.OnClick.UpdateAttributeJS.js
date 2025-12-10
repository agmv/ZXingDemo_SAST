export default function ($parameters, $actions, $roles, $public) {
var accordionItem  = document.getElementById($parameters.WidgetId);

accordionItem.setAttribute('data-expanded', $parameters.IsExpanded);


};




