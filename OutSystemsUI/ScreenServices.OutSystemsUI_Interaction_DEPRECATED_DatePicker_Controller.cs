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
[Route("screenservices/OutSystemsUI/Interaction/DEPRECATED_DatePicker")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_DEPRECATED_DatePicker_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_DEPRECATED_DatePicker_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_DEPRECATED_DatePicker_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_DEPRECATED_DatePicker_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_DEPRECATED_DatePicker_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_DEPRECATED_DatePicker_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_DEPRECATED_DatePicker_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*Interaction.DEPRECATED_DatePicker.SelectDate*/"Kn_hixxDWEm4lMd7mIpycQ*fA4KFuaDYEqZuIon+B8QQg", 
/*Interaction.DEPRECATED_DatePicker.Init*/"Kn_hixxDWEm4lMd7mIpycQ*nXW0IeR130q2acfZcLffdg", 
/*Interaction.DEPRECATED_DatePicker.OnParametersChanged*/"Kn_hixxDWEm4lMd7mIpycQ*twlZScuq9U6RkiuPsQBDpA", 
/*Interaction.DEPRECATED_DatePicker.OnDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*yI8YTE10EEuKpyIXqX9NMQ", 
/*DEPRECATED_DatepickerExposeTranslations*/"Kn_hixxDWEm4lMd7mIpycQ*EmOJTVVnHUKuypR_b66DFA", 
/*Interaction.DEPRECATED_DatePicker.CheckFieldValue*/"Kn_hixxDWEm4lMd7mIpycQ*FGbAeXQI5UaJQLtLSR+Cmw", 
/*Interaction.DEPRECATED_DatePicker.CheckValueOnFormValidation*/"Kn_hixxDWEm4lMd7mIpycQ*xK_tsZBHpk6JGqFP6uChjg", 
/*Interaction.DEPRECATED_DatePicker.Observer*/"Kn_hixxDWEm4lMd7mIpycQ*0M8MvANYJkmQAA1IMlqiHA", 
/*Interaction.DEPRECATED_DatePicker.SetValue*/"Kn_hixxDWEm4lMd7mIpycQ*2wQi_K8ih0OpdqB7loEHqg"});

    }

    public OutSystemsUI_Interaction_DEPRECATED_DatePicker_Controller(
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
