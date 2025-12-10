using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_Maps_Map_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("APIKey")]
public string inParamAPIKey;
[JsonProperty("Center")]
public string inParamCenter;
[JsonProperty("Height")]
public string inParamHeight;
[JsonProperty("OptionalConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure inParamOptionalConfigs;
[JsonProperty("Internal_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure varLcInternal_Configs;
[JsonProperty("IsSecondRound")]
public bool? varLcIsSecondRound;
[JsonProperty("GetServerAPIKey")]
public RESTOutSystemsMaps_Maps_Map_DataActionGetServerAPIKey_Outputs varLcGetServerAPIKey;
[JsonProperty("GetApiVersion")]
public RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs varLcGetApiVersion;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();


    public static RESTOutSystemsMaps_Maps_Map_ScreenModel FromJSON(JObject screenModel, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTOutSystemsMaps_Maps_Map_ScreenModel result = screenModel.ToObject<RESTOutSystemsMaps_Maps_Map_ScreenModel>(settings);
return result;
}


    public OutSystemsMaps_Maps_Map_ScreenModel ToModel() {string inParamAPIKey = variables.inParamAPIKey == null ? "" : variables.inParamAPIKey;
string inParamCenter = variables.inParamCenter == null ? "42.3517926,-71.0467845" : variables.inParamCenter;
string inParamHeight = variables.inParamHeight == null ? "" : variables.inParamHeight;
ST_d609eacb476c603df8b92eb374da99faStructure inParamOptionalConfigs = ssOutSystemsMaps.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure.ToStructure(variables.inParamOptionalConfigs);
ST_78d3133d124713193d703c2644ecd39bStructure varLcInternal_Configs = ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure.ToStructure(variables.varLcInternal_Configs);
bool varLcIsSecondRound = variables.varLcIsSecondRound == null ? false : variables.varLcIsSecondRound.Value;
OutSystemsMaps_Maps_Map_DataActionGetServerAPIKey_Model _varLcGetServerAPIKey = (variables.varLcGetServerAPIKey != null) ? RESTOutSystemsMaps_Maps_Map_DataActionGetServerAPIKey_Outputs.ToModel(variables.varLcGetServerAPIKey) : null;
OutSystemsMaps_Maps_Map_DataActionGetApiVersion_Model _varLcGetApiVersion = (variables.varLcGetApiVersion != null) ? RESTOutSystemsMaps_Maps_Map_DataActionGetApiVersion_Outputs.ToModel(variables.varLcGetApiVersion) : null;
OutSystemsMaps_Maps_Map_ScreenModel screenModel = new OutSystemsMaps_Maps_Map_ScreenModel(inParamAPIKey, inParamCenter, inParamHeight, inParamOptionalConfigs, varLcInternal_Configs, varLcIsSecondRound, _varLcGetServerAPIKey, _varLcGetApiVersion);
return screenModel;
}

}
