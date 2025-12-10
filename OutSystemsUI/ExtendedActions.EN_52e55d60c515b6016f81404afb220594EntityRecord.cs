using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetTrigger
/// </summary>

public static async Task<RC_ab84a98a3ac9de80e9278e5b21681a23> GetTrigger(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ab84a98a3ac9de80e9278e5b21681a23 outParamRecord = default;
outParamRecord = new RC_ab84a98a3ac9de80e9278e5b21681a23();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetTrigger", "8f0912ba-c626-4795-90a6-5311e2b970cb.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENTriggerEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Trigger", "inParamId");
}
return outParamRecord;
}

}
}
