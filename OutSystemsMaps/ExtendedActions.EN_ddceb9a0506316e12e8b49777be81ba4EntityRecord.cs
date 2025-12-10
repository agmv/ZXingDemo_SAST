using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSearchPlacesErrors
/// </summary>

public static async Task<RC_28b5debce9c04e64c6dd40275449bf6c> GetSearchPlacesErrors(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_28b5debce9c04e64c6dd40275449bf6c outParamRecord = default;
outParamRecord = new RC_28b5debce9c04e64c6dd40275449bf6c();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSearchPlacesErrors", "4ef14755-abc6-4dc3-815d-ecd3a6dc3407.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENSearchPlacesErrorsEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("SearchPlacesErrors", "inParamId");
}
return outParamRecord;
}

}
}
