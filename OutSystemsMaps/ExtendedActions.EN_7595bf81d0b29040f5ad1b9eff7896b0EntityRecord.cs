using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMarkerEvent
/// </summary>

public static async Task<RC_2d18bab1b72b271dc15dda249e871290> GetMarkerEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_2d18bab1b72b271dc15dda249e871290 outParamRecord = default;
outParamRecord = new RC_2d18bab1b72b271dc15dda249e871290();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMarkerEvent", "88306854-60f3-4fc9-b928-db3e0ca7f7b6.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENMarkerEventEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MarkerEvent", "inParamId");
}
return outParamRecord;
}

}
}
