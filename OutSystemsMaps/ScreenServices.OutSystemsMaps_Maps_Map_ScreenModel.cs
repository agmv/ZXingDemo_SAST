using System.Diagnostics;

using ssOutSystemsMaps;


namespace ssOutSystemsMaps.ScreenServices;

public class OutSystemsMaps_Maps_Map_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(OutSystemsMaps_Maps_Map_ScreenModel).Namespace);

    public string inParamAPIKey;
public string inParamCenter;
public string inParamHeight;
public ST_d609eacb476c603df8b92eb374da99faStructure inParamOptionalConfigs;
public ST_78d3133d124713193d703c2644ecd39bStructure varLcInternal_Configs;
public bool varLcIsSecondRound;
public OutSystemsMaps_Maps_Map_DataActionGetServerAPIKey_Model varLcGetServerAPIKey;
public OutSystemsMaps_Maps_Map_DataActionGetApiVersion_Model varLcGetApiVersion;


    public OutSystemsMaps_Maps_Map_ScreenModel() {
}



    public OutSystemsMaps_Maps_Map_ScreenModel(string inParamAPIKey, string inParamCenter, string inParamHeight, ST_d609eacb476c603df8b92eb374da99faStructure inParamOptionalConfigs, ST_78d3133d124713193d703c2644ecd39bStructure varLcInternal_Configs, bool varLcIsSecondRound, OutSystemsMaps_Maps_Map_DataActionGetServerAPIKey_Model varLcGetServerAPIKey, OutSystemsMaps_Maps_Map_DataActionGetApiVersion_Model varLcGetApiVersion) {
Init(new string[] {"APIKey", "Center", "Height", "OptionalConfigs", "Internal_Configs", "IsSecondRound", "GetServerAPIKey", "GetApiVersion"}, new string[] {"inParamAPIKey", "inParamCenter", "inParamHeight", "inParamOptionalConfigs", "varLcInternal_Configs", "varLcIsSecondRound", "varLcGetServerAPIKey", "varLcGetApiVersion"});
this.inParamAPIKey = inParamAPIKey;
this.inParamCenter = inParamCenter;
this.inParamHeight = inParamHeight;
this.inParamOptionalConfigs = inParamOptionalConfigs;
this.varLcInternal_Configs = varLcInternal_Configs;
this.varLcIsSecondRound = varLcIsSecondRound;
this.varLcGetServerAPIKey = varLcGetServerAPIKey;
this.varLcGetApiVersion = varLcGetApiVersion;
}



    

    public class lcvGetServerAPIKey : VarsBag {
public Actions.lcoGetGoogleMapsServerKey resGetGoogleMapsServerKey =  new Actions.lcoGetGoogleMapsServerKey();
public Actions.lcoGetGoogleMapsVersion resGetGoogleMapsVersion =  new Actions.lcoGetGoogleMapsVersion();
public lcvGetServerAPIKey() {
}
}
public class lcoGetServerAPIKey : VarsBag {
public string outParamServerAPIKey = "";

public string outParamGoogleMapsApiVersion = "";

public lcoGetServerAPIKey() {
}
}
/// <summary>
/// Action <code>GetServerAPIKey</code> that represents the Service Studio action
///  <code>GetServerAPIKey</code> <p> Description: </p>
/// </summary>
public async Task<(string,string)> DataActionGetServerAPIKey(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamServerAPIKey = default;
string outParamGoogleMapsApiVersion = default;
lcoGetServerAPIKey result = new lcoGetServerAPIKey();
lcvGetServerAPIKey localVars = new lcvGetServerAPIKey();
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateScreenDataActionActivity("Map", "GetServerAPIKey")){
// GetGoogleMapsServerKey
localVars.resGetGoogleMapsServerKey.outParamKey = await Actions.ActionGetGoogleMapsServerKey(requestContext,cancellationToken);

// Set ServerAPIKey
// ServerAPIKey = GetGoogleMapsServerKey.Key
result.outParamServerAPIKey=localVars.resGetGoogleMapsServerKey.outParamKey;
// GetGoogleMapsVersion
localVars.resGetGoogleMapsVersion.outParamGoogleMapsApiVersion = await Actions.ActionGetGoogleMapsVersion(requestContext,cancellationToken);

// Set GoogleMapsApiVersion
// GoogleMapsApiVersion = GetGoogleMapsVersion.GoogleMapsApiVersion
result.outParamGoogleMapsApiVersion=localVars.resGetGoogleMapsVersion.outParamGoogleMapsApiVersion;
} //close CreateActionActivity using block
} //try

finally {
outParamServerAPIKey = result.outParamServerAPIKey;
outParamGoogleMapsApiVersion = result.outParamGoogleMapsApiVersion;
}
RETURN_STATEMENT:
return (outParamServerAPIKey,outParamGoogleMapsApiVersion);
}
public class lcvGetApiVersion : VarsBag {
public Actions.lcoGetGoogleMapsVersion resGetGoogleMapsVersion =  new Actions.lcoGetGoogleMapsVersion();
public lcvGetApiVersion() {
}
}
public class lcoGetApiVersion : VarsBag {
public string outParamGoogleMapsApiVersion = "";

public lcoGetApiVersion() {
}
}
/// <summary>
/// Action <code>GetApiVersion</code> that represents the Service Studio action
///  <code>GetApiVersion</code> <p> Description: </p>
/// </summary>
public async Task<string> DataActionGetApiVersion(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamGoogleMapsApiVersion = default;
lcoGetApiVersion result = new lcoGetApiVersion();
lcvGetApiVersion localVars = new lcvGetApiVersion();
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateScreenDataActionActivity("Map", "GetApiVersion")){
// GetGoogleMapsVersion
localVars.resGetGoogleMapsVersion.outParamGoogleMapsApiVersion = await Actions.ActionGetGoogleMapsVersion(requestContext,cancellationToken);

// GoogleMapsApiVersion = GetGoogleMapsVersion.GoogleMapsApiVersion
result.outParamGoogleMapsApiVersion=localVars.resGetGoogleMapsVersion.outParamGoogleMapsApiVersion;
} //close CreateActionActivity using block
} //try

finally {
outParamGoogleMapsApiVersion = result.outParamGoogleMapsApiVersion;
}
RETURN_STATEMENT:
return outParamGoogleMapsApiVersion;
}


    public static class FuncDataActionGetServerAPIKey {
}
public static class FuncDataActionGetApiVersion {
}


}
