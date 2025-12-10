namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncode</code> that represents the Service Studio reference action
///  <code>Encode</code> <p> Description: Generates a barcode with the received input data</p>
/// </summary>
public static async Task<byte[]> ActionEncode(IRequestContext requestContext,string inParamcontents,string inParamformat,int inParamwidth,int inParamheight,int inParammargin,bool inParampureBarcode,bool inParamgS1Format,bool inParamnoPadding,string inParamencoding,string inParamecl,int inParamqRCodeVersion,byte[] inParamoverlayImage,string inParamforceShape,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
outParamBarcodeImage = await RssExternalLibraryZXingLib.MssEncode(requestContext,inParamcontents,inParamformat,inParamwidth,inParamheight,inParammargin,inParampureBarcode,inParamgS1Format,inParamnoPadding,inParamencoding,inParamecl,inParamqRCodeVersion,inParamoverlayImage,inParamforceShape,inParamoutputFormat,cancellationToken);
return outParamBarcodeImage;
}

}
