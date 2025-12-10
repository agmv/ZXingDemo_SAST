using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetShapeEventTriggered
/// </summary>

public static async Task<RC_098c46906c1c0c7e7b39f1210fb64f78> GetShapeEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_098c46906c1c0c7e7b39f1210fb64f78 outParamRecord = default;
outParamRecord = new RC_098c46906c1c0c7e7b39f1210fb64f78();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetShapeEventTriggered", "ecd875a9-9c28-48b3-8693-d77fa52bfcb9.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENShapeEventTriggeredEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ShapeEventTriggered", "inParamId");
}
return outParamRecord;
}

}
}
