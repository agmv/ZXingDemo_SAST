using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDropdownType
/// </summary>

public static async Task<RC_7f56ea63061432843ab4dd16f4578b32> GetDropdownType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_7f56ea63061432843ab4dd16f4578b32 outParamRecord = default;
outParamRecord = new RC_7f56ea63061432843ab4dd16f4578b32();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDropdownType", "e225f392-825d-442c-ac1f-b4b08d829a5d.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDropdownTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DropdownType", "inParamId");
}
return outParamRecord;
}

}
}
