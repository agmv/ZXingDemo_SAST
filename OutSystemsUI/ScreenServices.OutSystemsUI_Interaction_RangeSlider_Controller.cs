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
[Route("screenservices/OutSystemsUI/Interaction/RangeSlider")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_RangeSlider_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_RangeSlider_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_RangeSlider_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_RangeSlider_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_RangeSlider_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_RangeSlider_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_RangeSlider_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*Interaction.RangeSlider.OnValueChangeHandler*/"Kn_hixxDWEm4lMd7mIpycQ*tqlhE+sbCUS0foPLvSRfug", 
/*RangeSliderCreate*/"Kn_hixxDWEm4lMd7mIpycQ*qwyMJedTU0yLxfiuTYUG4A", 
/*RangeSliderChangeDecimalProperty*/"Kn_hixxDWEm4lMd7mIpycQ*+a4xM2OkRU+kHtMknfeuNw", 
/*RangeSliderChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*k9RxUmGB_0aCzQXQrY33LQ", 
/*Interaction.RangeSlider.IntializeHandler*/"Kn_hixxDWEm4lMd7mIpycQ*iCbNY2G7yU220NI3uRtCNg", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*RangeSliderRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*F1zHlndqBUS7+B3bVRIXhA", 
/*RangeSliderChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*SA0EvMJ8h0aW4L58zbXHIA", 
/*RangeSliderInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*_AdWzl6SSEqfeRcCYZb5iw", 
/*Interaction.RangeSlider.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*KXhx3B4d9kaRSf4rCmJIcA", 
/*RangeSliderDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*J8cQ8LwOcEuVgDu8XK0muQ"});

    }

    public OutSystemsUI_Interaction_RangeSlider_Controller(
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
