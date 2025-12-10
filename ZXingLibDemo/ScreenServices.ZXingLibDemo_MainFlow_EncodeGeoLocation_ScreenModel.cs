using System.Diagnostics;

using ssZXingLibDemo;


namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel).Namespace);

    public string varLcLatitude;
public string varLcLongitude;
public ZXingLibDemo_MainFlow_EncodeGeoLocation_DataActionGeolocationBarcode_Model varLcGeolocationBarcode;
public ZXingLibDemo_ClientVariables clientVariables;


    public ZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel() {
}



    public ZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel(string varLcLatitude, string varLcLongitude, ZXingLibDemo_MainFlow_EncodeGeoLocation_DataActionGeolocationBarcode_Model varLcGeolocationBarcode, ZXingLibDemo_ClientVariables clientVariables) {
Init(new string[] {"Latitude", "Longitude", "GeolocationBarcode", "ClientVars"}, new string[] {"varLcLatitude", "varLcLongitude", "varLcGeolocationBarcode", "clientVariables"});
this.varLcLatitude = varLcLatitude;
this.varLcLongitude = varLcLongitude;
this.varLcGeolocationBarcode = varLcGeolocationBarcode;
this.clientVariables = clientVariables;
}



    

    public class lcvGeolocationBarcode : VarsBag {
public byte[] resEncodeLocation_outParamBarcodeImage = new byte[] {};

public lcvGeolocationBarcode() {
}
}
public class lcoGeolocationBarcode : VarsBag {
public byte[] outParamImage = new byte[] {};

public lcoGeolocationBarcode() {
}
}
/// <summary>
/// Action <code>GeolocationBarcode</code> that represents the Service Studio action
///  <code>GeolocationBarcode</code> <p> Description: Data Action that returns the QR Code containg 
/// a geographic location.</p>
/// </summary>
public async Task<byte[]> DataActionGeolocationBarcode(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamImage = default;
lcoGeolocationBarcode result = new lcoGeolocationBarcode();
lcvGeolocationBarcode localVars = new lcvGeolocationBarcode();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_EncodeGeoLocation_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("EncodeGeoLocation", "GeolocationBarcode")){
// EncodeLocation
localVars.resEncodeLocation_outParamBarcodeImage = await Actions.ActionEncodeLocation(requestContext,varLcLatitude,varLcLongitude,200,new byte[] {},"PNG",cancellationToken);

// Set Image
// Image = EncodeLocation.BarcodeImage
result.outParamImage=localVars.resEncodeLocation_outParamBarcodeImage;
} //close CreateActionActivity using block
} //try

finally {
outParamImage = result.outParamImage;
}
RETURN_STATEMENT:
return outParamImage;
}


    public static class FuncDataActionGeolocationBarcode {
}


}
