namespace ssZXingLibDemo;

public partial class Actions {
public class lcvSendResetPasswordEmail : VarsBag {
public string inParamApplicationName;
public string inParamCustomerEmail;
public ST_7df0b593cd1052614bf3d2f66d1ab2efStructure resStartResetPassword_outParamStartResetPasswordResult = new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure();

public RL_8430333e95ceffc00def96d8abb01f75 queryResTryGetNameByEmail_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResTryGetNameByEmail_outParamCount = 0L;

public lcvSendResetPasswordEmail(string inParamApplicationName, string inParamCustomerEmail) {
this.inParamApplicationName = inParamApplicationName;
this.inParamCustomerEmail = inParamCustomerEmail;
}
}
public class lcoSendResetPasswordEmail : VarsBag {
public bool outParamSuccess = false;

public lcoSendResetPasswordEmail() {
}
}
/// <summary>
/// Action <code>SendResetPasswordEmail</code> that represents the Service Studio action
///  <code>SendResetPasswordEmail</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionSendResetPasswordEmail(IRequestContext requestContext,string inParamApplicationName,string inParamCustomerEmail,CancellationToken cancellationToken) {
bool outParamSuccess = default;
lcoSendResetPasswordEmail result = new lcoSendResetPasswordEmail();
lcvSendResetPasswordEmail localVars = new lcvSendResetPasswordEmail(inParamApplicationName, inParamCustomerEmail);
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendResetPasswordEmail", "82e5273e-87b6-4b68-8444-51cff0af2c32", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43") : null){
// StartResetPassword
localVars.resStartResetPassword_outParamStartResetPasswordResult = await ExtendedActions.StartResetPassword(requestContext,localVars.inParamCustomerEmail,cancellationToken);

// Success?
if(((localVars.resStartResetPassword_outParamStartResetPasswordResult.ssSuccess&&(BuiltInFunction.LengthSC (localVars.resStartResetPassword_outParamStartResetPasswordResult.ssVerificationCode)>0)))) {
// Query datasetTryGetNameByEmail
cancellationToken.ThrowIfCancellationRequested();
int datasetTryGetNameByEmail_maxRecords = 1;
if (datasetTryGetNameByEmail_maxRecords < 1) datasetTryGetNameByEmail_maxRecords = 1;
int datasetTryGetNameByEmail_startIndex = 0;(localVars.queryResTryGetNameByEmail_outParamList,localVars.queryResTryGetNameByEmail_outParamCount) = await FuncActionSendResetPasswordEmail.datasetTryGetNameByEmail(requestContext,datasetTryGetNameByEmail_maxRecords,datasetTryGetNameByEmail_startIndex,IterationMultiplicity.Never,localVars.inParamCustomerEmail,cancellationToken);

using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ResetPassword", "4aae6c97-fe49-4bf8-907a-a1998e93ac55", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43")) {
    var emailScreen = ServiceLocator.GetService<ssZXingLibDemo.Flows.FlowEmails.Emails_ResetPassword>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , localVars.inParamApplicationName, localVars.queryResTryGetNameByEmail_outParamList.CurrentRec.ssENUser.ssName, localVars.inParamCustomerEmail, localVars.resStartResetPassword_outParamStartResetPasswordResult.ssVerificationCode, cancellationToken),
        To = localVars.inParamCustomerEmail,
        From = "",
        Cc = "",
        Bcc = "",
        Subject = string.Empty,
        Headers = new List<string>(),
        Attachments = mappedAttachments,
        ExtraImagesToAppend = emailScreen.ImagesToEmbed()
    };

    await OutSystems.Application.Core.Email.EmailService.Instance.SendEmailAsync(message, sendEmailActivity, cancellationToken);
}
// Success = True
result.outParamSuccess=true;
} else {
// Fake success
// Success = True
result.outParamSuccess=true;
}

} //close CreateActionActivity using block
} //try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
#pragma warning disable 612,618 
DatabaseAccess.RollbackAllTransactions();
#pragma warning restore 612,618 

// Success = False
// Success = False
result.outParamSuccess=false;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamSuccess = result.outParamSuccess;
}
RETURN_STATEMENT:
return outParamSuccess;
}

public static class FuncActionSendResetPasswordEmail {

// Query Function "TryGetNameByEmail" JWBlqkFGQU2sNT7JKyBJAg of Action "SendResetPasswordEmail"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetTryGetNameByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpemEmail,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendResetPasswordEmail.TryGetNameByEmail", "aa656025-4641-4d41-ac35-3ec92b204902", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
StringBuilder selectBuilder = new StringBuilder();
StringBuilder fromBuilder = new StringBuilder();
StringBuilder whereBuilder = new StringBuilder();
StringBuilder orderByBuilder = new StringBuilder();
StringBuilder groupByBuilder = new StringBuilder();
StringBuilder havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.PiflgraHaEuERFHP8K8sMg/NodesNotShownInESpaceTree.JWBlqkFGQU2sNT7JKyBJAg, 61918b7a-e496-4b63-992b-b83299b21e43 ZXingLibDemo */");
selectBuilder.Append("SELECT NULL o0, \"enuser\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser\"");
whereBuilder.Append(" WHERE (\"enuser\".\"email\" = @qpemEmail)");
orderByBuilder.Append(" ORDER BY \"enuser\".\"name\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpemEmail", DbType.String, qpemEmail);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendResetPasswordEmail.TryGetNameByEmail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendResetPasswordEmail.TryGetNameByEmail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



}


}
