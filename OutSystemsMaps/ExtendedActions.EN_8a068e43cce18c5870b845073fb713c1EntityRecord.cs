using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDrawingToolsEventTriggered
/// </summary>

public static async Task<RC_499511b992975daa9639159d76f69e74> GetDrawingToolsEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_499511b992975daa9639159d76f69e74 outParamRecord = default;
outParamRecord = new RC_499511b992975daa9639159d76f69e74();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDrawingToolsEventTriggered", "2640dedd-7e59-483c-89f6-51ab17a38999.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENDrawingToolsEventTriggeredEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DrawingToolsEventTriggered", "inParamId");
}
return outParamRecord;
}

}
}
