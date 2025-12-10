using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetGradient
/// </summary>

public static async Task<RC_3f6426aeecbfa4af19e279847df746cc> GetGradient(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3f6426aeecbfa4af19e279847df746cc outParamRecord = default;
outParamRecord = new RC_3f6426aeecbfa4af19e279847df746cc();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetGradient", "15f4b55e-c9e8-4f0d-a043-0093e17fa04d.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENGradientEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Gradient", "inParamId");
}
return outParamRecord;
}

}
}
