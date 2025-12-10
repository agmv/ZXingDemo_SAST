using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDatePickerCalendarType
/// </summary>

public static async Task<RC_de3deb221a4b1656cc37f0db973c4e9a> GetDatePickerCalendarType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_de3deb221a4b1656cc37f0db973c4e9a outParamRecord = default;
outParamRecord = new RC_de3deb221a4b1656cc37f0db973c4e9a();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDatePickerCalendarType", "a8849efb-7aa4-4297-971f-db5b0c65fbfa.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDatePickerCalendarTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DatePickerCalendarType", "inParamId");
}
return outParamRecord;
}

}
}
