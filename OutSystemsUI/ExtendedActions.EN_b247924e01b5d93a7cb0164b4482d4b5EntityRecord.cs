using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetRangeSliderProvider
/// </summary>

public static async Task<RC_45a33caf5ebb3dedd109c21fe6ae3d86> GetRangeSliderProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_45a33caf5ebb3dedd109c21fe6ae3d86 outParamRecord = default;
outParamRecord = new RC_45a33caf5ebb3dedd109c21fe6ae3d86();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRangeSliderProvider", "76a8780c-9acf-4be3-949d-c5bb30052481.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENRangeSliderProviderEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("RangeSliderProvider", "inParamId");
}
return outParamRecord;
}

}
}
