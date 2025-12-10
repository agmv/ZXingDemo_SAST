using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetBooleanTypes
/// </summary>

public static async Task<RC_1ea63146d7f1d969afc206832e751192> GetBooleanTypes(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_1ea63146d7f1d969afc206832e751192 outParamRecord = default;
outParamRecord = new RC_1ea63146d7f1d969afc206832e751192();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetBooleanTypes", "9882c8fc-0dd6-492e-b6b9-7a68059ecc06.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENBooleanTypesEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("BooleanTypes", "inParamId");
}
return outParamRecord;
}

}
}
