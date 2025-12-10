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
[Route("screenservices/OutSystemsMaps/Maps/LeafletMap")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_Maps_LeafletMap_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_Maps_LeafletMap_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_Maps_LeafletMap_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_Maps_LeafletMap_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_Maps_LeafletMap_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_Maps_LeafletMap_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsMaps_Styles_ImagesCSS_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsMaps_Styles_MapCSS_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsMaps_Styles_LeafletCSS_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsMaps_Styles_LeafletRoutingCSS_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsMaps_Styles_LeafletDrawCSS_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsMaps_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsMaps_Maps_LeafletMap_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ", 
/*MapEventUnsubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*LkidC3UwsUmqzuXEfwOWIQ", 
/*Maps.LeafletMap.MapInitialized_Callback*/"0TG7lXnw1k+rLlyDJoVaqg*dzITG_LQ60W2BrL+qqZKLg", 
/*MapEventSubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*Q70TI7X_wk+YQKyOdP_D0A", 
/*GenerateUniqueId*/"0TG7lXnw1k+rLlyDJoVaqg*SdviJ86NeUiPf3xGcptBrg", 
/*Maps.LeafletMap.UnsubscribeEvents*/"0TG7lXnw1k+rLlyDJoVaqg*+8cYYnSPfUSoTusp+wmvCQ", 
/*ChangeMapZoom*/"0TG7lXnw1k+rLlyDJoVaqg*r9cgeghgkECgMG_YdzhGLw", 
/*Maps.LeafletMap.SubscribeEvents*/"0TG7lXnw1k+rLlyDJoVaqg*T6qGhYf9bU6ejl7Pxmudtw", 
/*SetMapHeight*/"0TG7lXnw1k+rLlyDJoVaqg*zvevkEhf+UOOrk1WF0+ZIw", 
/*RemoveMap*/"0TG7lXnw1k+rLlyDJoVaqg*RHbhkESWF0+NUTEVAgBObw", 
/*Maps.LeafletMap.MapOnError_Callback*/"0TG7lXnw1k+rLlyDJoVaqg*ndWwtsLlJ0OicnO2nLV2WQ", 
/*ChangeMapRespectUserZoom*/"0TG7lXnw1k+rLlyDJoVaqg*+1y5xfyciEy5idMcZ6frOw", 
/*InitMap*/"0TG7lXnw1k+rLlyDJoVaqg*CThy07XOLUWx3pC42wMslw", 
/*ChangeMapOffset*/"0TG7lXnw1k+rLlyDJoVaqg*90GM4m8oWEWE6oo54l+U6Q", 
/*CreateMap*/"0TG7lXnw1k+rLlyDJoVaqg*x_bD4+aI00OZVXWHYBcgqw", 
/*LogEvent*/"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A", 
/*ChangeMapLocation*/"0TG7lXnw1k+rLlyDJoVaqg*efqT+sEXEUmu3HCDqG4SPQ"});

    }

    public OutSystemsMaps_Maps_LeafletMap_Controller(
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
[Route("ActionGetMapErrorByMapErrorCode")]
[RESTScreenServicesActionProperties(Name="GetMapErrorByMapErrorCode",Screen="LeafletMap",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetMapErrorByMapErrorCode(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "AKO00eFUq17OMeJdpb1KGw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        OutSystemsMaps_Maps_LeafletMap_ActionGetMapErrorByMapErrorCode_Model inputs = null;
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

try {inputs = RESTOutSystemsMaps_Maps_LeafletMap_ActionGetMapErrorByMapErrorCode_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMessage = await Actions.ActionGetMapErrorByMapErrorCode(requestContext,inputs.inParamMapErrorCode,cancellationToken);

var output = RESTOutSystemsMaps_Maps_LeafletMap_ActionGetMapErrorByMapErrorCode_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMessage);
return output;


    }, cancellationToken);
}
}
