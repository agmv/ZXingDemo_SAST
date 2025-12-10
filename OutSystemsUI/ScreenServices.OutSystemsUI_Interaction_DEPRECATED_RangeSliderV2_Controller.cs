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
[Route("screenservices/OutSystemsUI/Interaction/DEPRECATED_RangeSliderV2")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*RemoveRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*flyFA20v4UOQQOXz9is0Pg", 
/*Interaction.DEPRECATED_RangeSliderV2.OnDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*dnVWIxY+MUqFEZrK7D2Amw", 
/*Interaction.DEPRECATED_RangeSliderV2.ValuesChange*/"Kn_hixxDWEm4lMd7mIpycQ*3YPgRTkR_EygoHn0EnXJbw", 
/*Interaction.DEPRECATED_RangeSliderV2.OnReady*/"Kn_hixxDWEm4lMd7mIpycQ*TmhXY1qK6EWkhJ1LPJXfKw", 
/*Interaction.DEPRECATED_RangeSliderV2.SetRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*e5PpY41xM0GQS0KL6FLOrw", 
/*Interaction.DEPRECATED_RangeSliderV2.OnParametersChanged*/"Kn_hixxDWEm4lMd7mIpycQ*y2Agc2OUsEaS+Rt49VmNkQ", 
/*Interaction.DEPRECATED_RangeSliderV2.ToggleSlidingStatus*/"Kn_hixxDWEm4lMd7mIpycQ*+q8G6HUFKkqpb6R51cvq+A", 
/*AddRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*CHNd69jPd0mQhoaurABYmA"});

    }

    public OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_Controller(
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
