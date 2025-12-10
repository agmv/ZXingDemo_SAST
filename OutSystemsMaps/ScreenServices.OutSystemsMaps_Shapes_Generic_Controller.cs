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
[Route("screenservices/OutSystemsMaps/Shapes/Generic")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_Shapes_Generic_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_Shapes_Generic_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_Shapes_Generic_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_Shapes_Generic_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_Shapes_Generic_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_Shapes_Generic_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsMaps_Shapes_Generic_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ChangeShapeCenter*/"0TG7lXnw1k+rLlyDJoVaqg*b8YjFycVSE+AxceYfGc5Xw", 
/*Shapes.Generic.Callback_Event*/"0TG7lXnw1k+rLlyDJoVaqg*U5NBItrH5kiiDMIARpvcng", 
/*ChangeShapeStrokeOpacity*/"0TG7lXnw1k+rLlyDJoVaqg*1EXSJEb24EWiz13ogof5VQ", 
/*ChangeShapeFillOpacity*/"0TG7lXnw1k+rLlyDJoVaqg*veXPJTGki0e1gjqRBttI0w", 
/*ShapeEventSubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*VakZKy5YHk24vbRdf0bqpA", 
/*ChangeShapeFillColor*/"0TG7lXnw1k+rLlyDJoVaqg*U7dKNGqhRkOQSA8D3uIkFg", 
/*RemoveShape*/"0TG7lXnw1k+rLlyDJoVaqg*+FtAODp29ka8fIwI8VlNYA", 
/*ChangeShapeAllowDrag*/"0TG7lXnw1k+rLlyDJoVaqg*c6BFPn99WkqYg8LMBpRdCg", 
/*ChangeShapeRadius*/"0TG7lXnw1k+rLlyDJoVaqg*nowOVcrfy0a6DgR1bgTHDw", 
/*CreateShape*/"0TG7lXnw1k+rLlyDJoVaqg*dXDJhiSdmkuPoHeaxvNgjg", 
/*Shapes.Generic.SubscribeEvents*/"0TG7lXnw1k+rLlyDJoVaqg*h3xdi5DZYkCjfzwsMCJ6YA", 
/*ChangeShapeLocations*/"0TG7lXnw1k+rLlyDJoVaqg*241rqQ3XGka1R7qs3_XUjg", 
/*ChangeShapeStrokeWeight*/"0TG7lXnw1k+rLlyDJoVaqg*FxkUrV+GWUatwvpDbIFj+w", 
/*ChangeShapeAllowEdit*/"0TG7lXnw1k+rLlyDJoVaqg*4Yx0037XC02E0i_CVZmRGg", 
/*ChangeShapeStrokeColor*/"0TG7lXnw1k+rLlyDJoVaqg*yCiT2qwRl0ipYuzgDs1DFg", 
/*GetHashcode*/"0TG7lXnw1k+rLlyDJoVaqg*9Rm66uUcgU2eMSk_Le0Mbw", 
/*LogEvent*/"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A"});

    }

    public OutSystemsMaps_Shapes_Generic_Controller(
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
