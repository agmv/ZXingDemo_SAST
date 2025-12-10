export default function ($parameters, $actions, $roles, $public) {
var videoWidget = document.getElementById($parameters.WidgetId);
var videoTag = videoWidget.querySelector('video');
videoTag.pause();
};




