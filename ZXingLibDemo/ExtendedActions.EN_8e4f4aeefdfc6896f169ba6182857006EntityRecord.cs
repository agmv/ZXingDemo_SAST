using System.Diagnostics;
namespace ssZXingLibDemo {
public partial class ExtendedActions {
/// <summary>
/// Action: GetCodeDefaults
/// </summary>

public static async Task<RC_8acf1c157094e2761d62d068555c0d1c> GetCodeDefaults(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8acf1c157094e2761d62d068555c0d1c outParamRecord = default;
outParamRecord = new RC_8acf1c157094e2761d62d068555c0d1c();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetCodeDefaults", "5f2fbbba-c8e1-4b7d-b777-4464d640772b.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENCodeDefaultsEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"label\"" +
", \"sample\"" +
", \"margin\"" +
", \"width\"" +
", \"height\"" +
" FROM " + ENCodeDefaultsEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"label\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetCodeDefaults", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENCodeDefaultsEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
return outParamRecord;
}

}
}
