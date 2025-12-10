using OutSystems.Application.ManifestGeneration;

namespace ssOutSystemsMaps;

public sealed class AppUtils : BaseAppUtils {
    // Entity functions (<Entity>.LocalViewName, <Entity>.AttributeDatabaseName) by entity name.
    private static Dictionary<string, Tuple<Func<long?, string, string>, Func<string, string>>> entityFunctions;

    static AppUtils() {
        // Session
#pragma warning disable 0618
        SessionDefaults.SessionDefaultFunctions += StaticProperties.Instance.GetSessionDefault;
#pragma warning restore 0618
    }

    public static readonly AppUtils Instance = new();

    protected override long GetTenantId(IRequestContext requestContext) {
        return requestContext.AppInfo.Tenant.Id;
    }

    public override string GetImagePath(bool forInternalAccess = false, bool includeSessionIdIfNeeded = false, string nameOverride = null, bool skipSeo = false) {
        return "/OutSystemsMaps/";
    }

    protected override string EntityToTablename(string entity, long tenantId) {
        string entityLC = entity.ToLowerInvariant();

        var entityFuncs = GetEntityFunctions(entityLC);

        if (entityFuncs != null) {
            return entityFuncs.Item1(App.Tenant.Id, BuiltInFunction.GetCurrentLocale()); // Item1 is LocalViewName method.
        }

        throw DatabaseErrorsHelper.UnknownEntity(entity);
    }

    protected override string EntityAttributeToColumnName(string entityName, string attributeName) {
        string entityNameLC = entityName.ToLowerInvariant();
        string columnName = null;

        var entityFuncs = GetEntityFunctions(entityNameLC);

        if (entityFuncs != null) {
            columnName = entityFuncs.Item2(attributeName); // Item2 is AttributeDatabaseName method.
        }

        if (string.IsNullOrEmpty(columnName)) {
            throw DatabaseErrorsHelper.UnknownAttribute(attributeName, entityName);
        }

        return columnName;
    }

    public string RuntimeEntityReplace(string entity, IRequestContext requestContext) {
        long tenantId = GetTenantId(requestContext);
        return EntityToTablename(entity, tenantId);
    }

    private static readonly Regex LinkRegex = new(@"@(?:\.?\w)+$", RegexOptions.Compiled | RegexOptions.CultureInvariant);
    public string RuntimeEntityReplaceLinkTable(string resolvedTableName, string attr) {
        if (!string.IsNullOrEmpty(attr)) {
            var linkMatch = LinkRegex.Match(resolvedTableName);
            if ((linkMatch != null) && linkMatch.Success) {
                string linkPart = linkMatch.Value;
                resolvedTableName = resolvedTableName.Remove(resolvedTableName.Length - linkPart.Length, linkPart.Length);
                return resolvedTableName + attr + linkPart;
            }
        }
        return resolvedTableName + attr;
    }

    public void RuntimeCheckReadOnlyEntity(string[] entitiesToCheck) {
        foreach (string entity in entitiesToCheck) {
            if (CheckReadOnlyInvalidOperations(entity)) {
                throw DatabaseErrorsHelper.EntityReadOnly(entity);
            }
        }
    }

    protected override bool CheckReadOnlyInvalidOperations(string entity) {
        string entityLC = entity.ToLowerInvariant();
if (entityLC == "logtype")
    return true;
if (entityLC == "maperrors")
    return true;
if (entityLC == "drawingtooltype")
    return true;
if (entityLC == "shapetype")
    return true;
if (entityLC == "directionsprovider")
    return true;
if (entityLC == "popupevent")
    return true;
if (entityLC == "drawingtoolseventtriggered")
    return true;
if (entityLC == "type")
    return true;
if (entityLC == "searchplacesevent")
    return true;
if (entityLC == "shapeevent")
    return true;
if (entityLC == "markertype")
    return true;
if (entityLC == "searchplaceserrors")
    return true;
if (entityLC == "mapevent")
    return true;
if (entityLC == "mapeventtriggered")
    return true;
if (entityLC == "searchtypes")
    return true;
if (entityLC == "markerevent")
    return true;
if (entityLC == "provider")
    return true;
if (entityLC == "drawingtoolsposition")
    return true;
if (entityLC == "style")
    return true;
if (entityLC == "filelayerevent")
    return true;
if (entityLC == "markereventtriggered")
    return true;
if (entityLC == "maptype")
    return true;
if (entityLC == "zoom")
    return true;
if (entityLC == "verbosity")
    return true;
if (entityLC == "drawingtoolsevent")
    return true;
if (entityLC == "shapeeventtriggered")
    return true;
if (entityLC == "travelmode")
    return true;
if (entityLC == "runtimetype")
    return true;

        return false;
    }

    public static ObjectKey eSpaceId {
        get {
            return eSpaceKey;
        }
    }

    public static ObjectKey eSpaceKey {
        get {
            return StaticProperties.Instance.ESpaceKey;
        }
    }

    public static ISitePropertiesInfo SiteProperties {
        get {
            return App.Espace(eSpaceKey).EspaceSiteProperties;
        }
    }

    public static IAppInfo App {
        get {
            return AppInfo.GetAppInfo();
        }
    }

    public static Tuple<Func<long?, string, string>, Func<string, string>> GetEntityFunctions(string entityName) {
        entityFunctions ??= new Dictionary<string, Tuple<Func<long?, string, string>, Func<string, string>>>() {
            			{ "logtype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENLogTypeEntity.LocalViewName, ENLogTypeEntity.AttributeDatabaseName)}, 
			{ "maperrors", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMapErrorsEntity.LocalViewName, ENMapErrorsEntity.AttributeDatabaseName)}, 
			{ "drawingtooltype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDrawingToolTypeEntity.LocalViewName, ENDrawingToolTypeEntity.AttributeDatabaseName)}, 
			{ "shapetype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENShapeTypeEntity.LocalViewName, ENShapeTypeEntity.AttributeDatabaseName)}, 
			{ "directionsprovider", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDirectionsProviderEntity.LocalViewName, ENDirectionsProviderEntity.AttributeDatabaseName)}, 
			{ "popupevent", new Tuple<Func<long?, string, string>, Func<string, string>>(ENPopupEventEntity.LocalViewName, ENPopupEventEntity.AttributeDatabaseName)}, 
			{ "drawingtoolseventtriggered", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDrawingToolsEventTriggeredEntity.LocalViewName, ENDrawingToolsEventTriggeredEntity.AttributeDatabaseName)}, 
			{ "type", new Tuple<Func<long?, string, string>, Func<string, string>>(ENTypeEntity.LocalViewName, ENTypeEntity.AttributeDatabaseName)}, 
			{ "searchplacesevent", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSearchPlacesEventEntity.LocalViewName, ENSearchPlacesEventEntity.AttributeDatabaseName)}, 
			{ "shapeevent", new Tuple<Func<long?, string, string>, Func<string, string>>(ENShapeEventEntity.LocalViewName, ENShapeEventEntity.AttributeDatabaseName)}, 
			{ "markertype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMarkerTypeEntity.LocalViewName, ENMarkerTypeEntity.AttributeDatabaseName)}, 
			{ "searchplaceserrors", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSearchPlacesErrorsEntity.LocalViewName, ENSearchPlacesErrorsEntity.AttributeDatabaseName)}, 
			{ "mapevent", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMapEventEntity.LocalViewName, ENMapEventEntity.AttributeDatabaseName)}, 
			{ "mapeventtriggered", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMapEventTriggeredEntity.LocalViewName, ENMapEventTriggeredEntity.AttributeDatabaseName)}, 
			{ "searchtypes", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSearchTypesEntity.LocalViewName, ENSearchTypesEntity.AttributeDatabaseName)}, 
			{ "markerevent", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMarkerEventEntity.LocalViewName, ENMarkerEventEntity.AttributeDatabaseName)}, 
			{ "provider", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProviderEntity.LocalViewName, ENProviderEntity.AttributeDatabaseName)}, 
			{ "drawingtoolsposition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDrawingToolsPositionEntity.LocalViewName, ENDrawingToolsPositionEntity.AttributeDatabaseName)}, 
			{ "style", new Tuple<Func<long?, string, string>, Func<string, string>>(ENStyleEntity.LocalViewName, ENStyleEntity.AttributeDatabaseName)}, 
			{ "filelayerevent", new Tuple<Func<long?, string, string>, Func<string, string>>(ENFileLayerEventEntity.LocalViewName, ENFileLayerEventEntity.AttributeDatabaseName)}, 
			{ "markereventtriggered", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMarkerEventTriggeredEntity.LocalViewName, ENMarkerEventTriggeredEntity.AttributeDatabaseName)}, 
			{ "maptype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMapTypeEntity.LocalViewName, ENMapTypeEntity.AttributeDatabaseName)}, 
			{ "zoom", new Tuple<Func<long?, string, string>, Func<string, string>>(ENZoomEntity.LocalViewName, ENZoomEntity.AttributeDatabaseName)}, 
			{ "verbosity", new Tuple<Func<long?, string, string>, Func<string, string>>(ENVerbosityEntity.LocalViewName, ENVerbosityEntity.AttributeDatabaseName)}, 
			{ "drawingtoolsevent", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDrawingToolsEventEntity.LocalViewName, ENDrawingToolsEventEntity.AttributeDatabaseName)}, 
			{ "shapeeventtriggered", new Tuple<Func<long?, string, string>, Func<string, string>>(ENShapeEventTriggeredEntity.LocalViewName, ENShapeEventTriggeredEntity.AttributeDatabaseName)}, 
			{ "travelmode", new Tuple<Func<long?, string, string>, Func<string, string>>(ENTravelModeEntity.LocalViewName, ENTravelModeEntity.AttributeDatabaseName)}
        };
        entityFunctions.TryGetValue(entityName, out Tuple<Func<long?, string, string>, Func<string, string>> result);
        return result;
    }

    private static readonly Lazy<IResourceManager> ResourceManager = new(() => new EmbeddedResourceManager($"{StaticProperties.Instance.ESpaceName}Language", Assembly.GetExecutingAssembly()));

    public static string GetStringResource(string key, string defaultValue) {
        var requestContext = AppInfo.GetAppInfo().RequestContext;
        return ResourceManager.Value.GetString(key, requestContext.CurrentCulture) ?? defaultValue;
    }

    public static string GetEffectiveLocale() {
        return GetStringResource("EffectiveLocale", "");
    }

    internal class StaticProperties : IModuleStaticProperties {
        private static readonly Lazy<StaticProperties> InstanceHolder = new(() => new StaticProperties());

        public static StaticProperties Instance {
            get {
                return InstanceHolder.Value;
            }
        }

        private static readonly ObjectKey eSpaceKey = ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa") ?? ObjectKey.Dummy;
        public ObjectKey ESpaceKey {
            get {
                return eSpaceKey;
            }
        }

        // The name of the eSpace, should be used for code generation purposes and identifiers.
        public string ESpaceName {
            get {
                return "OutSystemsMaps";
            }
        }

        // The base URL path for the application, should be used for constructing URLs and path related stuff.
        public string ESpaceUrlBasePath {
            get {
                return "OutSystemsMaps";
            }
        }

        public string UserProviderName {
            get {
                return "Users";
            }
        }

        private static readonly ObjectKey userProviderKey = ObjectKey.Parse("65106059-0439-4be5-b011-2f01fba4afa6");
        public ObjectKey UserProviderKey {
            get {
                return userProviderKey;
            }
        }

        public bool IsMultitenant {
            get {
                return false;
            }
        }

        public bool DebugMode {
            get {
                return false;
            }
        }

        public string CustomHandleDir {
            get {
                return "/";
            }
        }

        public object GetSessionDefault(string varName) {
            return null;
        }

        public void RegisterLifecycleListeners() { }

        public void RunDebuggerEndRequest() {
            
        }

        public ObjectKey ESpaceId { get { return eSpaceId; } }

        public string CacheInvalidationSuffix { get { return AppUtils.Instance.CacheInvalidationSuffix; } }
    }

    public override string[] GetAjaxJQueryFileNames() {
        throw new NotImplementedException();
    }

    public override string GetGlobalJavaScriptInclude() {
        throw new NotImplementedException();
    }

    public override string CacheInvalidationPlatformSuffix {
        get { return ""; }
    }

    public override string CacheInvalidationSuffix {
        get { return ""; }
    }
}
