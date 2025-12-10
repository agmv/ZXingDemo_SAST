using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ApplicationName")]
public string inParamApplicationName;
[JsonProperty("CustomerEmail")]
public string inParamCustomerEmail;


    public static RESTZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Inputs result = inputParameters.ToObject<RESTZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Inputs>(settings);
return result;
}


    public ZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Model ToModel() {ZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Model result = new ZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Model();
result.inParamApplicationName = inParamApplicationName == null ? "" : inParamApplicationName;
result.inParamCustomerEmail = inParamCustomerEmail == null ? "" : inParamCustomerEmail;
return result;
}

}
