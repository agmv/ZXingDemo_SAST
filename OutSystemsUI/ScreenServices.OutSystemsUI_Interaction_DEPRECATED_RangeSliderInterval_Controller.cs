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
[Route("screenservices/OutSystemsUI/Interaction/DEPRECATED_RangeSliderInterval")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsUI_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*RemoveRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*flyFA20v4UOQQOXz9is0Pg", 
/*Interaction.DEPRECATED_RangeSliderInterval.OnDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*OkiJDOUr8kmFDtKswUyQSQ", 
/*Interaction.DEPRECATED_RangeSliderInterval.ToggleSlidingStatus*/"Kn_hixxDWEm4lMd7mIpycQ*jTSyUVDQ6EyiThznK8yApA", 
/*Interaction.DEPRECATED_RangeSliderInterval.ValuesChange*/"Kn_hixxDWEm4lMd7mIpycQ*Qq7PZ2hm6kmHWXXL9hDGxg", 
/*Interaction.DEPRECATED_RangeSliderInterval.OnReady*/"Kn_hixxDWEm4lMd7mIpycQ*UFmDfsJv0EiSHAVGj8dRIw", 
/*Interaction.DEPRECATED_RangeSliderInterval.SetRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*uGJblui2P0ycmNj+qwjGDg", 
/*Interaction.DEPRECATED_RangeSliderInterval.OnParametersChanged*/"Kn_hixxDWEm4lMd7mIpycQ*ZXiG26bCa0eHW5jbKyrQbw", 
/*AddRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*CHNd69jPd0mQhoaurABYmA"});

    }

    public OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_Controller(
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
