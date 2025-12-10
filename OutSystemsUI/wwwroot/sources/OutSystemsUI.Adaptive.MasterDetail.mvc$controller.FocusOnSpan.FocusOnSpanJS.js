export default function ($parameters, $actions, $roles, $public) {
var clickedItem = $parameters.event.target;

if(clickedItem.getAttribute("focusItemId")) {
	document.getElementById(clickedItem.getAttribute("focusItemId")).focus();
}
};




