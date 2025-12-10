using System.Diagnostics;
namespace ssZXingLibDemo {
public partial class ExtendedActions {
/// <summary>
/// Action: GetMapErrors
/// </summary>

public static async Task<RC_3d151c63adf137bd3c85eaa462bbbe0c> GetMapErrors(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3d151c63adf137bd3c85eaa462bbbe0c outParamRecord = default;
outParamRecord = new RC_3d151c63adf137bd3c85eaa462bbbe0c();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENMapErrorsEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetMapErrors", "07a05ab6-e329-4b93-ba6a-50ddec8a228e.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENMapErrorsEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"code\"" +
", \"message\"" +
" FROM " + ENMapErrorsEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"code\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetMapErrors", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENMapErrorsEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
