export default function ($parameters, $actions, $roles, $public) {
requestAnimationFrame(function(){
    $parameters.ListElNodesObj[$parameters.CurrentPosition].setAttribute('aria-hidden', true);
    $parameters.ListElNodesObj[$parameters.CurrentPosition].style.opacity = 0;
});


};




