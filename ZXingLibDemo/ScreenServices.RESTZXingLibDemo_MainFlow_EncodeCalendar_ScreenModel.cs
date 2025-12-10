using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("CalendarEventData")]
public ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure varLcCalendarEventData;
[JsonProperty("CalendarEventBarcode")]
public RESTZXingLibDemo_MainFlow_EncodeCalendar_DataActionCalendarEventBarcode_Outputs varLcCalendarEventBarcode;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTZXingLibDemo_ClientVariables clientVariables = new RESTZXingLibDemo_ClientVariables();


    public static RESTZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel result = screenModel.ToObject<RESTZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel>(settings);
result.clientVariables = RESTZXingLibDemo_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel ToModel() {ST_8738e857d4fb6695d1e17d4c03428ee2Structure varLcCalendarEventData = ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure.ToStructure(variables.varLcCalendarEventData);
ZXingLibDemo_MainFlow_EncodeCalendar_DataActionCalendarEventBarcode_Model _varLcCalendarEventBarcode = (variables.varLcCalendarEventBarcode != null) ? RESTZXingLibDemo_MainFlow_EncodeCalendar_DataActionCalendarEventBarcode_Outputs.ToModel(variables.varLcCalendarEventBarcode) : null;
ZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel screenModel = new ZXingLibDemo_MainFlow_EncodeCalendar_ScreenModel(varLcCalendarEventData, _varLcCalendarEventBarcode, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
