export default function ($actions, $roles, $public) {
var TimeoutClear = setTimeout(function(){
    $actions.ChangeIsAnimatingStatus();
    clearTimeout(TimeoutClear);
},300);
};




