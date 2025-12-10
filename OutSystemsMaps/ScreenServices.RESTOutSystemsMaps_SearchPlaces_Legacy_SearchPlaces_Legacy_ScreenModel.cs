using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssOutSystemsMaps.ScreenServices;

public class RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("APIKey")]
public string inParamAPIKey;
[JsonProperty("OptionalConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure inParamOptionalConfigs;
[JsonProperty("UniqueId")]
public string varLcUniqueId;
[JsonProperty("IsSecondRound")]
public bool? varLcIsSecondRound;
[JsonProperty("Internal_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_b0933bf7957301c22e5d9229ad792ac0Structure varLcInternal_Configs;
[JsonProperty("SearchAreaString")]
public string varLcSearchAreaString;
[JsonProperty("SearchArea")]
public ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure varLcSearchArea;
[JsonProperty("CountriesString")]
public string varLcCountriesString;
[JsonProperty("GetApiVersion")]
public RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_DataActionGetApiVersion_Outputs varLcGetApiVersion;
[JsonProperty("GetServerAPIKey")]
public RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_DataActionGetServerAPIKey_Outputs varLcGetServerAPIKey;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();


    public static RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel FromJSON(JObject screenModel, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel result = screenModel.ToObject<RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel>(settings);
return result;
}


    public OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel ToModel() {string inParamAPIKey = variables.inParamAPIKey == null ? "" : variables.inParamAPIKey;
ST_7cd861eaa819851d6fba6d8150ed8cc1Structure inParamOptionalConfigs = ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure.ToStructure(variables.inParamOptionalConfigs);
string varLcUniqueId = variables.varLcUniqueId == null ? "" : variables.varLcUniqueId;
bool varLcIsSecondRound = variables.varLcIsSecondRound == null ? false : variables.varLcIsSecondRound.Value;
ST_b0933bf7957301c22e5d9229ad792ac0Structure varLcInternal_Configs = ssOutSystemsMaps.RestRecords.RESTST_b0933bf7957301c22e5d9229ad792ac0Structure.ToStructure(variables.varLcInternal_Configs);
string varLcSearchAreaString = variables.varLcSearchAreaString == null ? "" : variables.varLcSearchAreaString;
ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure varLcSearchArea = ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.ToStructure(variables.varLcSearchArea);
string varLcCountriesString = variables.varLcCountriesString == null ? "" : variables.varLcCountriesString;
OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_DataActionGetApiVersion_Model _varLcGetApiVersion = (variables.varLcGetApiVersion != null) ? RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_DataActionGetApiVersion_Outputs.ToModel(variables.varLcGetApiVersion) : null;
OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_DataActionGetServerAPIKey_Model _varLcGetServerAPIKey = (variables.varLcGetServerAPIKey != null) ? RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_DataActionGetServerAPIKey_Outputs.ToModel(variables.varLcGetServerAPIKey) : null;
OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel screenModel = new OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel(inParamAPIKey, inParamOptionalConfigs, varLcUniqueId, varLcIsSecondRound, varLcInternal_Configs, varLcSearchAreaString, varLcSearchArea, varLcCountriesString, _varLcGetApiVersion, _varLcGetServerAPIKey);
return screenModel;
}

}
