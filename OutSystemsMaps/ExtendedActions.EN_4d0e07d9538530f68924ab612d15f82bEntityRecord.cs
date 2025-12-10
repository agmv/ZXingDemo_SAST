using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMapErrors
/// </summary>

public static async Task<RC_3d151c63adf137bd3c85eaa462bbbe0c> GetMapErrors(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3d151c63adf137bd3c85eaa462bbbe0c outParamRecord = default;
outParamRecord = new RC_3d151c63adf137bd3c85eaa462bbbe0c();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMapErrors", "0ae015e4-c953-4e33-aec0-91674d05cbf5.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENMapErrorsEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MapErrors", "inParamId");
}
return outParamRecord;
}

}
}
