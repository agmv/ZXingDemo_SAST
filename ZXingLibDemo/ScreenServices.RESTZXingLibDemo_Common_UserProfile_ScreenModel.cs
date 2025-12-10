using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssZXingLibDemo.ScreenServices;

public class RESTZXingLibDemo_Common_UserProfile_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserById")]
public RESTAggregateRecord<ssZXingLibDemo.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79> ScreenDataSetGetUserById;
[JsonProperty("IsButtonEnabled")]
public bool? varLcIsButtonEnabled;
[JsonProperty("IsExternal")]
public bool? varLcIsExternal;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTZXingLibDemo_ClientVariables clientVariables = new RESTZXingLibDemo_ClientVariables();


    public static RESTZXingLibDemo_Common_UserProfile_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTZXingLibDemo_Common_UserProfile_ScreenModel result = screenModel.ToObject<RESTZXingLibDemo_Common_UserProfile_ScreenModel>(settings);
result.clientVariables = RESTZXingLibDemo_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ZXingLibDemo_Common_UserProfile_ScreenModel ToModel() {bool varLcIsButtonEnabled = variables.varLcIsButtonEnabled == null ? false : variables.varLcIsButtonEnabled.Value;
bool varLcIsExternal = variables.varLcIsExternal == null ? false : variables.varLcIsExternal.Value;
AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> _ScreenDataSetGetUserById = (variables.ScreenDataSetGetUserById != null) ? variables.ScreenDataSetGetUserById.FromJS((array) => {
return RL_8430333e95ceffc00def96d8abb01f75.FromRestList(array, ssZXingLibDemo.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79.ToStructure);
}
) : null;
ZXingLibDemo_Common_UserProfile_ScreenModel screenModel = new ZXingLibDemo_Common_UserProfile_ScreenModel(varLcIsButtonEnabled, varLcIsExternal, _ScreenDataSetGetUserById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
