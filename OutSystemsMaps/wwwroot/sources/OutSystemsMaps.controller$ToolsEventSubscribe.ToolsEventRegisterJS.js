export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.DrawingToolsManager.Events.SubscribeByToolUniqueId($parameters.ToolWidgetId, $parameters.DrawingToolsEventId, $parameters.Callback);
};




