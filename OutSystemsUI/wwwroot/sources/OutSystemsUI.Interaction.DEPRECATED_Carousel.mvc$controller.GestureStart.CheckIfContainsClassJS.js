export default function ($parameters, $actions, $roles, $public) {
var carouselSwipe = document.getElementById($parameters.CarouselId);

if(carouselSwipe.classList.contains('no-swipe')){
    $parameters.ContainsClass = true;
} else {
    $parameters.ContainsClass = false;
}
};




