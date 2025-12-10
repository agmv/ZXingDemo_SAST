using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetCarouselProvider
/// </summary>

public static async Task<RC_60ed22b1487b1e18edb2fceb277aa5d1> GetCarouselProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_60ed22b1487b1e18edb2fceb277aa5d1 outParamRecord = default;
outParamRecord = new RC_60ed22b1487b1e18edb2fceb277aa5d1();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetCarouselProvider", "01addca3-86ba-436f-950e-e48d74ea2cac.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENCarouselProviderEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("CarouselProvider", "inParamId");
}
return outParamRecord;
}

}
}
