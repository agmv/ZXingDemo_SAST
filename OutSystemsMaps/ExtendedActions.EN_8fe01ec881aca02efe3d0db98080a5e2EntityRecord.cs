using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSearchPlacesEvent
/// </summary>

public static async Task<RC_f1764d7c40e4f0543f1781c01f8cbcf5> GetSearchPlacesEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_f1764d7c40e4f0543f1781c01f8cbcf5 outParamRecord = default;
outParamRecord = new RC_f1764d7c40e4f0543f1781c01f8cbcf5();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSearchPlacesEvent", "352844c7-4325-49fd-a1f8-298237ad2c49.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENSearchPlacesEventEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("SearchPlacesEvent", "inParamId");
}
return outParamRecord;
}

}
}
