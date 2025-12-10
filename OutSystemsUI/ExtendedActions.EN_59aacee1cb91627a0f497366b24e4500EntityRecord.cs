using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetCarouselNavigation
/// </summary>

public static async Task<RC_373fec8a2329a8b1ecd55cf717893131> GetCarouselNavigation(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_373fec8a2329a8b1ecd55cf717893131 outParamRecord = default;
outParamRecord = new RC_373fec8a2329a8b1ecd55cf717893131();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetCarouselNavigation", "ee3aefc9-e437-49fb-86a2-0c2d0656ed43.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENCarouselNavigationEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("CarouselNavigation", "inParamId");
}
return outParamRecord;
}

}
}
