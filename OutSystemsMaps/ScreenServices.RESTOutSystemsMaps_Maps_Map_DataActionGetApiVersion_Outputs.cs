using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("GoogleMapsApiVersion")]
public string outParamGoogleMapsApiVersion;


    public static RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamGoogleMapsApiVersion) {RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs result = new RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs();
result.outParamGoogleMapsApiVersion = outParamGoogleMapsApiVersion;
return result;
}


    public static OutSystemsMaps_Maps_Map_DataActionGetApiVersion_Model ToModel(RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs variables) {OutSystemsMaps_Maps_Map_DataActionGetApiVersion_Model result = new OutSystemsMaps_Maps_Map_DataActionGetApiVersion_Model();
result.outParamGoogleMapsApiVersion = variables == null || variables.outParamGoogleMapsApiVersion == null ? "" : variables.outParamGoogleMapsApiVersion;
return result;
}


    public static RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs FromModel(IBehaviorsConfiguration conf, OutSystemsMaps_Maps_Map_DataActionGetApiVersion_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs result = new RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs();
result.outParamGoogleMapsApiVersion = screenModel.outParamGoogleMapsApiVersion;
return result;
}

}
