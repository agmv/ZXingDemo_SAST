using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDatePickerProvider
/// </summary>

public static async Task<RC_8d60218511e7c5a6826e7f1bde0eda29> GetDatePickerProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8d60218511e7c5a6826e7f1bde0eda29 outParamRecord = default;
outParamRecord = new RC_8d60218511e7c5a6826e7f1bde0eda29();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDatePickerProvider", "eba14106-529d-4e9d-9ca0-fdb74716d75f.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDatePickerProviderEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DatePickerProvider", "inParamId");
}
return outParamRecord;
}

}
}
