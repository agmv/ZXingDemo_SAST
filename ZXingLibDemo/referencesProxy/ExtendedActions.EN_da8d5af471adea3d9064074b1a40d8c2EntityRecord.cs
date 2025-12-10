using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetType
/// </summary>

public static async Task<RC_b32e755d03dd085a4b975b8c0c7d4454> GetType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_b32e755d03dd085a4b975b8c0c7d4454 outParamRecord = default;
outParamRecord = new RC_b32e755d03dd085a4b975b8c0c7d4454();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENTypeEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetType", "d01cdbce-e647-4be8-9075-93b3c4c61dc7.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENTypeEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"maptype\"" +
", \"label\"" +
", \"order\"" +
", \"is_active\"" +
" FROM " + ENTypeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"maptype\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENTypeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
