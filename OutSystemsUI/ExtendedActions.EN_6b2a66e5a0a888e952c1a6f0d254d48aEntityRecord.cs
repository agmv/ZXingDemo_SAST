using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetCarouselDirection
/// </summary>

public static async Task<RC_fb5d22b1003cff234a588ab54b5367f0> GetCarouselDirection(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_fb5d22b1003cff234a588ab54b5367f0 outParamRecord = default;
outParamRecord = new RC_fb5d22b1003cff234a588ab54b5367f0();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetCarouselDirection", "71cbe266-f7c5-42fb-beae-76bc325d99ea.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENCarouselDirectionEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("CarouselDirection", "inParamId");
}
return outParamRecord;
}

}
}
