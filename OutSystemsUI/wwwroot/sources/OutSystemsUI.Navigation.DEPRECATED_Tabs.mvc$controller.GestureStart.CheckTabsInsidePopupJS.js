export default function ($parameters, $actions, $roles, $public) {
var tabsInsidePopup = document.body.querySelector('.popup-dialog .popup-content .tabs');

if(tabsInsidePopup) {
    $parameters.TabsInsidePopup = true;
} else {
    $parameters.TabsInsidePopup = false;
}

};




