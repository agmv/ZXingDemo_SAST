using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMarkerEventTriggered
/// </summary>

public static async Task<RC_d18425d8035234c443ecbdefa0da8210> GetMarkerEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_d18425d8035234c443ecbdefa0da8210 outParamRecord = default;
outParamRecord = new RC_d18425d8035234c443ecbdefa0da8210();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMarkerEventTriggered", "cf5812b2-bdc9-4eb2-8240-09f6367c6ad6.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENMarkerEventTriggeredEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MarkerEventTriggered", "inParamId");
}
return outParamRecord;
}

}
}
