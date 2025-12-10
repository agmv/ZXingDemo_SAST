export default function ($parameters, $actions, $roles, $public) {
var element;
if($parameters.IsRTL){
    element = document.getElementById($parameters.WidgetId).querySelector('.carousel-container-content').previous();
} else{
    element = document.getElementById($parameters.WidgetId).querySelector('.carousel-container-content').next();
}

};




