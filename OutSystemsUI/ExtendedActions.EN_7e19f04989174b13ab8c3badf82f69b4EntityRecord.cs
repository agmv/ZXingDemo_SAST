using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetRangeSliderType
/// </summary>

public static async Task<RC_f332a0a4298f66d209888b6f5c56f633> GetRangeSliderType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_f332a0a4298f66d209888b6f5c56f633 outParamRecord = default;
outParamRecord = new RC_f332a0a4298f66d209888b6f5c56f633();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRangeSliderType", "6f4436fe-d69a-4b09-8cc9-abddba377729.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENRangeSliderTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("RangeSliderType", "inParamId");
}
return outParamRecord;
}

}
}
