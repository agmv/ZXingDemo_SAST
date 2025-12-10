using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSpeed
/// </summary>

public static async Task<RC_d15ba8cc56cc5ee58bd8acaffd974239> GetSpeed(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_d15ba8cc56cc5ee58bd8acaffd974239 outParamRecord = default;
outParamRecord = new RC_d15ba8cc56cc5ee58bd8acaffd974239();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSpeed", "0a5cc4ae-b54f-4ea3-9ace-9f49c7724606.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENSpeedEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Speed", "inParamId");
}
return outParamRecord;
}

}
}
