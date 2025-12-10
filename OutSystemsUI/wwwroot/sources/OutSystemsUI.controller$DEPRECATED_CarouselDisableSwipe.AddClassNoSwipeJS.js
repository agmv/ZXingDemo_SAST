export default function ($parameters, $actions, $roles, $public) {
var elem = document.getElementById($parameters.CarouselID).querySelector('.carousel');

if(elem) {
    elem.classList.add('no-swipe');
}
};




