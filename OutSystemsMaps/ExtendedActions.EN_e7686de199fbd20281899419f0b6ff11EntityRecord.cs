using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetStyle
/// </summary>

public static async Task<RC_97843bcb52146db1681dfc816cff70a0> GetStyle(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_97843bcb52146db1681dfc816cff70a0 outParamRecord = default;
outParamRecord = new RC_97843bcb52146db1681dfc816cff70a0();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetStyle", "a0adb83b-e208-4039-bc92-91d01b8e2081.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENStyleEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Style", "inParamId");
}
return outParamRecord;
}

}
}
