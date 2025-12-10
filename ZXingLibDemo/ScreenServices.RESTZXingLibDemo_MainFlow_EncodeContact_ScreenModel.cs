using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_EncodeContact_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("ContactData")]
public ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure varLcContactData;
[JsonProperty("IsMeCard")]
public bool? varLcIsMeCard;
[JsonProperty("ContactCardBarcode")]
public RESTZXingLibDemo_MainFlow_EncodeContact_DataActionContactCardBarcode_Outputs varLcContactCardBarcode;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTZXingLibDemo_ClientVariables clientVariables = new RESTZXingLibDemo_ClientVariables();


    public static RESTZXingLibDemo_MainFlow_EncodeContact_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_EncodeContact_ScreenModel result = screenModel.ToObject<RESTZXingLibDemo_MainFlow_EncodeContact_ScreenModel>(settings);
result.clientVariables = RESTZXingLibDemo_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ZXingLibDemo_MainFlow_EncodeContact_ScreenModel ToModel() {ST_10cb4adb0f851163080c748983a654c9Structure varLcContactData = ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure.ToStructure(variables.varLcContactData);
bool varLcIsMeCard = variables.varLcIsMeCard == null ? false : variables.varLcIsMeCard.Value;
ZXingLibDemo_MainFlow_EncodeContact_DataActionContactCardBarcode_Model _varLcContactCardBarcode = (variables.varLcContactCardBarcode != null) ? RESTZXingLibDemo_MainFlow_EncodeContact_DataActionContactCardBarcode_Outputs.ToModel(variables.varLcContactCardBarcode) : null;
ZXingLibDemo_MainFlow_EncodeContact_ScreenModel screenModel = new ZXingLibDemo_MainFlow_EncodeContact_ScreenModel(varLcContactData, varLcIsMeCard, _varLcContactCardBarcode, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
