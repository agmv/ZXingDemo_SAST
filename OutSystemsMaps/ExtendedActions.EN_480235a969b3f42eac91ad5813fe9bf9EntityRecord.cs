using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetZoom
/// </summary>

public static async Task<RC_80e81fddca0089d3f29f81106c0bee34> GetZoom(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_80e81fddca0089d3f29f81106c0bee34 outParamRecord = default;
outParamRecord = new RC_80e81fddca0089d3f29f81106c0bee34();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetZoom", "e4acf07c-b38a-4871-a7c2-4017eaabe95c.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENZoomEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Zoom", "inParamId");
}
return outParamRecord;
}

}
}
