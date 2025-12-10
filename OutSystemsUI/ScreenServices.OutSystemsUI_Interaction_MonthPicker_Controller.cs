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
[Route("screenservices/OutSystemsUI/Interaction/MonthPicker")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_MonthPicker_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_MonthPicker_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_MonthPicker_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_MonthPicker_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_MonthPicker_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_MonthPicker_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_MonthPicker_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*MonthPickerChangeMonthYearProperty*/"Kn_hixxDWEm4lMd7mIpycQ*htWMGX7ULEiDJ9bPbZRU0g", 
/*Interaction.MonthPicker.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*JaDkGQJBF0mTOH8UKkuR8A", 
/*MonthPickerRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*WcdvGgRGCUuCnY2DtWlwLQ", 
/*MonthPickerOnRender*/"Kn_hixxDWEm4lMd7mIpycQ*XYHGHWdLp0KAV8kzc5FJYw", 
/*MonthPickerDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*jCjsJeibk0qBlPZLR7ZHsQ", 
/*SetServerDateFormat*/"Kn_hixxDWEm4lMd7mIpycQ*dSnvORlvaEqP6BF_G1bxxQ", 
/*SetLocalLanguage*/"Kn_hixxDWEm4lMd7mIpycQ*uLJtfxx3vkap6uBwet72cw", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*MonthPickerChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*JdWomrlYnUCR7unoLEYl1g", 
/*Interaction.MonthPicker.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*uVqSppxIEkS4lPnBzL1LtQ", 
/*Interaction.MonthPicker.OnSelectedMonthHandler*/"Kn_hixxDWEm4lMd7mIpycQ*ebnf1AxUMk6Tke7uWrkzRA", 
/*MonthPickerInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*ZGyY_LQ_Ake8NSLf7itTyA", 
/*MonthPickerCreate*/"Kn_hixxDWEm4lMd7mIpycQ*fioO_2Kiy0qwK1PT31qXfQ"});

    }

    public OutSystemsUI_Interaction_MonthPicker_Controller(
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
