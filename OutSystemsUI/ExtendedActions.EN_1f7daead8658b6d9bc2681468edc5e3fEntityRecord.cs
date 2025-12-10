using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDropdownProvider
/// </summary>

public static async Task<RC_b31d17ba3ccc14eaadd4d2faf9371f2d> GetDropdownProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_b31d17ba3ccc14eaadd4d2faf9371f2d outParamRecord = default;
outParamRecord = new RC_b31d17ba3ccc14eaadd4d2faf9371f2d();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDropdownProvider", "c432b13a-7b10-4a88-993c-71748f34d7ff.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDropdownProviderEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DropdownProvider", "inParamId");
}
return outParamRecord;
}

}
}
