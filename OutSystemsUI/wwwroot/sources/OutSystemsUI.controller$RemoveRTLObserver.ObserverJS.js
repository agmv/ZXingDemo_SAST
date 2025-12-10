export default function ($parameters, $actions, $roles, $public) {
OSFramework.OSUI.Event.DOMEvents.Observers.GlobalObserverManager.Instance.removeHandler(
    OSFramework.OSUI.Event.DOMEvents.Observers.ObserverEvent.RTL,
    $parameters.Callback
);
};




