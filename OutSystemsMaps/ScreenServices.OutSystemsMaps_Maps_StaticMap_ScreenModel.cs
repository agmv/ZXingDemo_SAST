using System.Diagnostics;

using ssOutSystemsMaps;


namespace ssOutSystemsMaps.ScreenServices;

public class OutSystemsMaps_Maps_StaticMap_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(OutSystemsMaps_Maps_StaticMap_ScreenModel).Namespace);

    public string inParamAPIKey;
public string inParamCenter;
public string inParamHeight;
public RL_7c4605673564471d88af1f24f7fd0a58 inParamStaticMarkers;
public ST_b2c05afcf4810ad0d4384a01306bb0f3Structure inParamOptionalStaticMapConfigs;
public ST_78d3133d124713193d703c2644ecd39bStructure varLcInternal_Configs;
public long varLcMarkersHashcode;
public bool varLcIsSecondRound;
public OutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Model varLcObtainMapKey;


    public OutSystemsMaps_Maps_StaticMap_ScreenModel() {
}



    public OutSystemsMaps_Maps_StaticMap_ScreenModel(string inParamAPIKey, string inParamCenter, string inParamHeight, RL_7c4605673564471d88af1f24f7fd0a58 inParamStaticMarkers, ST_b2c05afcf4810ad0d4384a01306bb0f3Structure inParamOptionalStaticMapConfigs, ST_78d3133d124713193d703c2644ecd39bStructure varLcInternal_Configs, long varLcMarkersHashcode, bool varLcIsSecondRound, OutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Model varLcObtainMapKey) {
Init(new string[] {"APIKey", "Center", "Height", "StaticMarkers", "OptionalStaticMapConfigs", "Internal_Configs", "MarkersHashcode", "IsSecondRound", "ObtainMapKey"}, new string[] {"inParamAPIKey", "inParamCenter", "inParamHeight", "inParamStaticMarkers", "inParamOptionalStaticMapConfigs", "varLcInternal_Configs", "varLcMarkersHashcode", "varLcIsSecondRound", "varLcObtainMapKey"});
this.inParamAPIKey = inParamAPIKey;
this.inParamCenter = inParamCenter;
this.inParamHeight = inParamHeight;
this.inParamStaticMarkers = inParamStaticMarkers;
this.inParamOptionalStaticMapConfigs = inParamOptionalStaticMapConfigs;
this.varLcInternal_Configs = varLcInternal_Configs;
this.varLcMarkersHashcode = varLcMarkersHashcode;
this.varLcIsSecondRound = varLcIsSecondRound;
this.varLcObtainMapKey = varLcObtainMapKey;
}



    

    public class lcvObtainMapKey : VarsBag {
public Actions.lcoGetGoogleMapsServerKey resGetGoogleMapsServerKey =  new Actions.lcoGetGoogleMapsServerKey();
public lcvObtainMapKey() {
}
}
public class lcoObtainMapKey : VarsBag {
public string outParamServerAPIKey = "";

public lcoObtainMapKey() {
}
}
/// <summary>
/// Action <code>ObtainMapKey</code> that represents the Service Studio action
///  <code>ObtainMapKey</code> <p> Description: </p>
/// </summary>
public async Task<string> DataActionObtainMapKey(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamServerAPIKey = default;
lcoObtainMapKey result = new lcoObtainMapKey();
lcvObtainMapKey localVars = new lcvObtainMapKey();
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateScreenDataActionActivity("StaticMap", "ObtainMapKey")){
// GetGoogleMapsServerKey
localVars.resGetGoogleMapsServerKey.outParamKey = await Actions.ActionGetGoogleMapsServerKey(requestContext,cancellationToken);

// ServerAPIKey = GetGoogleMapsServerKey.Key
result.outParamServerAPIKey=localVars.resGetGoogleMapsServerKey.outParamKey;
} //close CreateActionActivity using block
} //try

finally {
outParamServerAPIKey = result.outParamServerAPIKey;
}
RETURN_STATEMENT:
return outParamServerAPIKey;
}


    public static class FuncDataActionObtainMapKey {
}


}
