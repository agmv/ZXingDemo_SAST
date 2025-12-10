using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("MapErrorCode")]
public string inParamMapErrorCode;


    public static RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Inputs result = inputParameters.ToObject<RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Inputs>(settings);
return result;
}


    public OutSystemsMaps_ActionGetMapErrorByMapErrorCode_Model ToModel() {OutSystemsMaps_ActionGetMapErrorByMapErrorCode_Model result = new OutSystemsMaps_ActionGetMapErrorByMapErrorCode_Model();
result.inParamMapErrorCode = inParamMapErrorCode == null ? "" : inParamMapErrorCode;
return result;
}

}
