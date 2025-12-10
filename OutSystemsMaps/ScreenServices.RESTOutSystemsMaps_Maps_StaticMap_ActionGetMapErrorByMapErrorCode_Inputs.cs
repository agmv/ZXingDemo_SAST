using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("MapErrorCode")]
public string inParamMapErrorCode;


    public static RESTOutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTOutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Inputs result = inputParameters.ToObject<RESTOutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Inputs>(settings);
return result;
}


    public OutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Model ToModel() {OutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Model result = new OutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Model();
result.inParamMapErrorCode = inParamMapErrorCode == null ? "" : inParamMapErrorCode;
return result;
}

}
