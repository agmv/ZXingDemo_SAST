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
[Route("screenservices/ZXingLibDemo/Layouts/LayoutBase")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ZXingLibDemo_Layouts_LayoutBase_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ZXingLibDemo_Layouts_LayoutBase_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ZXingLibDemo_Layouts_LayoutBase_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ZXingLibDemo_Layouts_LayoutBase_Controller); }
        public override void EnsureInitialized() { ZXingLibDemo_Layouts_LayoutBase_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ZXingLibDemo_Layouts_LayoutBase_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ZXingLibDemo_Common_MenuIcon_Controller.ProxyInstance, childControllers);
SafeAddChildController(ZXingLibDemo_Common_ApplicationTitle_Controller.ProxyInstance, childControllers);
SafeAddChildController(ZXingLibDemo_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ZXingLibDemo_Layouts_LayoutBase_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*OutSystemsUI.SetLang*/"Kn_hixxDWEm4lMd7mIpycQ*WxQ0Foobt06XqI2YgwwILQ", 
/*OutSystemsUI.AddFavicon*/"Kn_hixxDWEm4lMd7mIpycQ*_0NYWTTYl0ycqAqbD2ODmA", 
/*OutSystemsUI.LayoutReady*/"Kn_hixxDWEm4lMd7mIpycQ*3YPe0a8dvEOq0s0BQKEmYA", 
/*OutSystemsUI.SkipToContent*/"Kn_hixxDWEm4lMd7mIpycQ*47TabZ9HT0ixaXEVUGyJag", 
/*OutSystemsUI.LayoutDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*LACAJv8SP0aWsHwyAoAPKQ"});

    }

    public ZXingLibDemo_Layouts_LayoutBase_Controller(
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
