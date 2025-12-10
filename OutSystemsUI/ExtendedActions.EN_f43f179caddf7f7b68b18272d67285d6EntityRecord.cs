using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMenuAction
/// </summary>

public static async Task<RC_954cd1231210e70f33f184017bf580ac> GetMenuAction(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_954cd1231210e70f33f184017bf580ac outParamRecord = default;
outParamRecord = new RC_954cd1231210e70f33f184017bf580ac();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMenuAction", "9cc12883-06ab-4cf0-9997-ede7c6c02d67.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENMenuActionEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MenuAction", "inParamId");
}
return outParamRecord;
}

}
}
