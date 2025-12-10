using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetFloatingPosition
/// </summary>

public static async Task<RC_95c473136722ba7379611f73a3471de3> GetFloatingPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_95c473136722ba7379611f73a3471de3 outParamRecord = default;
outParamRecord = new RC_95c473136722ba7379611f73a3471de3();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFloatingPosition", "926b8b2a-0906-4e6f-8ef5-e18fdce4b5af.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENFloatingPositionEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("FloatingPosition", "inParamId");
}
return outParamRecord;
}

}
}
