using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ServerAPIKey")]
public string outParamServerAPIKey;


    public static RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamServerAPIKey) {RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs result = new RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs();
result.outParamServerAPIKey = outParamServerAPIKey;
return result;
}


    public static OutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Model ToModel(RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs variables) {OutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Model result = new OutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Model();
result.outParamServerAPIKey = variables == null || variables.outParamServerAPIKey == null ? "" : variables.outParamServerAPIKey;
return result;
}


    public static RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs FromModel(IBehaviorsConfiguration conf, OutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs result = new RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs();
result.outParamServerAPIKey = screenModel.outParamServerAPIKey;
return result;
}

}
