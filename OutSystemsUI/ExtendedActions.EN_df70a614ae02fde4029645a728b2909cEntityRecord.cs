using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetRegisteredCallbackEvents
/// </summary>

public static async Task<RC_b2eeb8f69cd26079c0c421f6fd8d6d1f> GetRegisteredCallbackEvents(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_b2eeb8f69cd26079c0c421f6fd8d6d1f outParamRecord = default;
outParamRecord = new RC_b2eeb8f69cd26079c0c421f6fd8d6d1f();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRegisteredCallbackEvents", "8292d703-2455-4daf-9574-a852dc42baff.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENRegisteredCallbackEventsEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("RegisteredCallbackEvents", "inParamId");
}
return outParamRecord;
}

}
}
