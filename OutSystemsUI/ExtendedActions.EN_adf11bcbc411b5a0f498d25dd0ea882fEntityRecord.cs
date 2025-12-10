using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetAlert
/// </summary>

public static async Task<RC_9ca6a18cc49ca7246c44c0f7c2cef62a> GetAlert(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_9ca6a18cc49ca7246c44c0f7c2cef62a outParamRecord = default;
outParamRecord = new RC_9ca6a18cc49ca7246c44c0f7c2cef62a();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetAlert", "924486c0-dd9a-46ea-ad74-2cf9ac0c84d9.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENAlertEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Alert", "inParamId");
}
return outParamRecord;
}

}
}
