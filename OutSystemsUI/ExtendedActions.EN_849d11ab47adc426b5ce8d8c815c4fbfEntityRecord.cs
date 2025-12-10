using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetColor
/// </summary>

public static async Task<RC_87351e3b0fa2ca59cf6c6749c6405006> GetColor(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_87351e3b0fa2ca59cf6c6749c6405006 outParamRecord = default;
outParamRecord = new RC_87351e3b0fa2ca59cf6c6749c6405006();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetColor", "cb6d1da7-26d4-45d9-bc22-9a4c482e6ce2.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENColorEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Color", "inParamId");
}
return outParamRecord;
}

}
}
