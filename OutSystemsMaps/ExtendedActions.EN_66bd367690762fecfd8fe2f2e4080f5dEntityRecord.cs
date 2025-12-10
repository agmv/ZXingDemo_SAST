using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetTravelMode
/// </summary>

public static async Task<RC_fd916ed3e439afbf2b3a8036c2de75ba> GetTravelMode(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_fd916ed3e439afbf2b3a8036c2de75ba outParamRecord = default;
outParamRecord = new RC_fd916ed3e439afbf2b3a8036c2de75ba();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetTravelMode", "fd1f3f9a-87ad-45fa-81b4-46a61da60671.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENTravelModeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("TravelMode", "inParamId");
}
return outParamRecord;
}

}
}
