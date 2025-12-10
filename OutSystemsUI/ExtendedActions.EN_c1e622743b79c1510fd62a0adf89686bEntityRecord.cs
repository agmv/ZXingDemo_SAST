using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSideMenuBehavior
/// </summary>

public static async Task<RC_e3607d6b92545e5793fbeb99fc16b7e7> GetSideMenuBehavior(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_e3607d6b92545e5793fbeb99fc16b7e7 outParamRecord = default;
outParamRecord = new RC_e3607d6b92545e5793fbeb99fc16b7e7();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSideMenuBehavior", "11a5937b-e94d-4250-99a8-9c8358d3d965.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENSideMenuBehaviorEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("SideMenuBehavior", "inParamId");
}
return outParamRecord;
}

}
}
