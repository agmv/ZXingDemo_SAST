using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetAnimationType
/// </summary>

public static async Task<RC_78b6d6ed7d52800a8a68e7d796ec6850> GetAnimationType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_78b6d6ed7d52800a8a68e7d796ec6850 outParamRecord = default;
outParamRecord = new RC_78b6d6ed7d52800a8a68e7d796ec6850();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetAnimationType", "0463d449-6834-40d5-817b-3d74d1a71bb2.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENAnimationTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("AnimationType", "inParamId");
}
return outParamRecord;
}

}
}
