using System.Diagnostics;
namespace ssZXingLibDemo {
public partial class ExtendedActions {
/// <summary>
/// Action: GetUser
/// </summary>

public static async Task<RC_ced013358a82a813f1d9a5108f17ce79> GetUser(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ced013358a82a813f1d9a5108f17ce79 outParamRecord = default;
outParamRecord = new RC_ced013358a82a813f1d9a5108f17ce79();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENUserEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetUser", "b04fd63d-2183-41df-ad66-4cbd5e2177a7.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"email\"" +
", \"photourl\"" +
", \"username\"" +
" FROM " + ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetUser", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
