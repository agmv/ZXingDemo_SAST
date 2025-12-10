export default function ($parameters, $actions, $roles, $public) {
if($parameters.CalendarObj !== null)
{
    $parameters.CalendarObj.destroy();
}

if($parameters.ObserverLangObj !== null)
{
    $parameters.ObserverLangObj.disconnect();
}

if($parameters.ObserverFormClassObj !== null)
{
    $parameters.ObserverFormClassObj.disconnect();
}
};




