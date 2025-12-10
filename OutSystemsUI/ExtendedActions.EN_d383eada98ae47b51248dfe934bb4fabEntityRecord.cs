using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDEPRECATED_Color
/// </summary>

public static async Task<RC_c47826b7e4232fbf890784243715f5a8> GetDEPRECATED_Color(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_c47826b7e4232fbf890784243715f5a8 outParamRecord = default;
outParamRecord = new RC_c47826b7e4232fbf890784243715f5a8();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDEPRECATED_Color", "4a5b3b8d-44e7-4c03-9b89-453fa2feee20.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDEPRECATED_ColorEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DEPRECATED_Color", "inParamId");
}
return outParamRecord;
}

}
}
