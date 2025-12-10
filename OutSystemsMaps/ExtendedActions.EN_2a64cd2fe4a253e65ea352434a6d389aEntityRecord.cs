using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSearchTypes
/// </summary>

public static async Task<RC_d186ae1becb56f86c126b4768e3f70d2> GetSearchTypes(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_d186ae1becb56f86c126b4768e3f70d2 outParamRecord = default;
outParamRecord = new RC_d186ae1becb56f86c126b4768e3f70d2();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSearchTypes", "874caddc-a7e7-422a-ad8b-0267067bc563.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENSearchTypesEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("SearchTypes", "inParamId");
}
return outParamRecord;
}

}
}
