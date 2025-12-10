using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDatePickerLanguage
/// </summary>

public static async Task<RC_673cc0a63dbc3f5836f7732ba0712544> GetDatePickerLanguage(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_673cc0a63dbc3f5836f7732ba0712544 outParamRecord = default;
outParamRecord = new RC_673cc0a63dbc3f5836f7732ba0712544();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDatePickerLanguage", "45402ee4-73bf-42a2-b5f8-371ae940bf4f.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDatePickerLanguageEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DatePickerLanguage", "inParamId");
}
return outParamRecord;
}

}
}
