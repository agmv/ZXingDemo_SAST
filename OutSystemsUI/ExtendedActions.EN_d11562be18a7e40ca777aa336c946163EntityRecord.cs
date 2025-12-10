using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetShape
/// </summary>

public static async Task<RC_0a89eeb60fa1f44b6316ca69b462007b> GetShape(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0a89eeb60fa1f44b6316ca69b462007b outParamRecord = default;
outParamRecord = new RC_0a89eeb60fa1f44b6316ca69b462007b();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetShape", "6fe168a9-c16d-4cdb-9b6f-a9e6c6b79326.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENShapeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Shape", "inParamId");
}
return outParamRecord;
}

}
}
