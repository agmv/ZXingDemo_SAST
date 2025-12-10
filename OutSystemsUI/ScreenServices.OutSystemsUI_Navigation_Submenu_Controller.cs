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
[Route("screenservices/OutSystemsUI/Navigation/Submenu")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Navigation_Submenu_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Navigation_Submenu_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Navigation_Submenu_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Navigation_Submenu_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Navigation_Submenu_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Navigation_Submenu_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Navigation_Submenu_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*SubmenuCreate*/"Kn_hixxDWEm4lMd7mIpycQ*yaJhOP_yb0yqSYWVJZG68Q", 
/*SubmenuInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*jsQwShgXt02pRAorWLoF7w", 
/*Navigation.Submenu.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*e_KAZUwSN06XeVB1GTtWnQ", 
/*Navigation.Submenu.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*eX4LaXcDLkeTJ4daZjnA_g", 
/*SubmenuDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*mcUjblteRkG6euKqAbT9mA", 
/*SubmenuRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*YNCVdjZ4s0iCLrZ+odQOMQ", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*SubmenuChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*MO37tcJ14Eu8LFEDxBLUlQ", 
/*SubmenuOnRender*/"Kn_hixxDWEm4lMd7mIpycQ*sAnbvTFH00O3EMO_VgcYCg", 
/*Navigation.Submenu.OnToggleHandler*/"Kn_hixxDWEm4lMd7mIpycQ*p9Ro1PKLwUqHWfW4mhDqhQ"});

    }

    public OutSystemsUI_Navigation_Submenu_Controller(
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
