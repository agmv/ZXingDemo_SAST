namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncodeCalendarEvent</code> that represents the Service Studio reference action
///  <code>EncodeCalendarEvent</code> <p> Description: Generates a barcode with the received calenda
/// r event data</p>
/// </summary>
public static async Task<byte[]> ActionEncodeCalendarEvent(IRequestContext requestContext,ST_8738e857d4fb6695d1e17d4c03428ee2Structure inParamcalendarEvent,int inParamsize,byte[] inParamoverlayImage,string inParamoutputFormat,CancellationToken cancellationToken) {
byte[] outParamBarcodeImage = default;
outParamBarcodeImage = await RssExternalLibraryZXingLib.MssEncodeCalendarEvent(requestContext,inParamcalendarEvent,inParamsize,inParamoverlayImage,inParamoutputFormat,cancellationToken);
return outParamBarcodeImage;
}

}
