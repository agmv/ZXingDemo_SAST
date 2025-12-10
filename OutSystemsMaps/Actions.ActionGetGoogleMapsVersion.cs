namespace ssOutSystemsMaps;

public partial class Actions {
public class lcoGetGoogleMapsVersion : VarsBag {
public string outParamGoogleMapsApiVersion = "";

public lcoGetGoogleMapsVersion() {
}
}
/// <summary>
/// Action <code>GetGoogleMapsVersion</code> that represents the Service Studio action
///  <code>GetGoogleMapsVersion</code> <p> Description: Returns the Google Maps API version, as define
/// d in the site property GoogleMapsVersion.</p>
/// </summary>
public static async Task<string> ActionGetGoogleMapsVersion(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamGoogleMapsApiVersion = default;
lcoGetGoogleMapsVersion result = new lcoGetGoogleMapsVersion();
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetGoogleMapsVersion", "ab01500c-9f0c-4f3f-b5c6-302fd2a3f37b", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa") : null){
// GoogleMapsApiVersion = GoogleMapsVersion
result.outParamGoogleMapsApiVersion=((((string)AppUtils.SiteProperties[SitePropertiesModel.spGoogleMapsVersion])));
} //close CreateActionActivity using block
} //try

finally {
outParamGoogleMapsApiVersion = result.outParamGoogleMapsApiVersion;
}
RETURN_STATEMENT:
return outParamGoogleMapsApiVersion;
}

public static class FuncActionGetGoogleMapsVersion {



}


}
