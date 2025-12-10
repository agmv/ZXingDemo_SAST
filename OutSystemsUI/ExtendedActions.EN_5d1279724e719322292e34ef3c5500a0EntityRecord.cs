using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetPosition
/// </summary>

public static async Task<RC_5f28219a5e30fb90023fcbc295513e7c> GetPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_5f28219a5e30fb90023fcbc295513e7c outParamRecord = default;
outParamRecord = new RC_5f28219a5e30fb90023fcbc295513e7c();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetPosition", "83c073e8-bac2-4122-9772-aa6e122a5d36.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENPositionEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Position", "inParamId");
}
return outParamRecord;
}

}
}
