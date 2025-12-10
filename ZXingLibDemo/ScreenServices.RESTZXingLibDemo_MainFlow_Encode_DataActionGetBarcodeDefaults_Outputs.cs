using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Code")]
public ssZXingLibDemo.RestRecords.RESTEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord outParamCode;


    public static RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs FromOutputs(IBehaviorsConfiguration conf, EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord outParamCode) {RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs result = new RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs();
// Write the needed fields of the record outParamCode to the result.outParamCode
result.outParamCode = new ssZXingLibDemo.RestRecords.RESTEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord();
// Write optimized result.outParamCode.AttrLabel
result.outParamCode.AttrLabel = "";
result.outParamCode.AttrSample = outParamCode.ssSample;
result.outParamCode.AttrMargin = (int?) outParamCode.ssMargin;
result.outParamCode.AttrWidth = (int?) outParamCode.ssWidth;
result.outParamCode.AttrHeight = (int?) outParamCode.ssHeight;
return result;
}


    public static ZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Model ToModel(RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs variables) {ZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Model result = new ZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Model();
result.outParamCode = variables == null ? new EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord() : ssZXingLibDemo.RestRecords.RESTEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.ToStructure(variables.outParamCode);
return result;
}


    public static RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs FromModel(IBehaviorsConfiguration conf, ZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs result = new RESTZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Outputs();
result.outParamCode = ssZXingLibDemo.RestRecords.RESTEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.FromStructure(screenModel.outParamCode, conf);
return result;
}

}
