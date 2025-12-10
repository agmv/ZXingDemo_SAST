using System.Diagnostics;
namespace ssZXingLibDemo {
public partial class ExtendedActions {
/// <summary>
/// Action: GetZoom
/// </summary>

public static async Task<RC_80e81fddca0089d3f29f81106c0bee34> GetZoom(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_80e81fddca0089d3f29f81106c0bee34 outParamRecord = default;
outParamRecord = new RC_80e81fddca0089d3f29f81106c0bee34();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENZoomEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetZoom", "9a5ccc75-f381-4f1b-9137-998e5774ab17.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENZoomEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"label\"" +
", \"zoom\"" +
" FROM " + ENZoomEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetZoom", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENZoomEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
