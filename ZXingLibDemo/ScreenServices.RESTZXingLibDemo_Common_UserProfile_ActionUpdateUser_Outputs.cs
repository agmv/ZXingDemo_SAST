using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UpdateUserResult")]
public ssZXingLibDemo.RestRecords.RESTST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult;


    public static RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult) {RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Outputs result = new RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamUpdateUserResult to the result.outParamUpdateUserResult
result.outParamUpdateUserResult = new ssZXingLibDemo.RestRecords.RESTST_c57cc6bedbdc9e62046393fa735672cfStructure();
result.outParamUpdateUserResult.AttrSuccess = (bool?) outParamUpdateUserResult.ssSuccess;
// Write optimized result.outParamUpdateUserResult.AttrUserPhotoURL
result.outParamUpdateUserResult.AttrUserPhotoURL = "";
// Write the needed fields of the record outParamUpdateUserResult.ssUpdateUserFailureReason to the result.outParamUpdateUserResult.AttrUpdateUserFailureReason
result.outParamUpdateUserResult.AttrUpdateUserFailureReason = new ssZXingLibDemo.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure();
result.outParamUpdateUserResult.AttrUpdateUserFailureReason.AttrInvalidCredentials = (bool?) outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidCredentials;
result.outParamUpdateUserResult.AttrUpdateUserFailureReason.AttrInvalidName = (bool?) outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidName;
// Write optimized result.outParamUpdateUserResult.AttrUpdateUserFailureReason.AttrInvalidPhotoURL
result.outParamUpdateUserResult.AttrUpdateUserFailureReason.AttrInvalidPhotoURL = (bool?) false;
return result;
}


    

    
}
