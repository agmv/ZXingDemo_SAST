namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncodeEmail</code> that represents the Service Studio reference action
///  <code>EncodeEmail</code> <p> Description: Generates a barcode with the received email address</p>
/// </summary>
public static async Task<byte[]> ActionEncodeEmail(IRequestContext requestContext,string inParamemail,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
outParamBarcodeImage = await RssExternalLibraryZXingLib.MssEncodeEmail(requestContext,inParamemail,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
return outParamBarcodeImage;
}

}
