namespace ssOutSystemsMaps;

public partial class Actions {
public class lcoGetGoogleMapsServerKey : VarsBag {
public string outParamKey = "";

public lcoGetGoogleMapsServerKey() {
}
}
/// <summary>
/// Action <code>GetGoogleMapsServerKey</code> that represents the Service Studio action
///  <code>GetGoogleMapsServerKey</code> <p> Description: Returns the Google Maps API key setup for thi
/// s component.</p>
/// </summary>
public static async Task<string> ActionGetGoogleMapsServerKey(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamKey = default;
lcoGetGoogleMapsServerKey result = new lcoGetGoogleMapsServerKey();
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetGoogleMapsServerKey", "736f179d-8d72-44ae-bc0a-60b609f456ab", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa") : null){
// Key = GoogleMapsServerKey
result.outParamKey=((((string)AppUtils.SiteProperties[SitePropertiesModel.spGoogleMapsServerKey])));
} //close CreateActionActivity using block
} //try

finally {
outParamKey = result.outParamKey;
}
RETURN_STATEMENT:
return outParamKey;
}

public static class FuncActionGetGoogleMapsServerKey {



}


}
