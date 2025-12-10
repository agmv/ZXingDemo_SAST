using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetProgressType
/// </summary>

public static async Task<RC_0832b315fa435e0ff97aca2a0ca6bd44> GetProgressType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0832b315fa435e0ff97aca2a0ca6bd44 outParamRecord = default;
outParamRecord = new RC_0832b315fa435e0ff97aca2a0ca6bd44();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProgressType", "b1c32742-606e-4e3e-9923-1c2e6e69ab6c.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENProgressTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ProgressType", "inParamId");
}
return outParamRecord;
}

}
}
