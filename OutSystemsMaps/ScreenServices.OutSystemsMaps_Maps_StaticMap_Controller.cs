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

namespace ssOutSystemsMaps.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/OutSystemsMaps/Maps/StaticMap")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_Maps_StaticMap_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_Maps_StaticMap_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_Maps_StaticMap_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_Maps_StaticMap_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_Maps_StaticMap_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_Maps_StaticMap_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsMaps_Styles_MapCSS_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsMaps_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsMaps_Maps_StaticMap_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ", 
/*MapEventSubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*Q70TI7X_wk+YQKyOdP_D0A", 
/*Maps.StaticMap.SubscribeEvents*/"0TG7lXnw1k+rLlyDJoVaqg*U__eJUYZdESx8lSvnFi2EA", 
/*GenerateUniqueId*/"0TG7lXnw1k+rLlyDJoVaqg*SdviJ86NeUiPf3xGcptBrg", 
/*ChangeMapApiKey*/"0TG7lXnw1k+rLlyDJoVaqg*re_vRH0QtUGhpKABCuWbFQ", 
/*ChangeMarkers*/"0TG7lXnw1k+rLlyDJoVaqg*ajlkTvFzK0C5lvyg6DHkYg", 
/*ChangeMapZoom*/"0TG7lXnw1k+rLlyDJoVaqg*r9cgeghgkECgMG_YdzhGLw", 
/*ChangeMapType*/"0TG7lXnw1k+rLlyDJoVaqg*numlfOQiWECAYEJbdqImzQ", 
/*Maps.StaticMap.InitializeProviderMap*/"0TG7lXnw1k+rLlyDJoVaqg*mYBbfwRm7ECoJsVdAfGAmQ", 
/*SetMapHeight*/"0TG7lXnw1k+rLlyDJoVaqg*zvevkEhf+UOOrk1WF0+ZIw", 
/*RemoveMap*/"0TG7lXnw1k+rLlyDJoVaqg*RHbhkESWF0+NUTEVAgBObw", 
/*Maps.StaticMap.MapOnError_Callback*/"0TG7lXnw1k+rLlyDJoVaqg*xe48kT4P3UaE3pLUbVKhlA", 
/*Maps.StaticMap.SetApiKey*/"0TG7lXnw1k+rLlyDJoVaqg*ftBTrUh02kCkz0qcNmz2UQ", 
/*InitMap*/"0TG7lXnw1k+rLlyDJoVaqg*CThy07XOLUWx3pC42wMslw", 
/*CreateMap*/"0TG7lXnw1k+rLlyDJoVaqg*x_bD4+aI00OZVXWHYBcgqw", 
/*ChangeMapLocalization*/"0TG7lXnw1k+rLlyDJoVaqg*3K8l6VFFsUK1nDA0bcMXfg", 
/*GetHashcode*/"0TG7lXnw1k+rLlyDJoVaqg*9Rm66uUcgU2eMSk_Le0Mbw", 
/*LogEvent*/"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A", 
/*ChangeMapLocation*/"0TG7lXnw1k+rLlyDJoVaqg*efqT+sEXEUmu3HCDqG4SPQ"});

    }

    public OutSystemsMaps_Maps_StaticMap_Controller(
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
[Route("DataActionObtainMapKey")]
[RESTScreenServicesActionProperties(Name="ObtainMapKey",Screen="StaticMap",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionObtainMapKey(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "b6vWZHcEVp428CIoBdY18Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        OutSystemsMaps_Maps_StaticMap_ScreenModel model = null;
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

try {model = RESTOutSystemsMaps_Maps_StaticMap_ScreenModel.FromJSON(screenModel, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamServerAPIKey;
outParamServerAPIKey = await model.DataActionObtainMapKey(requestContext,cancellationToken);

var output = RESTOutSystemsMaps_Maps_StaticMap_DataActionObtainMapKey_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamServerAPIKey);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetMapErrorByMapErrorCode")]
[RESTScreenServicesActionProperties(Name="GetMapErrorByMapErrorCode",Screen="StaticMap",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetMapErrorByMapErrorCode(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "AKO00eFUq17OMeJdpb1KGw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        OutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Model inputs = null;
Actions.lcoGetMapErrorByMapErrorCode res =  new Actions.lcoGetMapErrorByMapErrorCode();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTOutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMessage = await Actions.ActionGetMapErrorByMapErrorCode(requestContext,inputs.inParamMapErrorCode,cancellationToken);

var output = RESTOutSystemsMaps_Maps_StaticMap_ActionGetMapErrorByMapErrorCode_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMessage);
return output;


    }, cancellationToken);
}
}
