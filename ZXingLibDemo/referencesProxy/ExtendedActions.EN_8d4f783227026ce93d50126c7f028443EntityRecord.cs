using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetOrientation
/// </summary>

public static async Task<RC_3ba1d238c8e0f0c3e875fb37f0381cc6> GetOrientation(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3ba1d238c8e0f0c3e875fb37f0381cc6 outParamRecord = default;
outParamRecord = new RC_3ba1d238c8e0f0c3e875fb37f0381cc6();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENOrientationEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrientation", "90a713d2-cf9a-4beb-bb4e-337df2765360.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENOrientationEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"orientation\"" +
" FROM " + ENOrientationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"orientation\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrientation", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrientationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
