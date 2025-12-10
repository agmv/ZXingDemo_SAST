using System.Diagnostics;

using ssZXingLibDemo;


namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_MainFlow_EncodeWifi_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ZXingLibDemo_MainFlow_EncodeWifi_ScreenModel).Namespace);

    public ST_af04a340a4a61afef041397e6f042234Structure varLcWifiData;
public ZXingLibDemo_MainFlow_EncodeWifi_DataActionWifiCardBarcode_Model varLcWifiCardBarcode;
public ZXingLibDemo_ClientVariables clientVariables;


    public ZXingLibDemo_MainFlow_EncodeWifi_ScreenModel() {
}



    public ZXingLibDemo_MainFlow_EncodeWifi_ScreenModel(ST_af04a340a4a61afef041397e6f042234Structure varLcWifiData, ZXingLibDemo_MainFlow_EncodeWifi_DataActionWifiCardBarcode_Model varLcWifiCardBarcode, ZXingLibDemo_ClientVariables clientVariables) {
Init(new string[] {"WifiData", "WifiCardBarcode", "ClientVars"}, new string[] {"varLcWifiData", "varLcWifiCardBarcode", "clientVariables"});
this.varLcWifiData = varLcWifiData;
this.varLcWifiCardBarcode = varLcWifiCardBarcode;
this.clientVariables = clientVariables;
}



    

    public class lcvWifiCardBarcode : VarsBag {
public byte[] resEncodeWifi2_outParamBarcodeImage = new byte[] {};

public lcvWifiCardBarcode() {
}
}
public class lcoWifiCardBarcode : VarsBag {
public byte[] outParamImage = new byte[] {};

public lcoWifiCardBarcode() {
}
}
/// <summary>
/// Action <code>WifiCardBarcode</code> that represents the Service Studio action
///  <code>WifiCardBarcode</code> <p> Description: Data action to return a QR Code containin
/// g information about a specific wifi network.</p>
/// </summary>
public async Task<byte[]> DataActionWifiCardBarcode(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamImage = default;
lcoWifiCardBarcode result = new lcoWifiCardBarcode();
lcvWifiCardBarcode localVars = new lcvWifiCardBarcode();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_EncodeWifi_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("EncodeWifi", "WifiCardBarcode")){
// EncodeWifi2
localVars.resEncodeWifi2_outParamBarcodeImage = await Actions.ActionEncodeWifi(requestContext,varLcWifiData,200,new byte[] {},"PNG",cancellationToken);

// Set Image
// Image = EncodeWifi2.BarcodeImage
result.outParamImage=localVars.resEncodeWifi2_outParamBarcodeImage;
} //close CreateActionActivity using block
} //try

finally {
outParamImage = result.outParamImage;
}
RETURN_STATEMENT:
return outParamImage;
}


    public static class FuncDataActionWifiCardBarcode {
}


}
