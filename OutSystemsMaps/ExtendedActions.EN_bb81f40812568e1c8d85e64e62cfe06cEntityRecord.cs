using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetShapeEvent
/// </summary>

public static async Task<RC_edb1f7bb91ddbc761736a4f9fe9ed955> GetShapeEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_edb1f7bb91ddbc761736a4f9fe9ed955 outParamRecord = default;
outParamRecord = new RC_edb1f7bb91ddbc761736a4f9fe9ed955();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetShapeEvent", "381a1deb-bc9a-4931-8d1e-90177993e176.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENShapeEventEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ShapeEvent", "inParamId");
}
return outParamRecord;
}

}
}
