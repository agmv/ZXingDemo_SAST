using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_Maps_StaticMap_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("APIKey")]
public string inParamAPIKey;
[JsonProperty("Center")]
public string inParamCenter;
[JsonProperty("Height")]
public string inParamHeight;
[JsonProperty("StaticMarkers")]
public RestList<ssOutSystemsMaps.RestRecords.RESTST_832344699c82a4f799a423f89bbe7297Structure> inParamStaticMarkers;
[JsonProperty("OptionalStaticMapConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure inParamOptionalStaticMapConfigs;
[JsonProperty("Internal_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure varLcInternal_Configs;
[JsonProperty("MarkersHashcode")]
public long? varLcMarkersHashcode;
[JsonProperty("IsSecondRound")]
public bool? varLcIsSecondRound;
[JsonProperty("ObtainMapKey")]
public RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs varLcObtainMapKey;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();


    public static RESTOutSystemsMaps_Maps_StaticMap_ScreenModel FromJSON(JObject screenModel, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTOutSystemsMaps_Maps_StaticMap_ScreenModel result = screenModel.ToObject<RESTOutSystemsMaps_Maps_StaticMap_ScreenModel>(settings);
return result;
}


    public OutSystemsMaps_Maps_StaticMap_ScreenModel ToModel() {string inParamAPIKey = variables.inParamAPIKey == null ? "" : variables.inParamAPIKey;
string inParamCenter = variables.inParamCenter == null ? "42.3517926,-71.0467845" : variables.inParamCenter;
string inParamHeight = variables.inParamHeight == null ? "" : variables.inParamHeight;
RL_7c4605673564471d88af1f24f7fd0a58 inParamStaticMarkers = RL_7c4605673564471d88af1f24f7fd0a58.FromRestList(variables.inParamStaticMarkers, ssOutSystemsMaps.RestRecords.RESTST_832344699c82a4f799a423f89bbe7297Structure.ToStructure);
ST_b2c05afcf4810ad0d4384a01306bb0f3Structure inParamOptionalStaticMapConfigs = ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure.ToStructure(variables.inParamOptionalStaticMapConfigs);
ST_78d3133d124713193d703c2644ecd39bStructure varLcInternal_Configs = ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure.ToStructure(variables.varLcInternal_Configs);
long varLcMarkersHashcode = variables.varLcMarkersHashcode == null ? Convert.ToInt64((-999)) : variables.varLcMarkersHashcode.Value;
bool varLcIsSecondRound = variables.varLcIsSecondRound == null ? false : variables.varLcIsSecondRound.Value;
OutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Model _varLcObtainMapKey = (variables.varLcObtainMapKey != null) ? RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs.ToModel(variables.varLcObtainMapKey) : null;
OutSystemsMaps_Maps_StaticMap_ScreenModel screenModel = new OutSystemsMaps_Maps_StaticMap_ScreenModel(inParamAPIKey, inParamCenter, inParamHeight, inParamStaticMarkers, inParamOptionalStaticMapConfigs, varLcInternal_Configs, varLcMarkersHashcode, varLcIsSecondRound, _varLcObtainMapKey);
return screenModel;
}

}
