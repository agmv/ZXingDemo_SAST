using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMarkerType
/// </summary>

public static async Task<RC_0b102c453446be3ebcb793be90d6b209> GetMarkerType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0b102c453446be3ebcb793be90d6b209 outParamRecord = default;
outParamRecord = new RC_0b102c453446be3ebcb793be90d6b209();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMarkerType", "3d05f10a-28e9-4029-bb84-5ab7ade9e36a.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENMarkerTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("MarkerType", "inParamId");
}
return outParamRecord;
}

}
}
