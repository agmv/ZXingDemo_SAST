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
[Route("screenservices/OutSystemsMaps/FileLayer/FileLayer")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_FileLayer_FileLayer_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_FileLayer_FileLayer_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_FileLayer_FileLayer_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_FileLayer_FileLayer_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_FileLayer_FileLayer_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_FileLayer_FileLayer_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsMaps_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsMaps_FileLayer_FileLayer_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"0TG7lXnw1k+rLlyDJoVaqg*SdviJ86NeUiPf3xGcptBrg", 
/*ChangeFileLayerPreserveViewport*/"0TG7lXnw1k+rLlyDJoVaqg*W_NAOoD83ECsAeu43mU87g", 
/*ChangeFileLayerLayerURL*/"0TG7lXnw1k+rLlyDJoVaqg*TL8VZZx7SE69lz9wPejUqA", 
/*FileLayer.FileLayer.SubscribeEvents*/"0TG7lXnw1k+rLlyDJoVaqg*7lKChS7AqUK8jOgan_sfAA", 
/*CreateFileLayer*/"0TG7lXnw1k+rLlyDJoVaqg*qE3kv2gbsUaE5FefNNboDA", 
/*ChangeFileLayerSuppressPopups*/"0TG7lXnw1k+rLlyDJoVaqg*KsxK0u82XEKJKhM7DYZ_zw", 
/*FileLayer.FileLayer.Callback_Event*/"0TG7lXnw1k+rLlyDJoVaqg*0tZV5+CgYEWokFCZOP3NBA", 
/*FileLayerEventUnsubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*o8f67OcRI0+kmXTevMYCEA", 
/*FileLayerEventSubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*1llB7qKrW0unUf9AhKl2dA", 
/*RemoveFileLayer*/"0TG7lXnw1k+rLlyDJoVaqg*xzCw9cfMTUy9Ql6lOKJ36g", 
/*LogEvent*/"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A"});

    }

    public OutSystemsMaps_FileLayer_FileLayer_Controller(
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


}
