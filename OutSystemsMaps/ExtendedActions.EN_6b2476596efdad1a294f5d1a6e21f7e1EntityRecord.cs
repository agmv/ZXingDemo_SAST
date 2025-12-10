using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetPopupEvent
/// </summary>

public static async Task<RC_b426a0d7aa8f7cff1977eb04da864b0f> GetPopupEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_b426a0d7aa8f7cff1977eb04da864b0f outParamRecord = default;
outParamRecord = new RC_b426a0d7aa8f7cff1977eb04da864b0f();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetPopupEvent", "25c28812-61a5-472c-b946-caa03aeed4aa.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENPopupEventEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("PopupEvent", "inParamId");
}
return outParamRecord;
}

}
}
