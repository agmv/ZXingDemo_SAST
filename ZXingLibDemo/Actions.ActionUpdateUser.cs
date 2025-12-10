namespace ssZXingLibDemo;

public partial class Actions {
public class lcvUpdateUser : VarsBag {
public ST_da83da85e5348cd2800e701fda6288aaStructure inParamUserUpdateInfo;
public ST_c57cc6bedbdc9e62046393fa735672cfStructure resUpdateUserProfile_outParamUpdateUserResult = new ST_c57cc6bedbdc9e62046393fa735672cfStructure();

public lcvUpdateUser(ST_da83da85e5348cd2800e701fda6288aaStructure inParamUserUpdateInfo) {
this.inParamUserUpdateInfo = inParamUserUpdateInfo;
}
}
public class lcoUpdateUser : VarsBag {
public ST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult = new ST_c57cc6bedbdc9e62046393fa735672cfStructure();

public lcoUpdateUser() {
}
}
/// <summary>
/// Action <code>UpdateUser</code> that represents the Service Studio action <code>UpdateUser</code>
///  <p> Description: Allows a logged-in user to edit profile information. The user email can't b
/// e changed using this action.  Throws an exception if the built-in identity provider is disabled for
///  the current app.</p>
/// </summary>
public static async Task<ST_c57cc6bedbdc9e62046393fa735672cfStructure> ActionUpdateUser(IRequestContext requestContext,ST_da83da85e5348cd2800e701fda6288aaStructure inParamUserUpdateInfo,CancellationToken cancellationToken) {
ST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult = default;
lcoUpdateUser result = new lcoUpdateUser();
lcvUpdateUser localVars = new lcvUpdateUser(inParamUserUpdateInfo);
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UpdateUser", "07cdfda9-d775-4f13-8c33-3f2164d4abd6", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43") : null){
// UpdateUserProfile
localVars.resUpdateUserProfile_outParamUpdateUserResult = await ExtendedActions.UpdateUserProfile(requestContext,localVars.inParamUserUpdateInfo,cancellationToken);

// UpdateUserResult = UpdateUserProfile.UpdateUserResult
result.outParamUpdateUserResult=localVars.resUpdateUserProfile_outParamUpdateUserResult;
} //close CreateActionActivity using block
} //try

finally {
outParamUpdateUserResult = result.outParamUpdateUserResult;
}
RETURN_STATEMENT:
return outParamUpdateUserResult;
}

public static class FuncActionUpdateUser {



}


}
