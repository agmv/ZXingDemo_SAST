using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetVideoState
/// </summary>

public static async Task<RC_03619642a06de09478f0b8f506c364eb> GetVideoState(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_03619642a06de09478f0b8f506c364eb outParamRecord = default;
outParamRecord = new RC_03619642a06de09478f0b8f506c364eb();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetVideoState", "f1508f37-01a7-456d-9dd0-64dff62f6d39.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENVideoStateEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("VideoState", "inParamId");
}
return outParamRecord;
}

}
}
