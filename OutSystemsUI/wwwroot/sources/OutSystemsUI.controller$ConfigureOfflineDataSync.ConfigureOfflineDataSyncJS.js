export default function ($parameters, $actions, $roles, $public) {
window.offlineDataSync.configure(
    $parameters.SyncOnOnline,
    $parameters.SyncOnResume,
    $parameters.RetryOnError,
    $parameters.RetryIntervalInSeconds);

};




