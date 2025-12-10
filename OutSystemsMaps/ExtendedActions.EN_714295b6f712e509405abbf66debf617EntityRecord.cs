using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDirectionsProvider
/// </summary>

public static async Task<RC_9c493adade9ae0a5806b7a20eb12f1e0> GetDirectionsProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_9c493adade9ae0a5806b7a20eb12f1e0 outParamRecord = default;
outParamRecord = new RC_9c493adade9ae0a5806b7a20eb12f1e0();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDirectionsProvider", "20fa4a07-f748-417d-b23c-b858acc94546.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENDirectionsProviderEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DirectionsProvider", "inParamId");
}
return outParamRecord;
}

}
}
