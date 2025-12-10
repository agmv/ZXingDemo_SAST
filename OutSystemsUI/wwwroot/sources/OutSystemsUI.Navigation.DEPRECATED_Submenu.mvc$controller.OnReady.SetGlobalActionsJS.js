export default function ($parameters, $actions, $roles, $public) {
var element = document.getElementById($parameters.WidgetId);

// Add actions
element.CloseMenu = function() { 
    $actions.CloseMenu();
};

element.OpenMenu = function() { 
    $actions.OpenMenu();
};
};




