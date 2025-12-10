using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetBreakColumns
/// </summary>

public static async Task<RC_261685da2c799bcc3b4873485e008694> GetBreakColumns(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_261685da2c799bcc3b4873485e008694 outParamRecord = default;
outParamRecord = new RC_261685da2c799bcc3b4873485e008694();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetBreakColumns", "68f74593-a5c4-4e65-858b-f44211eaf122.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENBreakColumnsEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("BreakColumns", "inParamId");
}
return outParamRecord;
}

}
}
