using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMapEventTriggered
/// </summary>

public static async Task<RC_bf75694d8016688134fa555a2fd4f5d7> GetMapEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_bf75694d8016688134fa555a2fd4f5d7 outParamRecord = default;
outParamRecord = new RC_bf75694d8016688134fa555a2fd4f5d7();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENMapEventTriggeredEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMapEventTriggered", "70fbbf84-5031-4523-90ed-df9424fd74af.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENMapEventTriggeredEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
" FROM " + ENMapEventTriggeredEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetMapEventTriggered", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENMapEventTriggeredEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
return outParamRecord;
}

}
}
