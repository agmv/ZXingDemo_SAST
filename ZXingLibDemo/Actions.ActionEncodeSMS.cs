namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncodeSMS</code> that represents the Service Studio reference action
///  <code>EncodeSMS</code> <p> Description: Generates a barcode with the received SMS content</p>
/// </summary>
public static async Task<byte[]> ActionEncodeSMS(IRequestContext requestContext,string inParamphoneNumber,string inParammessage,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
outParamBarcodeImage = await RssExternalLibraryZXingLib.MssEncodeSMS(requestContext,inParamphoneNumber,inParammessage,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
return outParamBarcodeImage;
}

}
