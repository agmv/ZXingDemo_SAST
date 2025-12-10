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
[Route("screenservices/OutSystemsMaps/SearchPlaces_Legacy/SearchPlaces_Legacy")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsMaps_Styles_Legacy_PlacesCSS_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsMaps_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*SearchPlaces_Legacy.SearchPlaces_Legacy.SetApiKey*/"0TG7lXnw1k+rLlyDJoVaqg*9n7sAkoJekyagdsEhMAGjQ", 
/*SearchPlaces_Legacy.SearchPlaces_Legacy.InitializeProviderSearchPlaces*/"0TG7lXnw1k+rLlyDJoVaqg*smaIB8IUZUynCcPxny1XzQ", 
/*SearchPlaces_Legacy.SearchPlaces_Legacy.SubscribeEvents*/"0TG7lXnw1k+rLlyDJoVaqg*Ut3ACCquJUe1HGe9wnOegw", 
/*GenerateUniqueId*/"0TG7lXnw1k+rLlyDJoVaqg*SdviJ86NeUiPf3xGcptBrg", 
/*ChangeSearchPlacesCountries*/"0TG7lXnw1k+rLlyDJoVaqg*NNdEOJouNECbhHSOYWEkKg", 
/*SearchPlaces_Legacy.SearchPlaces_Legacy.SearchPlacesOnError_Callback*/"0TG7lXnw1k+rLlyDJoVaqg*TgJ7OAtQzU6d8w0og0KJYg", 
/*CreateSearchPlacesLegacy*/"0TG7lXnw1k+rLlyDJoVaqg*MV5SdKOGf0iV3BQCrSZcSw", 
/*GetSearchPlacesErrorBySearchPlacesErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*EZxfdvhLK0OX_JDJhF+P6A", 
/*SearchPlaces_Legacy.SearchPlaces_Legacy.SearchPlacesOnPlaceSelect_Callback*/"0TG7lXnw1k+rLlyDJoVaqg*2a8bgjKi9UOFhhLsaIVPcQ", 
/*ChangeSearchPlacesLocalization*/"0TG7lXnw1k+rLlyDJoVaqg*DXcWhgEjq06y7jmZgMt_sw", 
/*RemoveSearchPlaces*/"0TG7lXnw1k+rLlyDJoVaqg*aIcElYMKCkG0DXQrruiFyQ", 
/*ChangeSearchPlacesSearchType*/"0TG7lXnw1k+rLlyDJoVaqg*skmIoBBHuUiuvVO5AtEPXQ", 
/*InitSearchPlaces*/"0TG7lXnw1k+rLlyDJoVaqg*Thanpe5FW0awqeGwkWUVyA", 
/*SearchPlacesEventSubscribe*/"0TG7lXnw1k+rLlyDJoVaqg*LK3nq_OmgES19DijHAyPZQ", 
/*SetProviderVersion*/"0TG7lXnw1k+rLlyDJoVaqg*hIwIrazlfEClaXYpbfsOCw", 
/*ChangeSearchPlacesSearchArea*/"0TG7lXnw1k+rLlyDJoVaqg*yz_avGz+ZE6YrL5q2g4_aA", 
/*ChangeSearchPlacesApiKey*/"0TG7lXnw1k+rLlyDJoVaqg*boMCvgHkxE2gSVw7_2sHwg", 
/*LogEvent*/"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A"});

    }

    public OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_Controller(
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

[HttpPost]
[Route("DataActionGetApiVersion")]
[RESTScreenServicesActionProperties(Name="GetApiVersion",Screen="SearchPlaces_Legacy",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetApiVersion(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "W7oDqG0MFaHlqkUIo+i8Sw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel model = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {model = RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel.FromJSON(screenModel, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamGoogleMapsApiVersion;
outParamGoogleMapsApiVersion = await model.DataActionGetApiVersion(requestContext,cancellationToken);

var output = RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_DataActionGetApiVersion_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamGoogleMapsApiVersion);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetServerAPIKey")]
[RESTScreenServicesActionProperties(Name="GetServerAPIKey",Screen="SearchPlaces_Legacy",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetServerAPIKey(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "WFv389nwOUTdQT3xqOYXCQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel model = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {model = RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ScreenModel.FromJSON(screenModel, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamServerAPIKey;
string outParamGoogleMapsApiVersion;
(outParamServerAPIKey,outParamGoogleMapsApiVersion) = await model.DataActionGetServerAPIKey(requestContext,cancellationToken);

var output = RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_DataActionGetServerAPIKey_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamServerAPIKey, outParamGoogleMapsApiVersion);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSearchPlacesErrorBySearchPlacesErrorCode")]
[RESTScreenServicesActionProperties(Name="GetSearchPlacesErrorBySearchPlacesErrorCode",Screen="SearchPlaces_Legacy",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSearchPlacesErrorBySearchPlacesErrorCode(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3hhUEU7Ppvah3oqUJMYQKA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        OutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ActionGetSearchPlacesErrorBySearchPlacesErrorCode_Model inputs = null;
Actions.lcoGetSearchPlacesErrorBySearchPlacesErrorCode res =  new Actions.lcoGetSearchPlacesErrorBySearchPlacesErrorCode();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ActionGetSearchPlacesErrorBySearchPlacesErrorCode_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMessage = await Actions.ActionGetSearchPlacesErrorBySearchPlacesErrorCode(requestContext,inputs.inParamSearchPlacesErrorCode,cancellationToken);

var output = RESTOutSystemsMaps_SearchPlaces_Legacy_SearchPlaces_Legacy_ActionGetSearchPlacesErrorBySearchPlacesErrorCode_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMessage);
return output;


    }, cancellationToken);
}
}
