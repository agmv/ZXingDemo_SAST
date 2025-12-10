using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetLogType
/// </summary>

public static async Task<RC_cc83188402b0c2897ce694332899ab49> GetLogType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_cc83188402b0c2897ce694332899ab49 outParamRecord = default;
outParamRecord = new RC_cc83188402b0c2897ce694332899ab49();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetLogType", "ac429394-d435-4e1c-8f83-8ec82b367ec9.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENLogTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("LogType", "inParamId");
}
return outParamRecord;
}

}
}
