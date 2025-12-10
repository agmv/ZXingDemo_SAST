using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDirection
/// </summary>

public static async Task<RC_070998dc6b3dc951b52d8108550fe380> GetDirection(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_070998dc6b3dc951b52d8108550fe380 outParamRecord = default;
outParamRecord = new RC_070998dc6b3dc951b52d8108550fe380();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDirection", "67628086-7f8b-4f84-a978-a9d3f547969c.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDirectionEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Direction", "inParamId");
}
return outParamRecord;
}

}
}
