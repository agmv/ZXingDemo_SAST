using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_Decode_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("BarcodeBinaryData")]
public byte[] varLcBarcodeBinaryData;
[JsonProperty("Filename")]
public string varLcFilename;
[JsonProperty("FormatHint")]
public string varLcFormatHint;
[JsonProperty("IsDecodeMulti")]
public bool? varLcIsDecodeMulti;
[JsonProperty("DecodeBarcode")]
public RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs varLcDecodeBarcode;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTZXingLibDemo_ClientVariables clientVariables = new RESTZXingLibDemo_ClientVariables();


    public static RESTZXingLibDemo_MainFlow_Decode_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_Decode_ScreenModel result = screenModel.ToObject<RESTZXingLibDemo_MainFlow_Decode_ScreenModel>(settings);
result.clientVariables = RESTZXingLibDemo_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ZXingLibDemo_MainFlow_Decode_ScreenModel ToModel() {byte[] varLcBarcodeBinaryData = variables.varLcBarcodeBinaryData == null ? new byte[] {} : variables.varLcBarcodeBinaryData;
string varLcFilename = variables.varLcFilename == null ? "" : variables.varLcFilename;
string varLcFormatHint = variables.varLcFormatHint == null ? "" : variables.varLcFormatHint;
bool varLcIsDecodeMulti = variables.varLcIsDecodeMulti == null ? false : variables.varLcIsDecodeMulti.Value;
ZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Model _varLcDecodeBarcode = (variables.varLcDecodeBarcode != null) ? RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs.ToModel(variables.varLcDecodeBarcode) : null;
ZXingLibDemo_MainFlow_Decode_ScreenModel screenModel = new ZXingLibDemo_MainFlow_Decode_ScreenModel(varLcBarcodeBinaryData, varLcFilename, varLcFormatHint, varLcIsDecodeMulti, _varLcDecodeBarcode, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
