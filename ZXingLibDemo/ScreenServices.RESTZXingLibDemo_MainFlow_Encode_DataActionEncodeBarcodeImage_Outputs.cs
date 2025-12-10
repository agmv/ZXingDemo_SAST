using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Image")]
public byte[] outParamImage;


    public static RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamImage) {RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs result = new RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs();
result.outParamImage = outParamImage;
return result;
}


    public static ZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Model ToModel(RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs variables) {ZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Model result = new ZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Model();
result.outParamImage = variables == null || variables.outParamImage == null ? new byte[] {} : variables.outParamImage;
return result;
}


    public static RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs FromModel(IBehaviorsConfiguration conf, ZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs result = new RESTZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Outputs();
result.outParamImage = screenModel.outParamImage;
return result;
}

}
