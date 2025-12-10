using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetAccordionIconType
/// </summary>

public static async Task<RC_73fae6920f82113320dccc89ef073c01> GetAccordionIconType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_73fae6920f82113320dccc89ef073c01 outParamRecord = default;
outParamRecord = new RC_73fae6920f82113320dccc89ef073c01();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetAccordionIconType", "635cc1de-f6de-4b65-baf1-c661bc518266.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENAccordionIconTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("AccordionIconType", "inParamId");
}
return outParamRecord;
}

}
}
