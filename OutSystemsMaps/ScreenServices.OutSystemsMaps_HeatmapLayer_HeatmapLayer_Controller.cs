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

namespace ssOutSystemsMaps.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/OutSystemsMaps/HeatmapLayer/HeatmapLayer")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_HeatmapLayer_HeatmapLayer_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_HeatmapLayer_HeatmapLayer_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_HeatmapLayer_HeatmapLayer_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_HeatmapLayer_HeatmapLayer_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_HeatmapLayer_HeatmapLayer_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_HeatmapLayer_HeatmapLayer_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsMaps_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsMaps_HeatmapLayer_HeatmapLayer_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ChangeHeatmapLayerPoints*/"0TG7lXnw1k+rLlyDJoVaqg*9XKyAJxhxEmAV4Vxsg3WVA", 
/*GenerateUniqueId*/"0TG7lXnw1k+rLlyDJoVaqg*SdviJ86NeUiPf3xGcptBrg", 
/*ChangeHeatmapLayerGradient*/"0TG7lXnw1k+rLlyDJoVaqg*tuGSMNSPAUqSkYYkW9YjVQ", 
/*ChangeHeatmapLayerRadius*/"0TG7lXnw1k+rLlyDJoVaqg*OF6pMYNuLEiRyR963Xo8vA", 
/*CreateHeatmapLayer*/"0TG7lXnw1k+rLlyDJoVaqg*oeO5NEvlHEq9BOSVeP0QHQ", 
/*ChangeHeatmapLayerDissipateOnZoom*/"0TG7lXnw1k+rLlyDJoVaqg*eN0ZRwbc+Uu+Ajze6sGktA", 
/*ChangeHeatmapLayerMaxIntensity*/"0TG7lXnw1k+rLlyDJoVaqg*yBqfSXn1+U6xpQd1IyZ_CA", 
/*RemoveHeatmapLayer*/"0TG7lXnw1k+rLlyDJoVaqg*88FumZJ6zk+iUzQGSAVarQ", 
/*GetHashcode*/"0TG7lXnw1k+rLlyDJoVaqg*9Rm66uUcgU2eMSk_Le0Mbw", 
/*LogEvent*/"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A", 
/*ChangeHeatmapLayerOpacity*/"0TG7lXnw1k+rLlyDJoVaqg*XS9Q_wJXiE2jDPfdY4qVWg"});

    }

    public OutSystemsMaps_HeatmapLayer_HeatmapLayer_Controller(
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
