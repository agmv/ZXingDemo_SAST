using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetShapeType
/// </summary>

public static async Task<RC_3201d1384957542debf3cb5808f51144> GetShapeType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3201d1384957542debf3cb5808f51144 outParamRecord = default;
outParamRecord = new RC_3201d1384957542debf3cb5808f51144();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetShapeType", "14fd2674-7979-4bb0-b74d-83a246b11f1f.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENShapeTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ShapeType", "inParamId");
}
return outParamRecord;
}

}
}
