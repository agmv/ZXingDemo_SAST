using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMapEventTriggered
/// </summary>

public static async Task<RC_bf75694d8016688134fa555a2fd4f5d7> GetMapEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_bf75694d8016688134fa555a2fd4f5d7 outParamRecord = default;
outParamRecord = new RC_bf75694d8016688134fa555a2fd4f5d7();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMapEventTriggered", "7cf2a964-5ef8-4901-abe6-e84cb6616a62.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENMapEventTriggeredEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MapEventTriggered", "inParamId");
}
return outParamRecord;
}

}
}
