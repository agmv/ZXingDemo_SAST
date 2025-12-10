using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Success")]
public bool? outParamSuccess;


    public static RESTZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamSuccess) {RESTZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Outputs result = new RESTZXingLibDemo_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Outputs();
conf.IncludeBinariesURL = false;
result.outParamSuccess = (bool?) outParamSuccess;
return result;
}


    

    
}
