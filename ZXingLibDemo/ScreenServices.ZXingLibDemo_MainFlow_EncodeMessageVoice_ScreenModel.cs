using System.Diagnostics;

using ssZXingLibDemo;


namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel).Namespace);

    public string varLcEmail;
public string varLcPhoneNumber;
public string varLcSMS;
public string varLcMessageType;
public ZXingLibDemo_MainFlow_EncodeMessageVoice_DataActionMessageBarcode_Model varLcMessageBarcode;
public ZXingLibDemo_ClientVariables clientVariables;


    public ZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel() {
}



    public ZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel(string varLcEmail, string varLcPhoneNumber, string varLcSMS, string varLcMessageType, ZXingLibDemo_MainFlow_EncodeMessageVoice_DataActionMessageBarcode_Model varLcMessageBarcode, ZXingLibDemo_ClientVariables clientVariables) {
Init(new string[] {"Email", "PhoneNumber", "SMS", "MessageType", "MessageBarcode", "ClientVars"}, new string[] {"varLcEmail", "varLcPhoneNumber", "varLcSMS", "varLcMessageType", "varLcMessageBarcode", "clientVariables"});
this.varLcEmail = varLcEmail;
this.varLcPhoneNumber = varLcPhoneNumber;
this.varLcSMS = varLcSMS;
this.varLcMessageType = varLcMessageType;
this.varLcMessageBarcode = varLcMessageBarcode;
this.clientVariables = clientVariables;
}



    

    public class lcvMessageBarcode : VarsBag {
public byte[] resEncodePhoneNumber2_outParamBarcodeImage = new byte[] {};

public byte[] resEncodeEmail_outParamBarcodeImage = new byte[] {};

public byte[] resEncodePhoneNumber_outParamBarcodeImage = new byte[] {};

public byte[] resEncodeSMS_outParamBarcodeImage = new byte[] {};

public lcvMessageBarcode() {
}
}
public class lcoMessageBarcode : VarsBag {
public byte[] outParamImage = new byte[] {};

public lcoMessageBarcode() {
}
}
/// <summary>
/// Action <code>MessageBarcode</code> that represents the Service Studio action
///  <code>MessageBarcode</code> <p> Description: Data Action to return a QR Code contaning som
/// e specific information (Either an Email, a phone number or a text message associated with a
///  number).</p>
/// </summary>
public async Task<byte[]> DataActionMessageBarcode(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamImage = default;
lcoMessageBarcode result = new lcoMessageBarcode();
lcvMessageBarcode localVars = new lcvMessageBarcode();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_EncodeMessageVoice_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("EncodeMessageVoice", "MessageBarcode")){
if(((varLcMessageType=="email"))) {
// EncodeEmail
localVars.resEncodeEmail_outParamBarcodeImage = await Actions.ActionEncodeEmail(requestContext,varLcEmail,200,new byte[] {},"PNG",cancellationToken);

// Set Image
// Image = EncodeEmail.BarcodeImage
result.outParamImage=localVars.resEncodeEmail_outParamBarcodeImage;
} else {
if((varLcMessageType=="call")) {
// EncodePhoneNumber
localVars.resEncodePhoneNumber_outParamBarcodeImage = await Actions.ActionEncodePhoneNumber(requestContext,varLcPhoneNumber,false,200,new byte[] {},"PNG",cancellationToken);

// Set Image
// Image = EncodePhoneNumber.BarcodeImage
result.outParamImage=localVars.resEncodePhoneNumber_outParamBarcodeImage;
} else {
if((varLcMessageType=="sms")) {
// EncodeSMS
localVars.resEncodeSMS_outParamBarcodeImage = await Actions.ActionEncodeSMS(requestContext,varLcPhoneNumber,varLcSMS,200,new byte[] {},"PNG",cancellationToken);

// Set Image
// Image = EncodeSMS.BarcodeImage
result.outParamImage=localVars.resEncodeSMS_outParamBarcodeImage;
} else {
if((varLcMessageType=="facetime")) {
// EncodePhoneNumber2
localVars.resEncodePhoneNumber2_outParamBarcodeImage = await Actions.ActionEncodePhoneNumber(requestContext,varLcPhoneNumber,true,200,new byte[] {},"PNG",cancellationToken);

// Set Image
// Image = EncodePhoneNumber2.BarcodeImage
result.outParamImage=localVars.resEncodePhoneNumber2_outParamBarcodeImage;
}

}

}

}

} //close CreateActionActivity using block
} //try

finally {
outParamImage = result.outParamImage;
}
RETURN_STATEMENT:
return outParamImage;
}


    public static class FuncDataActionMessageBarcode {
}


}
