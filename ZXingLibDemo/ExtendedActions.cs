using System.Diagnostics;
using Pair = OutSystems.RuntimeCommon.Pair;

namespace ssZXingLibDemo;
public partial class ExtendedActions {
private static readonly ActivitySource activitySource = new(typeof(ExtendedActions).Namespace);
public static readonly ObjectKey rZXingLibDemoKey = ObjectKey.Parse("OWsqqzAfIE+gac9dGLB29A");
public static readonly ObjectKey roZXingLibDemoOwnerEspaceKey = ObjectKey.Parse("eouRYZbkY0uZK7gymbIeQw");
/// <summary>
/// Action: CheckZXingLibDemoRole
/// </summary>

public static async Task<bool> CheckZXingLibDemoRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = GenericExtendedActions.Check(requestContext, rZXingLibDemoKey.AsGuid, roZXingLibDemoOwnerEspaceKey.AsGuid);
} else {
outParamHasRole = GenericExtendedActions.Check(requestContext, rZXingLibDemoKey.AsGuid, roZXingLibDemoOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId));
}
return outParamHasRole;
}

/// <summary>
/// Action: GrantZXingLibDemoRole
/// </summary>

public static async Task GrantZXingLibDemoRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
if (string.IsNullOrEmpty(inParamUserId)){
GenericExtendedActions.Grant(requestContext, rZXingLibDemoKey.AsGuid, roZXingLibDemoOwnerEspaceKey.AsGuid);
} else {
GenericExtendedActions.Grant(requestContext, rZXingLibDemoKey.AsGuid, roZXingLibDemoOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId));
}
return;
}

/// <summary>
/// Action: RevokeZXingLibDemoRole
/// </summary>

public static async Task RevokeZXingLibDemoRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
if (string.IsNullOrEmpty(inParamUserId)){
GenericExtendedActions.Revoke(requestContext, rZXingLibDemoKey.AsGuid, roZXingLibDemoOwnerEspaceKey.AsGuid);
} else {
GenericExtendedActions.Revoke(requestContext, rZXingLibDemoKey.AsGuid, roZXingLibDemoOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId));
}
return;
}

/// <summary>
/// Action: StartResetPassword
/// </summary>

public static async Task<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> StartResetPassword(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
ST_7df0b593cd1052614bf3d2f66d1ab2efStructure outParamStartResetPasswordResult = default;
outParamStartResetPasswordResult = new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure();

(outParamStartResetPasswordResult.ssSuccess, outParamStartResetPasswordResult.ssVerificationCode) = await GenericExtendedActions.StartResetPasswordAsync(requestContext, inParamEmail, cancellationToken);
return outParamStartResetPasswordResult;
}

/// <summary>
/// Action: ListAppend
/// </summary>

public static async Task ListAppend<T>(IRequestContext requestContext,OSList<T> inParamList,T inParamElement,CancellationToken cancellationToken) {
inParamList.Append(inParamElement);return;
}

/// <summary>
/// Action: ListClear
/// </summary>

public static async Task ListClear<T>(IRequestContext requestContext,OSList<T> inParamList,CancellationToken cancellationToken) {
inParamList.Clear();return;
}

/// <summary>
/// Action: ListAppendAll
/// </summary>

public static async Task ListAppendAll<T>(IRequestContext requestContext,OSList<T> inParamList,OSList<T> inParamSourceList,CancellationToken cancellationToken) {
inParamList.AppendAll(inParamSourceList);return;
}

/// <summary>
/// Action: UpdateUserProfile
/// </summary>

public static async Task<ST_c57cc6bedbdc9e62046393fa735672cfStructure> UpdateUserProfile(IRequestContext requestContext,ST_da83da85e5348cd2800e701fda6288aaStructure inParamUserUpdateInfo,CancellationToken cancellationToken) {
ST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult = default;
outParamUpdateUserResult = new ST_c57cc6bedbdc9e62046393fa735672cfStructure();

outParamUpdateUserResult.ssSuccess = GenericExtendedActions.UpdateUserProfile(requestContext, inParamUserUpdateInfo.ssName, inParamUserUpdateInfo.ssPhotoURL, out outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidCredentials, out outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidName, out outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidPhotoURL);
return outParamUpdateUserResult;
}

}
