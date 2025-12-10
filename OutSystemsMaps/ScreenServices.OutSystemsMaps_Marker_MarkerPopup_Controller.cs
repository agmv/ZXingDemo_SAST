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
[Route("screenservices/OutSystemsMaps/Marker/MarkerPopup")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_Marker_MarkerPopup_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_Marker_MarkerPopup_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_Marker_MarkerPopup_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_Marker_MarkerPopup_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_Marker_MarkerPopup_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_Marker_MarkerPopup_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsMaps_Marker_MarkerPopup_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*RemoveMarker*/"0TG7lXnw1k+rLlyDJoVaqg*cfkSEMyznEu+vlXNBkJScw", 
/*CreateMarkerByUniqueID*/"0TG7lXnw1k+rLlyDJoVaqg*lSyuE24QXUCoyYpZjz8fcA", 
/*ChangeMarkerIconHeight*/"0TG7lXnw1k+rLlyDJoVaqg*mvT9JXb0mk+5FRX6aJn4Ww", 
/*GenerateUniqueId*/"0TG7lXnw1k+rLlyDJoVaqg*SdviJ86NeUiPf3xGcptBrg", 
/*ChangeMarkerAllowDrag*/"0TG7lXnw1k+rLlyDJoVaqg*C7dbMGvtsEmcAagJEol3tw", 
/*ChangeMarkerIconUrl*/"0TG7lXnw1k+rLlyDJoVaqg*brCkSuFrKU+9dRXVEfIGOg", 
/*Marker.MarkerPopup.Callback_Event*/"0TG7lXnw1k+rLlyDJoVaqg*db1ie80roUOveA9Sq6E6eg", 
/*ChangeMarkerLocation*/"0TG7lXnw1k+rLlyDJoVaqg*_kpbfPKDpEGZYyC5cTERbA", 
/*ChangeMarkerIconWidth*/"0TG7lXnw1k+rLlyDJoVaqg*+xPlfyYlgUW456YAjXl5Yw", 
/*ChangeMarkerLabel*/"0TG7lXnw1k+rLlyDJoVaqg*qARHmpe2WUiWq9bqDOT9YQ", 
/*ChangeMarkerTitle*/"0TG7lXnw1k+rLlyDJoVaqg*7xEis+m38kCAS9WQ1RpA5w", 
/*MarkerEventSubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*ZgMMwZQd6kmObPu+vaijJA", 
/*Marker.MarkerPopup.SubscribeEvents*/"0TG7lXnw1k+rLlyDJoVaqg*Vb950KNNJUmRYNSg65Nbpw", 
/*LogEvent*/"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A"});

    }

    public OutSystemsMaps_Marker_MarkerPopup_Controller(
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
