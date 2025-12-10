export default function ($parameters, $actions, $roles, $public) {
if (window.offlineDataSync) {
    window.offlineDataSync.sync($parameters.SyncUnit, $parameters.DiscardPendingUnits);
}
};




