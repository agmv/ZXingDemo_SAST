namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncodePhoneNumber</code> that represents the Service Studio reference action
///  <code>EncodePhoneNumber</code> <p> Description: Generates a barcode with the received phon
/// e number</p>
/// </summary>
public static async Task<byte[]> ActionEncodePhoneNumber(IRequestContext requestContext,string inParamphoneNumber,bool inParamisFacetime,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
outParamBarcodeImage = await RssExternalLibraryZXingLib.MssEncodePhoneNumber(requestContext,inParamphoneNumber,inParamisFacetime,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
return outParamBarcodeImage;
}

}
