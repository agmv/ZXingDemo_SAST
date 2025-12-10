using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDrawingToolType
/// </summary>

public static async Task<RC_e2e4078a68f051b01b0e49ed4f3f6e07> GetDrawingToolType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_e2e4078a68f051b01b0e49ed4f3f6e07 outParamRecord = default;
outParamRecord = new RC_e2e4078a68f051b01b0e49ed4f3f6e07();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDrawingToolType", "14e12666-1a84-4330-b798-e9981e0537c4.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENDrawingToolTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DrawingToolType", "inParamId");
}
return outParamRecord;
}

}
}
