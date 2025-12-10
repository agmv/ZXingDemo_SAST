using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSpace
/// </summary>

public static async Task<RC_9589ecc0629788c2aca6b47bcbae782c> GetSpace(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_9589ecc0629788c2aca6b47bcbae782c outParamRecord = default;
outParamRecord = new RC_9589ecc0629788c2aca6b47bcbae782c();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSpace", "8fb3d471-82a4-439c-9cc1-0555dfa91451.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENSpaceEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Space", "inParamId");
}
return outParamRecord;
}

}
}
