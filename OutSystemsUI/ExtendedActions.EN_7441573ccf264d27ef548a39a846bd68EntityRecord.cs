using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSteps
/// </summary>

public static async Task<RC_0d776a4e191faf321030d5ce57aa4167> GetSteps(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0d776a4e191faf321030d5ce57aa4167 outParamRecord = default;
outParamRecord = new RC_0d776a4e191faf321030d5ce57aa4167();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSteps", "e4dd8e9f-a620-4df5-b619-9b8a771be5a3.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENStepsEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Steps", "inParamId");
}
return outParamRecord;
}

}
}
