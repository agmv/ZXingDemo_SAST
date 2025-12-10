using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDeviceResponsive
/// </summary>

public static async Task<RC_1583be5d90a94b6a73170ffa868eecc5> GetDeviceResponsive(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_1583be5d90a94b6a73170ffa868eecc5 outParamRecord = default;
outParamRecord = new RC_1583be5d90a94b6a73170ffa868eecc5();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDeviceResponsive", "29468e1d-a25a-42c3-bf53-b232accc150d.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENDeviceResponsiveEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("DeviceResponsive", "inParamId");
}
return outParamRecord;
}

}
}
