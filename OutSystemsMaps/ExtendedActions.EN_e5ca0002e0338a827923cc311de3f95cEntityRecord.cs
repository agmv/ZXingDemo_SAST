using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMapEvent
/// </summary>

public static async Task<RC_227974ef92f7b64b18b95570fef9abe3> GetMapEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_227974ef92f7b64b18b95570fef9abe3 outParamRecord = default;
outParamRecord = new RC_227974ef92f7b64b18b95570fef9abe3();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMapEvent", "5caa5df9-dc3a-4864-874f-6ecf22baa80f.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENMapEventEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MapEvent", "inParamId");
}
return outParamRecord;
}

}
}
