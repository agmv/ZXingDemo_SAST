using System.Diagnostics;

using ssZXingLibDemo;


namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel).Namespace);

    public ST_8738e857d4fb6695d1e17d4c03428ee2Structure varLcCalendarEventData;
public ZXingLibDemo_MainFlow_EncodeCalendar_DataActionCalendarEventBarcode_Model varLcCalendarEventBarcode;
public ZXingLibDemo_ClientVariables clientVariables;


    public ZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel() {
}



    public ZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel(ST_8738e857d4fb6695d1e17d4c03428ee2Structure varLcCalendarEventData, ZXingLibDemo_MainFlow_EncodeCalendar_DataActionCalendarEventBarcode_Model varLcCalendarEventBarcode, ZXingLibDemo_ClientVariables clientVariables) {
Init(new string[] {"CalendarEventData", "CalendarEventBarcode", "ClientVars"}, new string[] {"varLcCalendarEventData", "varLcCalendarEventBarcode", "clientVariables"});
this.varLcCalendarEventData = varLcCalendarEventData;
this.varLcCalendarEventBarcode = varLcCalendarEventBarcode;
this.clientVariables = clientVariables;
}



    

    public class lcvCalendarEventBarcode : VarsBag {
public byte[] resEncodeCalendarEvent_outParamBarcodeImage = new byte[] {};

public lcvCalendarEventBarcode() {
}
}
public class lcoCalendarEventBarcode : VarsBag {
public byte[] outParamImage = new byte[] {};

public lcoCalendarEventBarcode() {
}
}
/// <summary>
/// Action <code>CalendarEventBarcode</code> that represents the Service Studio action
///  <code>CalendarEventBarcode</code> <p> Description: Data Action that returns the QR Code.</p>
/// </summary>
public async Task<byte[]> DataActionCalendarEventBarcode(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamImage = default;
lcoCalendarEventBarcode result = new lcoCalendarEventBarcode();
lcvCalendarEventBarcode localVars = new lcvCalendarEventBarcode();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("EncodeCalendar", "CalendarEventBarcode")){
// EncodeCalendarEvent
localVars.resEncodeCalendarEvent_outParamBarcodeImage = await Actions.ActionEncodeCalendarEvent(requestContext,varLcCalendarEventData,200,new byte[] {},"PNG",cancellationToken);

// Set Image
// Image = EncodeCalendarEvent.BarcodeImage
result.outParamImage=localVars.resEncodeCalendarEvent_outParamBarcodeImage;
} //close CreateActionActivity using block
} //try

finally {
outParamImage = result.outParamImage;
}
RETURN_STATEMENT:
return outParamImage;
}


    public static class FuncDataActionCalendarEventBarcode {
}


}
