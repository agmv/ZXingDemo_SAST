using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Barcodes")]
public RestList<ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure> outParamBarcodes;


    public static RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_8fdc1c2bcc6f385410bdb8a93bd26489 outParamBarcodes) {RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs result = new RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs();
// Write the needed fields of the list outParamBarcodes to the result.outParamBarcodes
ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure tmpoutParamBarcodesElement;
if(outParamBarcodes.Empty) {
// Write the needed fields of the record outParamBarcodes.CurrentRec to the tmpoutParamBarcodesElement
tmpoutParamBarcodesElement = new ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure();
tmpoutParamBarcodesElement.Attrvalue = outParamBarcodes.CurrentRec.ssvalue;
tmpoutParamBarcodesElement.AttrrawBytes = outParamBarcodes.CurrentRec.ssrawBytes;
tmpoutParamBarcodesElement.Attrformat = outParamBarcodes.CurrentRec.ssformat;
// Write the needed fields of the list outParamBarcodes.CurrentRec.ssmetadata to the tmpoutParamBarcodesElement.Attrmetadata
ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure tmpoutParamBarcodes_CurrentRec_ssmetadataElement;
if(outParamBarcodes.CurrentRec.ssmetadata.Empty) {
// Write the needed fields of the record outParamBarcodes.CurrentRec.ssmetadata.CurrentRec to the tmpoutParamBarcodes_CurrentRec_ssmetadataElement
tmpoutParamBarcodes_CurrentRec_ssmetadataElement = new ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
tmpoutParamBarcodes_CurrentRec_ssmetadataElement.Attrkey = outParamBarcodes.CurrentRec.ssmetadata.CurrentRec.sskey;
tmpoutParamBarcodes_CurrentRec_ssmetadataElement.Attrvalue = outParamBarcodes.CurrentRec.ssmetadata.CurrentRec.ssvalue;
tmpoutParamBarcodesElement.Attrmetadata = new RestList<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>(new ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure[] {}, tmpoutParamBarcodes_CurrentRec_ssmetadataElement);
} else {
List<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>
 tmpoutParamBarcodes_CurrentRec_ssmetadata1List = new List<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>
();
try {outParamBarcodes.CurrentRec.ssmetadata.StartIteration();
while (!(outParamBarcodes.CurrentRec.ssmetadata.Eof)) {
// Write the needed fields of the record outParamBarcodes.CurrentRec.ssmetadata.CurrentRec to the tmpoutParamBarcodes_CurrentRec_ssmetadataElement
tmpoutParamBarcodes_CurrentRec_ssmetadataElement = new ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
tmpoutParamBarcodes_CurrentRec_ssmetadataElement.Attrkey = outParamBarcodes.CurrentRec.ssmetadata.CurrentRec.sskey;
tmpoutParamBarcodes_CurrentRec_ssmetadataElement.Attrvalue = outParamBarcodes.CurrentRec.ssmetadata.CurrentRec.ssvalue;
tmpoutParamBarcodes_CurrentRec_ssmetadata1List.Add(tmpoutParamBarcodes_CurrentRec_ssmetadataElement);
outParamBarcodes.CurrentRec.ssmetadata.Advance();
}

} finally {
outParamBarcodes.CurrentRec.ssmetadata.EndIteration();
}

tmpoutParamBarcodesElement.Attrmetadata = new RestList<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>(tmpoutParamBarcodes_CurrentRec_ssmetadata1List.ToArray(), default(ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure));
}

tmpoutParamBarcodesElement.AttrdetectedBarcode = outParamBarcodes.CurrentRec.ssdetectedBarcode;
result.outParamBarcodes = new RestList<ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure>(new ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure[] {}, tmpoutParamBarcodesElement);
} else {
List<ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure>
 tmpoutParamBarcodes1List = new List<ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure>
();
try {outParamBarcodes.StartIteration();
while (!(outParamBarcodes.Eof)) {
// Write the needed fields of the record outParamBarcodes.CurrentRec to the tmpoutParamBarcodesElement
tmpoutParamBarcodesElement = new ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure();
tmpoutParamBarcodesElement.Attrvalue = outParamBarcodes.CurrentRec.ssvalue;
tmpoutParamBarcodesElement.AttrrawBytes = outParamBarcodes.CurrentRec.ssrawBytes;
tmpoutParamBarcodesElement.Attrformat = outParamBarcodes.CurrentRec.ssformat;
// Write the needed fields of the list outParamBarcodes.CurrentRec.ssmetadata to the tmpoutParamBarcodesElement.Attrmetadata
ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure tmpoutParamBarcodes_CurrentRec_ssmetadataElement;
if(outParamBarcodes.CurrentRec.ssmetadata.Empty) {
// Write the needed fields of the record outParamBarcodes.CurrentRec.ssmetadata.CurrentRec to the tmpoutParamBarcodes_CurrentRec_ssmetadataElement
tmpoutParamBarcodes_CurrentRec_ssmetadataElement = new ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
tmpoutParamBarcodes_CurrentRec_ssmetadataElement.Attrkey = outParamBarcodes.CurrentRec.ssmetadata.CurrentRec.sskey;
tmpoutParamBarcodes_CurrentRec_ssmetadataElement.Attrvalue = outParamBarcodes.CurrentRec.ssmetadata.CurrentRec.ssvalue;
tmpoutParamBarcodesElement.Attrmetadata = new RestList<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>(new ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure[] {}, tmpoutParamBarcodes_CurrentRec_ssmetadataElement);
} else {
List<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>
 tmpoutParamBarcodes_CurrentRec_ssmetadata1List = new List<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>
();
try {outParamBarcodes.CurrentRec.ssmetadata.StartIteration();
while (!(outParamBarcodes.CurrentRec.ssmetadata.Eof)) {
// Write the needed fields of the record outParamBarcodes.CurrentRec.ssmetadata.CurrentRec to the tmpoutParamBarcodes_CurrentRec_ssmetadataElement
tmpoutParamBarcodes_CurrentRec_ssmetadataElement = new ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
tmpoutParamBarcodes_CurrentRec_ssmetadataElement.Attrkey = outParamBarcodes.CurrentRec.ssmetadata.CurrentRec.sskey;
tmpoutParamBarcodes_CurrentRec_ssmetadataElement.Attrvalue = outParamBarcodes.CurrentRec.ssmetadata.CurrentRec.ssvalue;
tmpoutParamBarcodes_CurrentRec_ssmetadata1List.Add(tmpoutParamBarcodes_CurrentRec_ssmetadataElement);
outParamBarcodes.CurrentRec.ssmetadata.Advance();
}

} finally {
outParamBarcodes.CurrentRec.ssmetadata.EndIteration();
}

tmpoutParamBarcodesElement.Attrmetadata = new RestList<ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure>(tmpoutParamBarcodes_CurrentRec_ssmetadata1List.ToArray(), default(ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure));
}

tmpoutParamBarcodesElement.AttrdetectedBarcode = outParamBarcodes.CurrentRec.ssdetectedBarcode;
tmpoutParamBarcodes1List.Add(tmpoutParamBarcodesElement);
outParamBarcodes.Advance();
}

} finally {
outParamBarcodes.EndIteration();
}

result.outParamBarcodes = new RestList<ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure>(tmpoutParamBarcodes1List.ToArray(), default(ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure));
}

return result;
}


    public static ZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Model ToModel(RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs variables) {ZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Model result = new ZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Model();
result.outParamBarcodes = variables == null ? new RL_8fdc1c2bcc6f385410bdb8a93bd26489() : RL_8fdc1c2bcc6f385410bdb8a93bd26489.FromRestList(variables.outParamBarcodes, ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure.ToStructure);
return result;
}


    public static RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs FromModel(IBehaviorsConfiguration conf, ZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs result = new RESTZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Outputs();
result.outParamBarcodes = screenModel.outParamBarcodes.ToRestList<ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure>(ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure.FromStructureDelegate(conf));
return result;
}

}
