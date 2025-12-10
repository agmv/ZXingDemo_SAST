using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMonth
/// </summary>

public static async Task<RC_e092deacf9bc8885dd34714ac00f33e4> GetMonth(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_e092deacf9bc8885dd34714ac00f33e4 outParamRecord = default;
outParamRecord = new RC_e092deacf9bc8885dd34714ac00f33e4();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMonth", "33d9b724-a0b1-4b0a-91fb-272143c44a85.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENMonthEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Month", "inParamId");
}
return outParamRecord;
}

}
}
