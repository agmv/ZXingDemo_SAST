using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDrawingToolsPosition
/// </summary>

public static async Task<RC_c52fa927f09489f1c90f3a0526a1c8c9> GetDrawingToolsPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_c52fa927f09489f1c90f3a0526a1c8c9 outParamRecord = default;
outParamRecord = new RC_c52fa927f09489f1c90f3a0526a1c8c9();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDrawingToolsPosition", "950fddcc-2412-4248-a864-399a0fd9b469.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENDrawingToolsPositionEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DrawingToolsPosition", "inParamId");
}
return outParamRecord;
}

}
}
