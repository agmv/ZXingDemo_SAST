using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_ClientVariables : ScreenServicesApiController.Payload.IDataPayload {
	[JsonProperty("IsLoading")]
public bool? ssIsLoading;
[JsonProperty("UserPhotoURL")]
public string ssUserPhotoURL;
[JsonProperty("LastURL")]
public string ssLastURL;
[JsonProperty("UserName")]
public string ssUserName;


    public static RESTZXingLibDemo_ClientVariables FromJSON(JObject clientVars, JsonSerializer settings) {if((clientVars == null)) {
return null;
}

RESTZXingLibDemo_ClientVariables result = clientVars.ToObject<RESTZXingLibDemo_ClientVariables>(settings);
return result;
}


    public ZXingLibDemo_ClientVariables ToModel() {bool ssIsLoading = this.ssIsLoading == null ? false : this.ssIsLoading.Value;
string ssUserPhotoURL = this.ssUserPhotoURL == null ? "" : this.ssUserPhotoURL;
string ssLastURL = this.ssLastURL == null ? "" : this.ssLastURL;
string ssUserName = this.ssUserName == null ? "" : this.ssUserName;
ZXingLibDemo_ClientVariables clientVariablesModel = new ZXingLibDemo_ClientVariables(ssIsLoading, ssUserPhotoURL, ssLastURL, ssUserName);
return clientVariablesModel;
}

}
