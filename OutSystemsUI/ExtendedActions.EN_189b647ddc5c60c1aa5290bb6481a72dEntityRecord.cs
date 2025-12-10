using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMessageStatus
/// </summary>

public static async Task<RC_63c659b6dc554b0b4f81d60382bf5fd6> GetMessageStatus(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_63c659b6dc554b0b4f81d60382bf5fd6 outParamRecord = default;
outParamRecord = new RC_63c659b6dc554b0b4f81d60382bf5fd6();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMessageStatus", "c1015fc0-c81c-40cc-a046-bf99cf21a280.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENMessageStatusEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MessageStatus", "inParamId");
}
return outParamRecord;
}

}
}
