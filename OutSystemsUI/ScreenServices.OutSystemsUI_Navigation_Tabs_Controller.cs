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
[Route("screenservices/OutSystemsUI/Navigation/Tabs")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Navigation_Tabs_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Navigation_Tabs_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Navigation_Tabs_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Navigation_Tabs_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Navigation_Tabs_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Navigation_Tabs_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Navigation_Tabs_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*Navigation.Tabs.RegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*qmrpEahwaEaN9D1+JbOnXg", 
/*TabsChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*1BVZJWdDIU+7b+4zsjJDOA", 
/*Navigation.Tabs.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*zgwoJ9z030qfus8UguA4VA", 
/*TabsInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*0JoZgv_t6keFaaPdJSXaxQ", 
/*TabsDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*9PA9hE9nDUWzwu9AripQkg", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*TabsCreate*/"Kn_hixxDWEm4lMd7mIpycQ*Rulonx77bUa5TkjqOVsF7w", 
/*TabsRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*8uoQsTCEakWmmiO51pTfKw", 
/*TabsChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*L5oF0L0230aKUGRns_YRew", 
/*TabsChangeIntegerProperty*/"Kn_hixxDWEm4lMd7mIpycQ*RZVY2GyeVk2X44c9hvT0NA", 
/*Navigation.Tabs.OnTabChangeHandler*/"Kn_hixxDWEm4lMd7mIpycQ*RuRf9hoyQUGSWG69cEzEBg"});

    }

    public OutSystemsUI_Navigation_Tabs_Controller(
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
