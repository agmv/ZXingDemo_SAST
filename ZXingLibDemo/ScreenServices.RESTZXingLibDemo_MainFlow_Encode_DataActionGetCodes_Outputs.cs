using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Formats")]
public RestList<string> outParamFormats;


    public static RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs FromOutputs(IBehaviorsConfiguration conf, BasicTypeList<string> outParamFormats) {RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs result = new RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs();
result.outParamFormats = outParamFormats.ToRestList();
return result;
}


    public static ZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Model ToModel(RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs variables) {ZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Model result = new ZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Model();
result.outParamFormats = variables == null ? new BasicTypeList<string>() : BasicTypeList<string>.FromRestList(variables.outParamFormats);
return result;
}


    public static RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs FromModel(IBehaviorsConfiguration conf, ZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs result = new RESTZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Outputs();
result.outParamFormats = screenModel.outParamFormats.ToRestList();
return result;
}

}
