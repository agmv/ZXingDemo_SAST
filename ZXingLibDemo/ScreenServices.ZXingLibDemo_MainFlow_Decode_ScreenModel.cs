using System.Diagnostics;

using ssZXingLibDemo;


namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_MainFlow_Decode_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ZXingLibDemo_MainFlow_Decode_ScreenModel).Namespace);

    public byte[] varLcBarcodeBinaryData;
public string varLcFilename;
public string varLcFormatHint;
public bool varLcIsDecodeMulti;
public ZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Model varLcDecodeBarcode;
public ZXingLibDemo_ClientVariables clientVariables;


    public ZXingLibDemo_MainFlow_Decode_ScreenModel() {
}



    public ZXingLibDemo_MainFlow_Decode_ScreenModel(byte[] varLcBarcodeBinaryData, string varLcFilename, string varLcFormatHint, bool varLcIsDecodeMulti, ZXingLibDemo_MainFlow_Decode_DataActionDecodeBarcode_Model varLcDecodeBarcode, ZXingLibDemo_ClientVariables clientVariables) {
Init(new string[] {"BarcodeBinaryData", "Filename", "FormatHint", "IsDecodeMulti", "DecodeBarcode", "ClientVars"}, new string[] {"varLcBarcodeBinaryData", "varLcFilename", "varLcFormatHint", "varLcIsDecodeMulti", "varLcDecodeBarcode", "clientVariables"});
this.varLcBarcodeBinaryData = varLcBarcodeBinaryData;
this.varLcFilename = varLcFilename;
this.varLcFormatHint = varLcFormatHint;
this.varLcIsDecodeMulti = varLcIsDecodeMulti;
this.varLcDecodeBarcode = varLcDecodeBarcode;
this.clientVariables = clientVariables;
}



    

    public class lcvDecodeBarcode : VarsBag {
public ST_7750e71a4e018dabac19d9f560c2b017Structure resDecode2_outParamBarcode = new ST_7750e71a4e018dabac19d9f560c2b017Structure();

public RL_8fdc1c2bcc6f385410bdb8a93bd26489 resDecodeMulti_outParamBarcodes = new RL_8fdc1c2bcc6f385410bdb8a93bd26489();

public lcvDecodeBarcode() {
}
}
public class lcoDecodeBarcode : VarsBag {
public RL_8fdc1c2bcc6f385410bdb8a93bd26489 outParamBarcodes = new RL_8fdc1c2bcc6f385410bdb8a93bd26489();

public lcoDecodeBarcode() {
}
}
/// <summary>
/// Action <code>DecodeBarcode</code> that represents the Service Studio action
///  <code>DecodeBarcode</code> <p> Description: Data Action that returns the content of the Q
/// R Code.</p>
/// </summary>
public async Task<RL_8fdc1c2bcc6f385410bdb8a93bd26489> DataActionDecodeBarcode(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_8fdc1c2bcc6f385410bdb8a93bd26489 outParamBarcodes = default;
lcoDecodeBarcode result = new lcoDecodeBarcode();
lcvDecodeBarcode localVars = new lcvDecodeBarcode();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_Decode_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("Decode", "DecodeBarcode")){
// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamBarcodes,cancellationToken);

// Check if IsDecodeMulti
if(((varLcIsDecodeMulti==true))) {
// DecodeMulti
localVars.resDecodeMulti_outParamBarcodes = await Actions.ActionDecodeMulti(requestContext,varLcBarcodeBinaryData,varLcFormatHint,true,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamBarcodes,localVars.resDecodeMulti_outParamBarcodes,cancellationToken);

} else {
// Decode2
localVars.resDecode2_outParamBarcode = await Actions.ActionDecode(requestContext,varLcBarcodeBinaryData,varLcFormatHint,true,cancellationToken);

if(((localVars.resDecode2_outParamBarcode.ssformat!=""))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamBarcodes,localVars.resDecode2_outParamBarcode,cancellationToken);

}

}

} //close CreateActionActivity using block
} //try

finally {
outParamBarcodes = result.outParamBarcodes;
}
RETURN_STATEMENT:
return outParamBarcodes;
}


    public static class FuncDataActionDecodeBarcode {
}


}
