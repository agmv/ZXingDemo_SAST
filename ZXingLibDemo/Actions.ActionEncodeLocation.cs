namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncodeLocation</code> that represents the Service Studio reference action
///  <code>EncodeLocation</code> <p> Description: Generates a barcode with the received ge
/// o location</p>
/// </summary>
public static async Task<byte[]> ActionEncodeLocation(IRequestContext requestContext,string inParamlatitude,string inParamlongitude,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
outParamBarcodeImage = await RssExternalLibraryZXingLib.MssEncodeLocation(requestContext,inParamlatitude,inParamlongitude,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
return outParamBarcodeImage;
}

}
