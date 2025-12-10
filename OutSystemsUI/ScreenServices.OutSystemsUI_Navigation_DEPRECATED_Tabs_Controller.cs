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

namespace ssOutSystemsUI.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/OutSystemsUI/Navigation/DEPRECATED_Tabs")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Navigation_DEPRECATED_Tabs_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Navigation_DEPRECATED_Tabs_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Navigation_DEPRECATED_Tabs_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Navigation_DEPRECATED_Tabs_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Navigation_DEPRECATED_Tabs_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Navigation_DEPRECATED_Tabs_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsUI_Utilities_TouchEvents_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsUI_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsUI_Navigation_DEPRECATED_Tabs_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*RemoveRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*flyFA20v4UOQQOXz9is0Pg", 
/*Navigation.DEPRECATED_Tabs.SetRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*GqpxcmrhikiYfD4EFfbmWg", 
/*Navigation.DEPRECATED_Tabs.UpdateUI*/"Kn_hixxDWEm4lMd7mIpycQ*N8gFe5fhQECibP4vY3Fcdw", 
/*Navigation.DEPRECATED_Tabs.AddOverlay*/"Kn_hixxDWEm4lMd7mIpycQ*zqWcfEAnqkqRv33DkI4WFQ", 
/*Navigation.DEPRECATED_Tabs.RemoveActive*/"Kn_hixxDWEm4lMd7mIpycQ*FjdzgE1IGU+KGFGAX1uZJA", 
/*Navigation.DEPRECATED_Tabs.OnOrientationChange*/"Kn_hixxDWEm4lMd7mIpycQ*qldXisp9CEKQRpjKXLcvSg", 
/*Navigation.DEPRECATED_Tabs.SetTabs*/"Kn_hixxDWEm4lMd7mIpycQ*Vdeei8qJ3kOTPndFYHWJRg", 
/*Navigation.DEPRECATED_Tabs.TabsOnClick*/"Kn_hixxDWEm4lMd7mIpycQ*IOGA1dt_t0GH81sc6c0s8g", 
/*Navigation.DEPRECATED_Tabs.ChangeTab*/"Kn_hixxDWEm4lMd7mIpycQ*69uN6FKKBUGZZSoyuDiwng", 
/*Navigation.DEPRECATED_Tabs.RemoveTransition*/"Kn_hixxDWEm4lMd7mIpycQ*alkn6RQSw0eO6rt7X2vZ5A", 
/*AddRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*CHNd69jPd0mQhoaurABYmA"});

    }

    public OutSystemsUI_Navigation_DEPRECATED_Tabs_Controller(
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
