using Microsoft.AspNetCore.Mvc;
using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Abstractions.Controllers;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;
using OutSystems.RESTService.Runtime.Core.ErrorHandling;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Core.ClientSettings;

namespace ssZXingLibDemo.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/ZXingLibDemo/Common/UserProfile")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ZXingLibDemo_Common_UserProfile_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ZXingLibDemo_Common_UserProfile_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ZXingLibDemo_Common_UserProfile_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ZXingLibDemo_Common_UserProfile_Controller); }
        public override void EnsureInitialized() { ZXingLibDemo_Common_UserProfile_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ZXingLibDemo_Common_UserProfile_Controller.GetDbBinaryConfigs(); }
    }

    public static readonly CheckPermissionsIndex Permissions;

    private static readonly HashSet<IScreenControllerProxy> childControllers = new();
    public static IEnumerable<IScreenControllerProxy> GetChildControllers() {
        return childControllers;
    }

    private static volatile bool initialized = false;
    public static void EnsureInitialized() {
        // Only a single thread can do initializations at the time. Allows the CheckPermissionsIndex class non-threadsafe.
        // This should always be done only once at ApplicationStart
        lock (ScreenServicesApiController.GlobalScreenServicesInitializationLock) {
            if (!initialized) {
                initialized = true; // InitPermissionIndexes propagates to new parents as well so we can set it as initialized here before going into recursion

                SafeAddChildController(ZXingLibDemo_Layouts_LayoutTopMenu_Controller.ProxyInstance, childControllers);
SafeAddChildController(ZXingLibDemo_Common_Menu_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_AnimatedLabel_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ZXingLibDemo_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("Common.UserProfile"), ZXingLibDemo_Common_UserProfile_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        {
bool check;
check = await ExtendedActions.CheckZXingLibDemoRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotZXingLibDemoRoleException( "ZXingLibDemo role required");

    }


    static ZXingLibDemo_Common_UserProfile_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*UpdateUser*/"eouRYZbkY0uZK7gymbIeQw*qf3NB3XXE0+MMz8hZNSr1g", 
/*Common.UserProfile.SetIsButtonEnabled*/"eouRYZbkY0uZK7gymbIeQw*Gqssvqunxkm7Kyw4VI2UoA", 
/*Common.OnException*/"eouRYZbkY0uZK7gymbIeQw*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ZXingLibDemo_Common_UserProfile_Controller(
        IAppInfo appInfo,
        IApplicationLogger applicationLogger,
        ISettingsProvider settingsProvider,
        IHttpContextAccessor httpContextAccessor,
        IRequestContext requestContext,
        IClientSettingsService clientSettingsService
    ) : base(
        appInfo,
        applicationLogger,
        settingsProvider,
        httpContextAccessor,
        requestContext,
        clientSettingsService
    ) {
    }

[HttpPost]
[Route("ScreenDataSetGetUserById")]
[RESTScreenServicesActionProperties(Name="GetUserById",Screen="UserProfile",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "FmEie9Rgofos5XNFsd2jOg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ZXingLibDemo_Common_UserProfile_ScreenModel model = null;
AggregateInputsRecord inputs = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {model = RESTZXingLibDemo_Common_UserProfile_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserById_maxRecords = 1;
} else {
datasetGetUserById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserById_startIndex = 0;
} else {
datasetGetUserById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserById_maxRecords < 1)) {
datasetGetUserById_maxRecords = 1;
}

AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ds_output = new AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75>();
long count;
(ds_output.List,count) = await ZXingLibDemo_Common_UserProfile_ScreenModel.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Multiple,Convert.ToString(BuiltInFunction.GetUserId ()),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssZXingLibDemo.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79>(ssZXingLibDemo.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionUpdateUser")]
[RESTScreenServicesActionProperties(Name="UpdateUser",Screen="UserProfile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionUpdateUser(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "f+w9TRZi1JqSKbln3hu0zw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ZXingLibDemo_Common_UserProfile_ActionUpdateUser_Model inputs = null;
Actions.lcoUpdateUser res =  new Actions.lcoUpdateUser();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamUpdateUserResult = await Actions.ActionUpdateUser(requestContext,inputs.inParamUserUpdateInfo,cancellationToken);

var output = RESTZXingLibDemo_Common_UserProfile_ActionUpdateUser_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamUpdateUserResult);
return output;


    }, cancellationToken);
}
}
