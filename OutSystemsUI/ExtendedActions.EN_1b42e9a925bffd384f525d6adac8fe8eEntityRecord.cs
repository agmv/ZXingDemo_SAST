using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDatePickerWeekDay
/// </summary>

public static async Task<RC_210f541f43ec6384ba59bfd8fe4b8837> GetDatePickerWeekDay(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_210f541f43ec6384ba59bfd8fe4b8837 outParamRecord = default;
outParamRecord = new RC_210f541f43ec6384ba59bfd8fe4b8837();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDatePickerWeekDay", "fd4ed0ba-1ab9-4a3e-a2b1-18f41793be2d.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDatePickerWeekDayEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DatePickerWeekDay", "inParamId");
}
return outParamRecord;
}

}
}
