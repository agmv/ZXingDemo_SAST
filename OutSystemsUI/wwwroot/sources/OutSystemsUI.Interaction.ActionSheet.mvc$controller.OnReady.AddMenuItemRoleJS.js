export default function ($parameters, $actions, $roles, $public) {
var buttonWrapper = document.getElementById($parameters.Buttons);
var buttons = buttonWrapper.querySelectorAll('.action-sheet-actions');

for(var i = 0; i < buttons.length; i++){
    var buttonsChildren = buttons[i].children;
    
    for(var a = 0; a < buttonsChildren.length; a++) {
        buttonsChildren[a].setAttribute('role', "menuitem");
    }
}
};




