using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetAutoplay
/// </summary>

public static async Task<RC_c6831d06e579de4edbcf59e128b60b13> GetAutoplay(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_c6831d06e579de4edbcf59e128b60b13 outParamRecord = default;
outParamRecord = new RC_c6831d06e579de4edbcf59e128b60b13();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetAutoplay", "82aa58b4-8bbb-4d19-92b6-2944affad02c.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENAutoplayEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Autoplay", "inParamId");
}
return outParamRecord;
}

}
}
