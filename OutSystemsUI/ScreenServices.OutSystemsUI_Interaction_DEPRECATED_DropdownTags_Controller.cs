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
[Route("screenservices/OutSystemsUI/Interaction/DEPRECATED_DropdownTags")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_DEPRECATED_DropdownTags_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_DEPRECATED_DropdownTags_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_DEPRECATED_DropdownTags_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_DEPRECATED_DropdownTags_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_DEPRECATED_DropdownTags_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_DEPRECATED_DropdownTags_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_DEPRECATED_DropdownTags_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*RemoveRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*flyFA20v4UOQQOXz9is0Pg", 
/*Interaction.DEPRECATED_DropdownTags.SerializeData*/"Kn_hixxDWEm4lMd7mIpycQ*QiWwCfdkPEGj7TYCPpHIQQ", 
/*Interaction.DEPRECATED_DropdownTags.OnChangeListener*/"Kn_hixxDWEm4lMd7mIpycQ*5NlLWO3tOEKWPly1eNiQoA", 
/*Interaction.DEPRECATED_DropdownTags.OnDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*E8opZ2KcOESRSy0Aqx77Cw", 
/*Interaction.DEPRECATED_DropdownTags.OnParametersChanged*/"Kn_hixxDWEm4lMd7mIpycQ*ndFfbEhu0E6LF7RQKDQC5Q", 
/*Interaction.DEPRECATED_DropdownTags.SetRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*gGlkhXplLEuHtTYTFxjq7A", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*AddRTLObserver*/"Kn_hixxDWEm4lMd7mIpycQ*CHNd69jPd0mQhoaurABYmA", 
/*Interaction.DEPRECATED_DropdownTags.GetCurrentList*/"Kn_hixxDWEm4lMd7mIpycQ*x7np66Ehp0yOOYMaDRavrQ", 
/*Interaction.DEPRECATED_DropdownTags.Init*/"Kn_hixxDWEm4lMd7mIpycQ*IRlz99zQUkCra25W1qV1Ng"});

    }

    public OutSystemsUI_Interaction_DEPRECATED_DropdownTags_Controller(
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
