using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetLogType
/// </summary>

public static async Task<RC_6633adb48f346ff9147637b286666408> GetLogType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_6633adb48f346ff9147637b286666408 outParamRecord = default;
outParamRecord = new RC_6633adb48f346ff9147637b286666408();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetLogType", "00f4d392-689e-4d22-b7e4-fb21b53c5072.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENLogTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("LogType", "inParamId");
}
return outParamRecord;
}

}
}
