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
[Route("screenservices/OutSystemsMaps/Drawing_Tools/DrawPolygon")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_Drawing_Tools_DrawPolygon_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_Drawing_Tools_DrawPolygon_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_Drawing_Tools_DrawPolygon_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_Drawing_Tools_DrawPolygon_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_Drawing_Tools_DrawPolygon_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_Drawing_Tools_DrawPolygon_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsMaps_Drawing_Tools_DrawPolygon_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"0TG7lXnw1k+rLlyDJoVaqg*SdviJ86NeUiPf3xGcptBrg", 
/*ToolsEventSubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*gon+MMkrR0Gg1QUPDPYFQA", 
/*ChangeToolStrokeColor*/"0TG7lXnw1k+rLlyDJoVaqg*ZJJpMVnfy06nLZgBEbfJ+A", 
/*ChangeToolStrokeWeight*/"0TG7lXnw1k+rLlyDJoVaqg*TeMFSSDAYkuwRPsWoB9nQQ", 
/*ChangeToolFillColor*/"0TG7lXnw1k+rLlyDJoVaqg*ima0VCj2hU+FhW9gFLa51A", 
/*ChangeToolFillOpacity*/"0TG7lXnw1k+rLlyDJoVaqg*Aye9fkIfnE+403zOAvrqpw", 
/*RemoveTool*/"0TG7lXnw1k+rLlyDJoVaqg*2WJEwKPc4EWBaN5_J6yoQg", 
/*ChangeToolAllowEdit*/"0TG7lXnw1k+rLlyDJoVaqg*pFWjyG1VqEa6uB3b+cth5g", 
/*AddTool*/"0TG7lXnw1k+rLlyDJoVaqg*m8L6yj+jWUOuALL8Tj3Grg", 
/*ChangeToolStrokeOpacity*/"0TG7lXnw1k+rLlyDJoVaqg*Oedb1DSViEq3KbYKKZHvzg", 
/*ToolsEventUnSubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*3FKr35zYFEOC_jkfXx7BCA", 
/*Drawing_Tools.DrawPolygon.SubscribeEvents*/"0TG7lXnw1k+rLlyDJoVaqg*HIGG4uCnj0ugi0uYMWirhA", 
/*Drawing_Tools.DrawPolygon.Callback_Event*/"0TG7lXnw1k+rLlyDJoVaqg*Rc4o5kGuFEKPfOhvo5I7JQ", 
/*ChangeToolAllowDrag*/"0TG7lXnw1k+rLlyDJoVaqg*ADFT6cMHTkSMaapqOFbluw", 
/*LogEvent*/"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A"});

    }

    public OutSystemsMaps_Drawing_Tools_DrawPolygon_Controller(
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
