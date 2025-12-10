using System.Diagnostics;
namespace ssZXingLibDemo {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDirection
/// </summary>

public static async Task<RC_070998dc6b3dc951b52d8108550fe380> GetDirection(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_070998dc6b3dc951b52d8108550fe380 outParamRecord = default;
outParamRecord = new RC_070998dc6b3dc951b52d8108550fe380();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENDirectionEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDirection", "629466ff-6854-4bfd-a48d-8c13cf51e149.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENDirectionEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"direction\"" +
", \"order\"" +
" FROM " + ENDirectionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"direction\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetDirection", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENDirectionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
