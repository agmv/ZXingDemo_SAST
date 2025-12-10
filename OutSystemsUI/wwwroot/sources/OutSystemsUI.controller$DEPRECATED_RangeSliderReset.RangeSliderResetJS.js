export default function ($parameters, $actions, $roles, $public) {
var slider = document.querySelector('#' + $parameters.WidgetId + ' .range-slider > div');

// Check if element exists before applying the reset on slider
if(slider && slider.noUiSlider){
    slider.noUiSlider.reset();
}
};




