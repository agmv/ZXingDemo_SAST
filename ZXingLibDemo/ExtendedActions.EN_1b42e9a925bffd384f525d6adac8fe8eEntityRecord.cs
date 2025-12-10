using System.Diagnostics;
namespace ssZXingLibDemo {
public partial class ExtendedActions {
/// <summary>
/// Action: GetDatePickerWeekDay
/// </summary>

public static async Task<RC_210f541f43ec6384ba59bfd8fe4b8837> GetDatePickerWeekDay(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_210f541f43ec6384ba59bfd8fe4b8837 outParamRecord = default;
outParamRecord = new RC_210f541f43ec6384ba59bfd8fe4b8837();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENDatePickerWeekDayEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetDatePickerWeekDay", "1240b21d-adf9-4937-b79f-6d2821b2b8cd.#GetEntity", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
try {
outParamRecord = ENDatePickerWeekDayEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"weekday\"" +
" FROM " + ENDatePickerWeekDayEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"weekday\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetDatePickerWeekDay", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENDatePickerWeekDayEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
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
