using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDrawingToolsEvent
/// </summary>

public static async Task<RC_499414721b608cf3d3b8f99fae961f52> GetDrawingToolsEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_499414721b608cf3d3b8f99fae961f52 outParamRecord = default;
outParamRecord = new RC_499414721b608cf3d3b8f99fae961f52();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDrawingToolsEvent", "e6239ed8-518d-4f10-a23e-29333bffabc7.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENDrawingToolsEventEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DrawingToolsEvent", "inParamId");
}
return outParamRecord;
}

}
}
