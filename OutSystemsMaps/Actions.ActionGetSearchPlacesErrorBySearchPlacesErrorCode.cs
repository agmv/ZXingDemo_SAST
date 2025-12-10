namespace ssOutSystemsMaps;

public partial class Actions {
public class lcvGetSearchPlacesErrorBySearchPlacesErrorCode : VarsBag {
public string inParamSearchPlacesErrorCode;
public RC_28b5debce9c04e64c6dd40275449bf6c resGetSearchPlacesErrors_outParamRecord = new RC_28b5debce9c04e64c6dd40275449bf6c();

public lcvGetSearchPlacesErrorBySearchPlacesErrorCode(string inParamSearchPlacesErrorCode) {
this.inParamSearchPlacesErrorCode = inParamSearchPlacesErrorCode;
}
}
public class lcoGetSearchPlacesErrorBySearchPlacesErrorCode : VarsBag {
public string outParamErrorMessage = "";

public lcoGetSearchPlacesErrorBySearchPlacesErrorCode() {
}
}
/// <summary>
/// Action <code>GetSearchPlacesErrorBySearchPlacesErrorCode</code> that represents the Service Studio
///  action <code>GetSearchPlacesErrorBySearchPlacesErrorCode</code> <p> Description: Method to get th
/// e Search Places Error information by a given Search Place Error code.</p>
/// </summary>
public static async Task<string> ActionGetSearchPlacesErrorBySearchPlacesErrorCode(IRequestContext requestContext,string inParamSearchPlacesErrorCode,CancellationToken cancellationToken) {
string outParamErrorMessage = default;
lcoGetSearchPlacesErrorBySearchPlacesErrorCode result = new lcoGetSearchPlacesErrorBySearchPlacesErrorCode();
lcvGetSearchPlacesErrorBySearchPlacesErrorCode localVars = new lcvGetSearchPlacesErrorBySearchPlacesErrorCode(inParamSearchPlacesErrorCode);
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetSearchPlacesErrorBySearchPlacesErrorCode", "765f9c11-4bf8-432b-97fc-90c9845f8fe8", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa") : null){
// Has SearchPlacesErrorCode ?
if(((localVars.inParamSearchPlacesErrorCode!=BuiltInFunction.NullTextIdentifier ()))) {
// GetSearchPlacesErrors
localVars.resGetSearchPlacesErrors_outParamRecord = await ExtendedActions.GetSearchPlacesErrors(requestContext,localVars.inParamSearchPlacesErrorCode,cancellationToken);

// Return ErrorMessage
// ErrorMessage = GetSearchPlacesErrors.Record.SearchPlacesErrors.Message
result.outParamErrorMessage=localVars.resGetSearchPlacesErrors_outParamRecord.ssENSearchPlacesErrors.ssMessage;
} else {
// RaiseError ValidationException
throw new Ex_ValidationExceptionUserException ("Invalid Search Places Error Code!");

}

} //close CreateActionActivity using block
} //try

finally {
outParamErrorMessage = result.outParamErrorMessage;
}
RETURN_STATEMENT:
return outParamErrorMessage;
}

public static class FuncActionGetSearchPlacesErrorBySearchPlacesErrorCode {



}


}
