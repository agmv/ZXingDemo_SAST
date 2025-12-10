using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserUpdateInfo")]
public ssZXingLibDemo.RestRecords.RESTST_da83da85e5348cd2800e701fda6288aaStructure inParamUserUpdateInfo;


    public static RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Inputs result = inputParameters.ToObject<RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Inputs>(settings);
return result;
}


    public ZXingLibDemo_Common_UserProfile_ActionUpdateUser_Model ToModel() {ZXingLibDemo_Common_UserProfile_ActionUpdateUser_Model result = new ZXingLibDemo_Common_UserProfile_ActionUpdateUser_Model();
result.inParamUserUpdateInfo = ssZXingLibDemo.RestRecords.RESTST_da83da85e5348cd2800e701fda6288aaStructure.ToStructure(inParamUserUpdateInfo);
return result;
}

}
