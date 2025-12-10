using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSize
/// </summary>

public static async Task<RC_ca426fec0751e5b6dcf015e9fdc2120e> GetSize(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ca426fec0751e5b6dcf015e9fdc2120e outParamRecord = default;
outParamRecord = new RC_ca426fec0751e5b6dcf015e9fdc2120e();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSize", "1ac110b4-8964-470b-a6b2-81ae4a6b5bde.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENSizeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Size", "inParamId");
}
return outParamRecord;
}

}
}
