export default function ($parameters, $actions, $roles, $public) {
$parameters.TimeoutIdOut = setTimeout(function(){
    $actions.MoveElement($parameters.WidgetId, ".active-screen .layout");
},100);
};




