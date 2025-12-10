using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("Email")]
public string varLcEmail;
[JsonProperty("PhoneNumber")]
public string varLcPhoneNumber;
[JsonProperty("SMS")]
public string varLcSMS;
[JsonProperty("MessageType")]
public string varLcMessageType;
[JsonProperty("MessageBarcode")]
public RESTZXingLibDemo_MainFlow_EncodeMessageVoice_DataActionMessageBarcode_Outputs varLcMessageBarcode;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTZXingLibDemo_ClientVariables clientVariables = new RESTZXingLibDemo_ClientVariables();


    public static RESTZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel result = screenModel.ToObject<RESTZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel>(settings);
result.clientVariables = RESTZXingLibDemo_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel ToModel() {string varLcEmail = variables.varLcEmail == null ? "" : variables.varLcEmail;
string varLcPhoneNumber = variables.varLcPhoneNumber == null ? "" : variables.varLcPhoneNumber;
string varLcSMS = variables.varLcSMS == null ? "" : variables.varLcSMS;
string varLcMessageType = variables.varLcMessageType == null ? "" : variables.varLcMessageType;
ZXingLibDemo_MainFlow_EncodeMessageVoice_DataActionMessageBarcode_Model _varLcMessageBarcode = (variables.varLcMessageBarcode != null) ? RESTZXingLibDemo_MainFlow_EncodeMessageVoice_DataActionMessageBarcode_Outputs.ToModel(variables.varLcMessageBarcode) : null;
ZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel screenModel = new ZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel(varLcEmail, varLcPhoneNumber, varLcSMS, varLcMessageType, _varLcMessageBarcode, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
