using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetOrientation
/// </summary>

public static async Task<RC_3ba1d238c8e0f0c3e875fb37f0381cc6> GetOrientation(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3ba1d238c8e0f0c3e875fb37f0381cc6 outParamRecord = default;
outParamRecord = new RC_3ba1d238c8e0f0c3e875fb37f0381cc6();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrientation", "4d71f824-a563-4f63-8c76-626e4e0bdddb.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENOrientationEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Orientation", "inParamId");
}
return outParamRecord;
}

}
}
