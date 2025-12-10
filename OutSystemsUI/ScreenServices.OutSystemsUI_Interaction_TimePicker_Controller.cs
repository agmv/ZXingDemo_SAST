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
[Route("screenservices/OutSystemsUI/Interaction/TimePicker")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_TimePicker_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_TimePicker_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_TimePicker_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_TimePicker_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_TimePicker_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_TimePicker_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_TimePicker_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*TimePickerRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*YnexAi+I60yuYCHeyfoFpQ", 
/*TimePickerChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*cgvQKTNPZUqiQ_NS68wAMg", 
/*TimePickerCreate*/"Kn_hixxDWEm4lMd7mIpycQ*UJHwMfEDBkSqUzWYDH6ZKQ", 
/*Interaction.TimePicker.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*UefyMStEakW5oDYP3nQ+gQ", 
/*TimePickerChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*Q95KOfVKskKDevpzYO3Bvg", 
/*SetServerDateFormat*/"Kn_hixxDWEm4lMd7mIpycQ*dSnvORlvaEqP6BF_G1bxxQ", 
/*Interaction.TimePicker.OnChangeTimeHandler*/"Kn_hixxDWEm4lMd7mIpycQ*pYc9P9E+rUS1+yiGLJNheQ", 
/*TimePickerOnRender*/"Kn_hixxDWEm4lMd7mIpycQ*LxuSUG_eY0WtIEizhyp1GQ", 
/*TimePickerDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*pa9uWEepakuuI5TEVOYC4w", 
/*SetLocalLanguage*/"Kn_hixxDWEm4lMd7mIpycQ*uLJtfxx3vkap6uBwet72cw", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*Interaction.TimePicker.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*77broPv9D0Cv+L9v4hqj1w", 
/*TimePickerInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*v602tGPDn02zhIfzQMy77g", 
/*TimePickerChangeTimeProperty*/"Kn_hixxDWEm4lMd7mIpycQ*OvIY7IizLUiIwvY84_iy7w"});

    }

    public OutSystemsUI_Interaction_TimePicker_Controller(
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
