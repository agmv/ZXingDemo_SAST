using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetProvider
/// </summary>

public static async Task<RC_21369035d43ec8805ca548830e8c3c98> GetProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_21369035d43ec8805ca548830e8c3c98 outParamRecord = default;
outParamRecord = new RC_21369035d43ec8805ca548830e8c3c98();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProvider", "88944e86-e035-49c1-90a5-64d0aed01f83.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENProviderEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Provider", "inParamId");
}
return outParamRecord;
}

}
}
