export default function ($parameters, $actions, $roles, $public) {
var element;

if($parameters.IsRTL){
    element = document.getElementById($parameters.IdCarousel).querySelector('.carousel-container-content').next();
} else{
    element = document.getElementById($parameters.IdCarousel).querySelector('.carousel-container-content').previous();
}

};




