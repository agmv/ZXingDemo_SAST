using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetShape
/// </summary>

public static async Task<RC_0a89eeb60fa1f44b6316ca69b462007b> GetShape(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0a89eeb60fa1f44b6316ca69b462007b outParamRecord = default;
outParamRecord = new RC_0a89eeb60fa1f44b6316ca69b462007b();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENShapeEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetShape", "84d4f824-9f14-4359-aa9f-2e90e2e1e9f4.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENShapeEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"shape\"" +
", \"order\"" +
" FROM " + ENShapeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"shape\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetShape", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENShapeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
