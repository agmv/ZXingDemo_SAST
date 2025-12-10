using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_EncodeWifi_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("WifiData")]
public ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure varLcWifiData;
[JsonProperty("WifiCardBarcode")]
public RESTZXingLibDemo_MainFlow_EncodeWifi_DataActionWifiCardBarcode_Outputs varLcWifiCardBarcode;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTZXingLibDemo_ClientVariables clientVariables = new RESTZXingLibDemo_ClientVariables();


    public static RESTZXingLibDemo_MainFlow_EncodeWifi_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_EncodeWifi_ScreenModel result = screenModel.ToObject<RESTZXingLibDemo_MainFlow_EncodeWifi_ScreenModel>(settings);
result.clientVariables = RESTZXingLibDemo_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ZXingLibDemo_MainFlow_EncodeWifi_ScreenModel ToModel() {ST_af04a340a4a61afef041397e6f042234Structure varLcWifiData = ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure.ToStructure(variables.varLcWifiData);
ZXingLibDemo_MainFlow_EncodeWifi_DataActionWifiCardBarcode_Model _varLcWifiCardBarcode = (variables.varLcWifiCardBarcode != null) ? RESTZXingLibDemo_MainFlow_EncodeWifi_DataActionWifiCardBarcode_Outputs.ToModel(variables.varLcWifiCardBarcode) : null;
ZXingLibDemo_MainFlow_EncodeWifi_ScreenModel screenModel = new ZXingLibDemo_MainFlow_EncodeWifi_ScreenModel(varLcWifiData, _varLcWifiCardBarcode, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
