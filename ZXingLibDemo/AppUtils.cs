using OutSystems.Application.ManifestGeneration;

namespace ssZXingLibDemo;

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
        return "/ZXingLibDemo/";
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
if (entityLC == "codedefaults")
    return true;
if (entityLC == "user")
    return true;
if (entityLC == "sidemenubehavior")
    return true;
if (entityLC == "size")
    return true;
if (entityLC == "guttersize")
    return true;
if (entityLC == "orientation")
    return true;
if (entityLC == "datepickertimeformat")
    return true;
if (entityLC == "direction")
    return true;
if (entityLC == "breakcolumns")
    return true;
if (entityLC == "shape")
    return true;
if (entityLC == "position")
    return true;
if (entityLC == "trigger")
    return true;
if (entityLC == "space")
    return true;
if (entityLC == "color")
    return true;
if (entityLC == "datepickerweekday")
    return true;
if (entityLC == "maperrors")
    return true;
if (entityLC == "type")
    return true;
if (entityLC == "mapeventtriggered")
    return true;
if (entityLC == "style")
    return true;
if (entityLC == "zoom")
    return true;
if (entityLC == "aicontenttype")
    return true;
if (entityLC == "airole")
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
            			{ "codedefaults", new Tuple<Func<long?, string, string>, Func<string, string>>(ENCodeDefaultsEntity.LocalViewName, ENCodeDefaultsEntity.AttributeDatabaseName)}, 
			{ "user", new Tuple<Func<long?, string, string>, Func<string, string>>(ENUserEntity.LocalViewName, ENUserEntity.AttributeDatabaseName)}, 
			{ "aicontenttype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENAIContentTypeEntity.LocalViewName, ENAIContentTypeEntity.AttributeDatabaseName)}, 
			{ "airole", new Tuple<Func<long?, string, string>, Func<string, string>>(ENAIRoleEntity.LocalViewName, ENAIRoleEntity.AttributeDatabaseName)}, 
			{ "sidemenubehavior", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSideMenuBehaviorEntity.LocalViewName, ENSideMenuBehaviorEntity.AttributeDatabaseName)}, 
			{ "size", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSizeEntity.LocalViewName, ENSizeEntity.AttributeDatabaseName)}, 
			{ "guttersize", new Tuple<Func<long?, string, string>, Func<string, string>>(ENGutterSizeEntity.LocalViewName, ENGutterSizeEntity.AttributeDatabaseName)}, 
			{ "orientation", new Tuple<Func<long?, string, string>, Func<string, string>>(ENOrientationEntity.LocalViewName, ENOrientationEntity.AttributeDatabaseName)}, 
			{ "datepickertimeformat", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDatePickerTimeFormatEntity.LocalViewName, ENDatePickerTimeFormatEntity.AttributeDatabaseName)}, 
			{ "direction", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDirectionEntity.LocalViewName, ENDirectionEntity.AttributeDatabaseName)}, 
			{ "breakcolumns", new Tuple<Func<long?, string, string>, Func<string, string>>(ENBreakColumnsEntity.LocalViewName, ENBreakColumnsEntity.AttributeDatabaseName)}, 
			{ "shape", new Tuple<Func<long?, string, string>, Func<string, string>>(ENShapeEntity.LocalViewName, ENShapeEntity.AttributeDatabaseName)}, 
			{ "position", new Tuple<Func<long?, string, string>, Func<string, string>>(ENPositionEntity.LocalViewName, ENPositionEntity.AttributeDatabaseName)}, 
			{ "trigger", new Tuple<Func<long?, string, string>, Func<string, string>>(ENTriggerEntity.LocalViewName, ENTriggerEntity.AttributeDatabaseName)}, 
			{ "space", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSpaceEntity.LocalViewName, ENSpaceEntity.AttributeDatabaseName)}, 
			{ "color", new Tuple<Func<long?, string, string>, Func<string, string>>(ENColorEntity.LocalViewName, ENColorEntity.AttributeDatabaseName)}, 
			{ "datepickerweekday", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDatePickerWeekDayEntity.LocalViewName, ENDatePickerWeekDayEntity.AttributeDatabaseName)}, 
			{ "maperrors", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMapErrorsEntity.LocalViewName, ENMapErrorsEntity.AttributeDatabaseName)}, 
			{ "type", new Tuple<Func<long?, string, string>, Func<string, string>>(ENTypeEntity.LocalViewName, ENTypeEntity.AttributeDatabaseName)}, 
			{ "mapeventtriggered", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMapEventTriggeredEntity.LocalViewName, ENMapEventTriggeredEntity.AttributeDatabaseName)}, 
			{ "style", new Tuple<Func<long?, string, string>, Func<string, string>>(ENStyleEntity.LocalViewName, ENStyleEntity.AttributeDatabaseName)}, 
			{ "zoom", new Tuple<Func<long?, string, string>, Func<string, string>>(ENZoomEntity.LocalViewName, ENZoomEntity.AttributeDatabaseName)}
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

        private static readonly ObjectKey eSpaceKey = ObjectKey.Parse("61918b7a-e496-4b63-992b-b83299b21e43") ?? ObjectKey.Dummy;
        public ObjectKey ESpaceKey {
            get {
                return eSpaceKey;
            }
        }

        // The name of the eSpace, should be used for code generation purposes and identifiers.
        public string ESpaceName {
            get {
                return "ZXingLibDemo";
            }
        }

        // The base URL path for the application, should be used for constructing URLs and path related stuff.
        public string ESpaceUrlBasePath {
            get {
                return "ZXingLibDemo";
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
