using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetGutterSize
/// </summary>

public static async Task<RC_a5018402fa6c90c5e826e54b2748cedc> GetGutterSize(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_a5018402fa6c90c5e826e54b2748cedc outParamRecord = default;
outParamRecord = new RC_a5018402fa6c90c5e826e54b2748cedc();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetGutterSize", "2e81a1e8-4fa4-4bd0-a945-65352999b0be.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENGutterSizeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("GutterSize", "inParamId");
}
return outParamRecord;
}

}
}
