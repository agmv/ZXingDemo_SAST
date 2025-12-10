using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetAccordionIconPosition
/// </summary>

public static async Task<RC_ab72f035aa34ddb5ec313dc02adb1f18> GetAccordionIconPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ab72f035aa34ddb5ec313dc02adb1f18 outParamRecord = default;
outParamRecord = new RC_ab72f035aa34ddb5ec313dc02adb1f18();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetAccordionIconPosition", "a848db2d-fe6c-4df1-8c10-8bdb3c2e948a.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENAccordionIconPositionEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("AccordionIconPosition", "inParamId");
}
return outParamRecord;
}

}
}
