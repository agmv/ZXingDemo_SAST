using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDatePickerTimeFormat
/// </summary>

public static async Task<RC_51b1c15949308af5f9b2dba7043d5ae6> GetDatePickerTimeFormat(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_51b1c15949308af5f9b2dba7043d5ae6 outParamRecord = default;
outParamRecord = new RC_51b1c15949308af5f9b2dba7043d5ae6();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDatePickerTimeFormat", "55e54b1a-0efe-4bef-ae10-c2769129634d.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDatePickerTimeFormatEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DatePickerTimeFormat", "inParamId");
}
return outParamRecord;
}

}
}
