using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMapType
/// </summary>

public static async Task<RC_992836b5ddde04d0d91f0c87e7233524> GetMapType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_992836b5ddde04d0d91f0c87e7233524 outParamRecord = default;
outParamRecord = new RC_992836b5ddde04d0d91f0c87e7233524();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMapType", "d4ae68c7-58a9-4003-96c0-e23e7c46b48a.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENMapTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MapType", "inParamId");
}
return outParamRecord;
}

}
}
