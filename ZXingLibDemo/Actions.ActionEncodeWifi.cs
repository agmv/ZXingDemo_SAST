namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncodeWifi</code> that represents the Service Studio reference action
///  <code>EncodeWifi</code> <p> Description: Generates a barcode with the Wifi connectio
/// n information</p>
/// </summary>
public static async Task<byte[]> ActionEncodeWifi(IRequestContext requestContext,ST_af04a340a4a61afef041397e6f042234Structure inParamwifi,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
outParamBarcodeImage = await RssExternalLibraryZXingLib.MssEncodeWifi(requestContext,inParamwifi,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
return outParamBarcodeImage;
}

}
