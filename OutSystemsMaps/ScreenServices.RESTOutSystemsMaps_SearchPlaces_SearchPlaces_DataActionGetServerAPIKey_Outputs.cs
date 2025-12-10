using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ServerAPIKey")]
public string outParamServerAPIKey;
[JsonProperty("GoogleMapsApiVersion")]
public string outParamGoogleMapsApiVersion;


    public static RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamServerAPIKey, string outParamGoogleMapsApiVersion) {RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Outputs result = new RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Outputs();
result.outParamServerAPIKey = outParamServerAPIKey;
result.outParamGoogleMapsApiVersion = outParamGoogleMapsApiVersion;
return result;
}


    public static OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Model ToModel(RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Outputs variables) {OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Model result = new OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Model();
result.outParamServerAPIKey = variables == null || variables.outParamServerAPIKey == null ? "" : variables.outParamServerAPIKey;
result.outParamGoogleMapsApiVersion = variables == null || variables.outParamGoogleMapsApiVersion == null ? "" : variables.outParamGoogleMapsApiVersion;
return result;
}


    public static RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Outputs FromModel(IBehaviorsConfiguration conf, OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Outputs result = new RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Outputs();
result.outParamServerAPIKey = screenModel.outParamServerAPIKey;
result.outParamGoogleMapsApiVersion = screenModel.outParamGoogleMapsApiVersion;
return result;
}

}
