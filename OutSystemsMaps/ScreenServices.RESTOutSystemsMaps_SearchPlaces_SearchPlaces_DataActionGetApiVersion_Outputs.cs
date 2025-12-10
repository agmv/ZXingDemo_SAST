using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("GoogleMapsApiVersion")]
public string outParamGoogleMapsApiVersion;


    public static RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamGoogleMapsApiVersion) {RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Outputs result = new RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Outputs();
result.outParamGoogleMapsApiVersion = outParamGoogleMapsApiVersion;
return result;
}


    public static OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Model ToModel(RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Outputs variables) {OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Model result = new OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Model();
result.outParamGoogleMapsApiVersion = variables == null || variables.outParamGoogleMapsApiVersion == null ? "" : variables.outParamGoogleMapsApiVersion;
return result;
}


    public static RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Outputs FromModel(IBehaviorsConfiguration conf, OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Outputs result = new RESTOutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Outputs();
result.outParamGoogleMapsApiVersion = screenModel.outParamGoogleMapsApiVersion;
return result;
}

}
