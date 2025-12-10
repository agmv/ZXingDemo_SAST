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
[Route("screenservices/OutSystemsUI/Interaction/DatePickerRange")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_DatePickerRange_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_DatePickerRange_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_DatePickerRange_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_DatePickerRange_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_DatePickerRange_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_DatePickerRange_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_DatePickerRange_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*Interaction.DatePickerRange.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*6H2sDT7gV0yFjDYBf5D3rA", 
/*DatePickerChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*kmdxHSW+Fk2Fhi1eKD07Aw", 
/*SetServerDateFormat*/"Kn_hixxDWEm4lMd7mIpycQ*dSnvORlvaEqP6BF_G1bxxQ", 
/*DatePickerDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*Hw_ndug_x0y441UgRflEWg", 
/*SetLocalLanguage*/"Kn_hixxDWEm4lMd7mIpycQ*uLJtfxx3vkap6uBwet72cw", 
/*DatePickerChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*NbUigcCGvky4iMH+zAQUEA", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*DatePickerInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*veZMpyesyke+4wQR2KlNtg", 
/*Interaction.DatePickerRange.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*L6R9qiBXQku6qwRnm1mO8A", 
/*DatePickerCreate*/"Kn_hixxDWEm4lMd7mIpycQ*2QYBrY19L0OPq_VsjvVOVg", 
/*Interaction.DatePickerRange.OnChangeDateHandler*/"Kn_hixxDWEm4lMd7mIpycQ*HGrlr807C0qWN6yqnUD+6g", 
/*DatePickerOnRender*/"Kn_hixxDWEm4lMd7mIpycQ*YfLcwg3_lUmyl2B1H1zolA", 
/*DatePickerChangeIntegerProperty*/"Kn_hixxDWEm4lMd7mIpycQ*ubvt0maKLEebI81J6xoLjQ", 
/*DatePickerChangeDateTimeProperty*/"Kn_hixxDWEm4lMd7mIpycQ*7yaI4ZkmKEKEGZVURawaNQ", 
/*DatePickerRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*at_u6myc30+GfKMUn2C0ZA"});

    }

    public OutSystemsUI_Interaction_DatePickerRange_Controller(
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
