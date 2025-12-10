using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ErrorMessage")]
public string outParamErrorMessage;


    public static RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamErrorMessage) {RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Outputs result = new RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Outputs();
conf.IncludeBinariesURL = false;
result.outParamErrorMessage = outParamErrorMessage;
return result;
}


    

    
}
