using System.Diagnostics;

using ssZXingLibDemo;


namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_MainFlow_EncodeContact_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ZXingLibDemo_MainFlow_EncodeContact_ScreenModel).Namespace);

    public ST_10cb4adb0f851163080c748983a654c9Structure varLcContactData;
public bool varLcIsMeCard;
public ZXingLibDemo_MainFlow_EncodeContact_DataActionContactCardBarcode_Model varLcContactCardBarcode;
public ZXingLibDemo_ClientVariables clientVariables;


    public ZXingLibDemo_MainFlow_EncodeContact_ScreenModel() {
}



    public ZXingLibDemo_MainFlow_EncodeContact_ScreenModel(ST_10cb4adb0f851163080c748983a654c9Structure varLcContactData, bool varLcIsMeCard, ZXingLibDemo_MainFlow_EncodeContact_DataActionContactCardBarcode_Model varLcContactCardBarcode, ZXingLibDemo_ClientVariables clientVariables) {
Init(new string[] {"ContactData", "IsMeCard", "ContactCardBarcode", "ClientVars"}, new string[] {"varLcContactData", "varLcIsMeCard", "varLcContactCardBarcode", "clientVariables"});
this.varLcContactData = varLcContactData;
this.varLcIsMeCard = varLcIsMeCard;
this.varLcContactCardBarcode = varLcContactCardBarcode;
this.clientVariables = clientVariables;
}



    

    public class lcvContactCardBarcode : VarsBag {
public byte[] resEncodeContact2_outParamBarcodeImage = new byte[] {};

public lcvContactCardBarcode() {
}
}
public class lcoContactCardBarcode : VarsBag {
public byte[] outParamImage = new byte[] {};

public lcoContactCardBarcode() {
}
}
/// <summary>
/// Action <code>ContactCardBarcode</code> that represents the Service Studio action
///  <code>ContactCardBarcode</code> <p> Description: Data Action that returns the QR Code.</p>
/// </summary>
public async Task<byte[]> DataActionContactCardBarcode(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamImage = default;
lcoContactCardBarcode result = new lcoContactCardBarcode();
lcvContactCardBarcode localVars = new lcvContactCardBarcode();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_EncodeContact_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("EncodeContact", "ContactCardBarcode")){
// EncodeContact2
localVars.resEncodeContact2_outParamBarcodeImage = await Actions.ActionEncodeContact(requestContext,varLcContactData,varLcIsMeCard,200,new byte[] {},"PNG",cancellationToken);

// Set Image
// Image = EncodeContact2.BarcodeImage
result.outParamImage=localVars.resEncodeContact2_outParamBarcodeImage;
} //close CreateActionActivity using block
} //try

finally {
outParamImage = result.outParamImage;
}
RETURN_STATEMENT:
return outParamImage;
}


    public static class FuncDataActionContactCardBarcode {
}


}
