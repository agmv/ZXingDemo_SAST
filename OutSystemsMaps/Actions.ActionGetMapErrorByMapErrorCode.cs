namespace ssOutSystemsMaps;

public partial class Actions {
public class lcvGetMapErrorByMapErrorCode : VarsBag {
public string inParamMapErrorCode;
public RC_3d151c63adf137bd3c85eaa462bbbe0c resGetMapErrors_outParamRecord = new RC_3d151c63adf137bd3c85eaa462bbbe0c();

public lcvGetMapErrorByMapErrorCode(string inParamMapErrorCode) {
this.inParamMapErrorCode = inParamMapErrorCode;
}
}
public class lcoGetMapErrorByMapErrorCode : VarsBag {
public string outParamErrorMessage = "";

public lcoGetMapErrorByMapErrorCode() {
}
}
/// <summary>
/// Action <code>GetMapErrorByMapErrorCode</code> that represents the Service Studio action
///  <code>GetMapErrorByMapErrorCode</code> <p> Description: Method to get the Map Error information b
/// y a given Map Error code.</p>
/// </summary>
public static async Task<string> ActionGetMapErrorByMapErrorCode(IRequestContext requestContext,string inParamMapErrorCode,CancellationToken cancellationToken) {
string outParamErrorMessage = default;
lcoGetMapErrorByMapErrorCode result = new lcoGetMapErrorByMapErrorCode();
lcvGetMapErrorByMapErrorCode localVars = new lcvGetMapErrorByMapErrorCode(inParamMapErrorCode);
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetMapErrorByMapErrorCode", "090ed996-d282-4f1d-9770-115596ee342d", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa") : null){
// Has MapErrorCode ?
if(((localVars.inParamMapErrorCode!=BuiltInFunction.NullTextIdentifier ()))) {
// GetMapErrors
localVars.resGetMapErrors_outParamRecord = await ExtendedActions.GetMapErrors(requestContext,localVars.inParamMapErrorCode,cancellationToken);

// Return ErrorMessage
// ErrorMessage = GetMapErrors.Record.MapErrors.Message
result.outParamErrorMessage=localVars.resGetMapErrors_outParamRecord.ssENMapErrors.ssMessage;
} else {
// RaiseError ValidationException
throw new Ex_ValidationExceptionUserException ("Invalid Map Error Code!");

}

} //close CreateActionActivity using block
} //try

finally {
outParamErrorMessage = result.outParamErrorMessage;
}
RETURN_STATEMENT:
return outParamErrorMessage;
}

public static class FuncActionGetMapErrorByMapErrorCode {



}


}
