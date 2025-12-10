using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetScrollbarStyle
/// </summary>

public static async Task<RC_3d7c5be4055c8fe2c227afc40d8dee2f> GetScrollbarStyle(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3d7c5be4055c8fe2c227afc40d8dee2f outParamRecord = default;
outParamRecord = new RC_3d7c5be4055c8fe2c227afc40d8dee2f();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetScrollbarStyle", "c3d6dfea-6da2-468a-80e4-5ce668d43f70.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENScrollbarStyleEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ScrollbarStyle", "inParamId");
}
return outParamRecord;
}

}
}
