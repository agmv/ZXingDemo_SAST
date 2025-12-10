export default function ($parameters, $actions, $roles, $public) {
var elem = document.getElementById($parameters.TabID).querySelector('.tabs');

if(elem) {
    elem.classList.add('no-swipe');
}
};




