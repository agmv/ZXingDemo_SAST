using System.Diagnostics;

using ssOutSystemsMaps;


namespace ssOutSystemsMaps.ScreenServices;

public class OutSystemsMaps_SearchPlaces_SearchPlaces_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(OutSystemsMaps_SearchPlaces_SearchPlaces_ScreenModel).Namespace);

    public string inParamAPIKey;
public ST_7cd861eaa819851d6fba6d8150ed8cc1Structure inParamOptionalConfigs;
public string varLcUniqueId;
public bool varLcIsSecondRound;
public ST_b0933bf7957301c22e5d9229ad792ac0Structure varLcInternal_Configs;
public string varLcSearchAreaString;
public ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure varLcSearchArea;
public string varLcCountriesString;
public OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Model varLcGetApiVersion;
public OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Model varLcGetServerAPIKey;


    public OutSystemsMaps_SearchPlaces_SearchPlaces_ScreenModel() {
}



    public OutSystemsMaps_SearchPlaces_SearchPlaces_ScreenModel(string inParamAPIKey, ST_7cd861eaa819851d6fba6d8150ed8cc1Structure inParamOptionalConfigs, string varLcUniqueId, bool varLcIsSecondRound, ST_b0933bf7957301c22e5d9229ad792ac0Structure varLcInternal_Configs, string varLcSearchAreaString, ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure varLcSearchArea, string varLcCountriesString, OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetApiVersion_Model varLcGetApiVersion, OutSystemsMaps_SearchPlaces_SearchPlaces_DataActionGetServerAPIKey_Model varLcGetServerAPIKey) {
Init(new string[] {"APIKey", "OptionalConfigs", "UniqueId", "IsSecondRound", "Internal_Configs", "SearchAreaString", "SearchArea", "CountriesString", "GetApiVersion", "GetServerAPIKey"}, new string[] {"inParamAPIKey", "inParamOptionalConfigs", "varLcUniqueId", "varLcIsSecondRound", "varLcInternal_Configs", "varLcSearchAreaString", "varLcSearchArea", "varLcCountriesString", "varLcGetApiVersion", "varLcGetServerAPIKey"});
this.inParamAPIKey = inParamAPIKey;
this.inParamOptionalConfigs = inParamOptionalConfigs;
this.varLcUniqueId = varLcUniqueId;
this.varLcIsSecondRound = varLcIsSecondRound;
this.varLcInternal_Configs = varLcInternal_Configs;
this.varLcSearchAreaString = varLcSearchAreaString;
this.varLcSearchArea = varLcSearchArea;
this.varLcCountriesString = varLcCountriesString;
this.varLcGetApiVersion = varLcGetApiVersion;
this.varLcGetServerAPIKey = varLcGetServerAPIKey;
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
using (activitySource.CreateScreenDataActionActivity("SearchPlaces", "GetApiVersion")){
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
using (activitySource.CreateScreenDataActionActivity("SearchPlaces", "GetServerAPIKey")){
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


    public static class FuncDataActionGetApiVersion {
}
public static class FuncDataActionGetServerAPIKey {
}


}
