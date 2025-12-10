using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetType
/// </summary>

public static async Task<RC_b32e755d03dd085a4b975b8c0c7d4454> GetType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_b32e755d03dd085a4b975b8c0c7d4454 outParamRecord = default;
outParamRecord = new RC_b32e755d03dd085a4b975b8c0c7d4454();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetType", "321464c3-cb26-412f-b60a-1c7140dc8c1b.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Type", "inParamId");
}
return outParamRecord;
}

}
}
