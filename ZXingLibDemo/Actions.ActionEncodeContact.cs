namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncodeContact</code> that represents the Service Studio reference action
///  <code>EncodeContact</code> <p> Description: Generates a barcode with the received contact data</p>
/// </summary>
public static async Task<byte[]> ActionEncodeContact(IRequestContext requestContext,ST_10cb4adb0f851163080c748983a654c9Structure inParamcontact,bool inParamisMeCard,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
outParamBarcodeImage = await RssExternalLibraryZXingLib.MssEncodeContact(requestContext,inParamcontact,inParamisMeCard,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
return outParamBarcodeImage;
}

}
