using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSideMenuBehavior
/// </summary>

public static async Task<RC_e3607d6b92545e5793fbeb99fc16b7e7> GetSideMenuBehavior(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_e3607d6b92545e5793fbeb99fc16b7e7 outParamRecord = default;
outParamRecord = new RC_e3607d6b92545e5793fbeb99fc16b7e7();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENSideMenuBehaviorEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSideMenuBehavior", "1b78c0f6-ecf3-4a49-aff7-874ff80bc0ad.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENSideMenuBehaviorEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"sidemenubehavior\"" +
" FROM " + ENSideMenuBehaviorEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"sidemenubehavior\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetSideMenuBehavior", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENSideMenuBehaviorEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
