using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_Encode_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("Filename")]
public string varLcFilename;
[JsonProperty("BarcodeFormat")]
public string varLcBarcodeFormat;
[JsonProperty("Value")]
public string varLcValue;
[JsonProperty("Width")]
public int? varLcWidth;
[JsonProperty("Height")]
public int? varLcHeight;
[JsonProperty("OverlayImage")]
public byte[] varLcOverlayImage;
[JsonProperty("IsPureBarcode")]
public bool? varLcIsPureBarcode;
[JsonProperty("UseGS1Format")]
public bool? varLcUseGS1Format;
[JsonProperty("QRCodeVersion")]
public int? varLcQRCodeVersion;
[JsonProperty("Margin")]
public int? varLcMargin;
[JsonProperty("NoPadding")]
public bool? varLcNoPadding;
[JsonProperty("Encoding")]
public string varLcEncoding;
[JsonProperty("ErrorCorrection")]
public string varLcErrorCorrection;
[JsonProperty("ForceShape")]
public string varLcForceShape;
[JsonProperty("GetBarcodeDefaults")]
public RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs varLcGetBarcodeDefaults;
[JsonProperty("GetCodes")]
public RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs varLcGetCodes;
[JsonProperty("EncodeBarcodeImage")]
public RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs varLcEncodeBarcodeImage;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTZXingLibDemo_ClientVariables clientVariables = new RESTZXingLibDemo_ClientVariables();


    public static RESTZXingLibDemo_MainFlow_Encode_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_Encode_ScreenModel result = screenModel.ToObject<RESTZXingLibDemo_MainFlow_Encode_ScreenModel>(settings);
result.clientVariables = RESTZXingLibDemo_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ZXingLibDemo_MainFlow_Encode_ScreenModel ToModel() {string varLcFilename = variables.varLcFilename == null ? "" : variables.varLcFilename;
string varLcBarcodeFormat = variables.varLcBarcodeFormat == null ? "" : variables.varLcBarcodeFormat;
string varLcValue = variables.varLcValue == null ? "" : variables.varLcValue;
int varLcWidth = variables.varLcWidth == null ? 0 : variables.varLcWidth.Value;
int varLcHeight = variables.varLcHeight == null ? 0 : variables.varLcHeight.Value;
byte[] varLcOverlayImage = variables.varLcOverlayImage == null ? new byte[] {} : variables.varLcOverlayImage;
bool varLcIsPureBarcode = variables.varLcIsPureBarcode == null ? false : variables.varLcIsPureBarcode.Value;
bool varLcUseGS1Format = variables.varLcUseGS1Format == null ? false : variables.varLcUseGS1Format.Value;
int varLcQRCodeVersion = variables.varLcQRCodeVersion == null ? 0 : variables.varLcQRCodeVersion.Value;
int varLcMargin = variables.varLcMargin == null ? 0 : variables.varLcMargin.Value;
bool varLcNoPadding = variables.varLcNoPadding == null ? true : variables.varLcNoPadding.Value;
string varLcEncoding = variables.varLcEncoding == null ? "UTF-8" : variables.varLcEncoding;
string varLcErrorCorrection = variables.varLcErrorCorrection == null ? "" : variables.varLcErrorCorrection;
string varLcForceShape = variables.varLcForceShape == null ? "" : variables.varLcForceShape;
ZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Model _varLcGetBarcodeDefaults = (variables.varLcGetBarcodeDefaults != null) ? RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs.ToModel(variables.varLcGetBarcodeDefaults) : null;
ZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Model _varLcGetCodes = (variables.varLcGetCodes != null) ? RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs.ToModel(variables.varLcGetCodes) : null;
ZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Model _varLcEncodeBarcodeImage = (variables.varLcEncodeBarcodeImage != null) ? RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs.ToModel(variables.varLcEncodeBarcodeImage) : null;
ZXingLibDemo_MainFlow_Encode_ScreenModel screenModel = new ZXingLibDemo_MainFlow_Encode_ScreenModel(varLcFilename, varLcBarcodeFormat, varLcValue, varLcWidth, varLcHeight, varLcOverlayImage, varLcIsPureBarcode, varLcUseGS1Format, varLcQRCodeVersion, varLcMargin, varLcNoPadding, varLcEncoding, varLcErrorCorrection, varLcForceShape, _varLcGetBarcodeDefaults, _varLcGetCodes, _varLcEncodeBarcodeImage, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
