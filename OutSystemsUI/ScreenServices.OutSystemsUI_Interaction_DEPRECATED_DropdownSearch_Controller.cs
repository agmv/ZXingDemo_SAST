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
[Route("screenservices/OutSystemsUI/Interaction/DEPRECATED_DropdownSearch")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*RemoveRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*flyFA20v4UOQQOXz9is0Pg", 
/*Interaction.DEPRECATED_DropdownSearch.Init*/"Kn_hixxDWEm4lMd7mIpycQ*XOXHCmIGpUiBTJtRqB8hpA", 
/*Interaction.DEPRECATED_DropdownSearch.OnParametersChanged*/"Kn_hixxDWEm4lMd7mIpycQ*4lg0KYVMAEmcxxI0ldm59Q", 
/*Interaction.DEPRECATED_DropdownSearch.GetValueOnSelect*/"Kn_hixxDWEm4lMd7mIpycQ*9fPyMp3JWE2qJcRcmnKRKw", 
/*Interaction.DEPRECATED_DropdownSearch.OnDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*YXDJN8gvcEiGFNoOla0VOQ", 
/*Interaction.DEPRECATED_DropdownSearch.OnChangeListener*/"Kn_hixxDWEm4lMd7mIpycQ*UVQaTw47nEOlNidQYzjnvQ", 
/*Interaction.DEPRECATED_DropdownSearch.OnHideDropdown*/"Kn_hixxDWEm4lMd7mIpycQ*ZESmddqo20q2KrI504VGNw", 
/*Interaction.DEPRECATED_DropdownSearch.SetRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*z92afRHZaUqZySy3U1xR0w", 
/*Interaction.DEPRECATED_DropdownSearch.OnShowDropdown*/"Kn_hixxDWEm4lMd7mIpycQ*YmB0kwU26EWJivpVGJ+dPQ", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*AddRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*CHNd69jPd0mQhoaurABYmA"});

    }

    public OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_Controller(
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
