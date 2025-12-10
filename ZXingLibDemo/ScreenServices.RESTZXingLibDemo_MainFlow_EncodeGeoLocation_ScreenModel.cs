using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("Latitude")]
public string varLcLatitude;
[JsonProperty("Longitude")]
public string varLcLongitude;
[JsonProperty("GeolocationBarcode")]
public RESTZXingLibDemo_MainFlow_EncodeGeoLocation_DataActionGeolocationBarcode_Outputs varLcGeolocationBarcode;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTZXingLibDemo_ClientVariables clientVariables = new RESTZXingLibDemo_ClientVariables();


    public static RESTZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel result = screenModel.ToObject<RESTZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel>(settings);
result.clientVariables = RESTZXingLibDemo_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel ToModel() {string varLcLatitude = variables.varLcLatitude == null ? "" : variables.varLcLatitude;
string varLcLongitude = variables.varLcLongitude == null ? "" : variables.varLcLongitude;
ZXingLibDemo_MainFlow_EncodeGeoLocation_DataActionGeolocationBarcode_Model _varLcGeolocationBarcode = (variables.varLcGeolocationBarcode != null) ? RESTZXingLibDemo_MainFlow_EncodeGeoLocation_DataActionGeolocationBarcode_Outputs.ToModel(variables.varLcGeolocationBarcode) : null;
ZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel screenModel = new ZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel(varLcLatitude, varLcLongitude, _varLcGeolocationBarcode, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
