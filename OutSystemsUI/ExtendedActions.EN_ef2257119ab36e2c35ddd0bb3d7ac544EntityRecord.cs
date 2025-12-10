using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetColumnBreak
/// </summary>

public static async Task<RC_b6adbbf4e08bad2975a6f8f796279b71> GetColumnBreak(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_b6adbbf4e08bad2975a6f8f796279b71 outParamRecord = default;
outParamRecord = new RC_b6adbbf4e08bad2975a6f8f796279b71();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetColumnBreak", "cce6ac21-942a-492f-8b46-64c5e6ea057b.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENColumnBreakEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ColumnBreak", "inParamId");
}
return outParamRecord;
}

}
}
