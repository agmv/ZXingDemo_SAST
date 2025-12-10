using System.Diagnostics;
namespace ssZXingLibDemo {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDatePickerTimeFormat
/// </summary>

public static async Task<RC_51b1c15949308af5f9b2dba7043d5ae6> GetDatePickerTimeFormat(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_51b1c15949308af5f9b2dba7043d5ae6 outParamRecord = default;
outParamRecord = new RC_51b1c15949308af5f9b2dba7043d5ae6();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENDatePickerTimeFormatEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDatePickerTimeFormat", "16c3e48d-f7cb-4df5-a979-54ed5cb94b11.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENDatePickerTimeFormatEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"timeformat\"" +
" FROM " + ENDatePickerTimeFormatEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"timeformat\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetDatePickerTimeFormat", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENDatePickerTimeFormatEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
