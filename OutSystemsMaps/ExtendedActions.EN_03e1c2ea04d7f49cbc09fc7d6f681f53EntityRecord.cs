using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetFileLayerEvent
/// </summary>

public static async Task<RC_dc7b093401bf134dc8399c003cfc6bc0> GetFileLayerEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_dc7b093401bf134dc8399c003cfc6bc0 outParamRecord = default;
outParamRecord = new RC_dc7b093401bf134dc8399c003cfc6bc0();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFileLayerEvent", "a1f5dba7-e312-4de7-b0c2-9316e20a66a4.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENFileLayerEventEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("FileLayerEvent", "inParamId");
}
return outParamRecord;
}

}
}
