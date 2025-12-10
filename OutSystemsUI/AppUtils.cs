using OutSystems.Application.ManifestGeneration;

namespace ssOutSystemsUI;

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
        return "/OutSystemsUI/";
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
if (entityLC == "carouselprovider")
    return true;
if (entityLC == "animationtype")
    return true;
if (entityLC == "speed")
    return true;
if (entityLC == "sidemenubehavior")
    return true;
if (entityLC == "gradient")
    return true;
if (entityLC == "size")
    return true;
if (entityLC == "deviceresponsive")
    return true;
if (entityLC == "guttersize")
    return true;
if (entityLC == "month")
    return true;
if (entityLC == "datepickerlanguage")
    return true;
if (entityLC == "deprecated_color")
    return true;
if (entityLC == "orientation")
    return true;
if (entityLC == "datepickertimeformat")
    return true;
if (entityLC == "accordionicontype")
    return true;
if (entityLC == "direction")
    return true;
if (entityLC == "breakcolumns")
    return true;
if (entityLC == "rangeslidertype")
    return true;
if (entityLC == "shape")
    return true;
if (entityLC == "stackedcardsposition")
    return true;
if (entityLC == "carouseldirection")
    return true;
if (entityLC == "rangesliderprovider")
    return true;
if (entityLC == "registeredcallbackevents")
    return true;
if (entityLC == "autoplay")
    return true;
if (entityLC == "position")
    return true;
if (entityLC == "identityprovider")
    return true;
if (entityLC == "trigger")
    return true;
if (entityLC == "space")
    return true;
if (entityLC == "alert")
    return true;
if (entityLC == "floatingposition")
    return true;
if (entityLC == "booleantypes")
    return true;
if (entityLC == "menuaction")
    return true;
if (entityLC == "accordioniconposition")
    return true;
if (entityLC == "datepickercalendartype")
    return true;
if (entityLC == "logtype")
    return true;
if (entityLC == "progresstype")
    return true;
if (entityLC == "messagestatus")
    return true;
if (entityLC == "scrollbarstyle")
    return true;
if (entityLC == "dropdownprovider")
    return true;
if (entityLC == "color")
    return true;
if (entityLC == "columnbreak")
    return true;
if (entityLC == "dropdowntype")
    return true;
if (entityLC == "steps")
    return true;
if (entityLC == "datepickerprovider")
    return true;
if (entityLC == "carouselnavigation")
    return true;
if (entityLC == "videostate")
    return true;
if (entityLC == "datepickerweekday")
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
            			{ "carouselprovider", new Tuple<Func<long?, string, string>, Func<string, string>>(ENCarouselProviderEntity.LocalViewName, ENCarouselProviderEntity.AttributeDatabaseName)}, 
			{ "animationtype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENAnimationTypeEntity.LocalViewName, ENAnimationTypeEntity.AttributeDatabaseName)}, 
			{ "speed", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSpeedEntity.LocalViewName, ENSpeedEntity.AttributeDatabaseName)}, 
			{ "sidemenubehavior", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSideMenuBehaviorEntity.LocalViewName, ENSideMenuBehaviorEntity.AttributeDatabaseName)}, 
			{ "gradient", new Tuple<Func<long?, string, string>, Func<string, string>>(ENGradientEntity.LocalViewName, ENGradientEntity.AttributeDatabaseName)}, 
			{ "size", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSizeEntity.LocalViewName, ENSizeEntity.AttributeDatabaseName)}, 
			{ "deviceresponsive", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDeviceResponsiveEntity.LocalViewName, ENDeviceResponsiveEntity.AttributeDatabaseName)}, 
			{ "guttersize", new Tuple<Func<long?, string, string>, Func<string, string>>(ENGutterSizeEntity.LocalViewName, ENGutterSizeEntity.AttributeDatabaseName)}, 
			{ "month", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMonthEntity.LocalViewName, ENMonthEntity.AttributeDatabaseName)}, 
			{ "datepickerlanguage", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDatePickerLanguageEntity.LocalViewName, ENDatePickerLanguageEntity.AttributeDatabaseName)}, 
			{ "deprecated_color", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDEPRECATED_ColorEntity.LocalViewName, ENDEPRECATED_ColorEntity.AttributeDatabaseName)}, 
			{ "orientation", new Tuple<Func<long?, string, string>, Func<string, string>>(ENOrientationEntity.LocalViewName, ENOrientationEntity.AttributeDatabaseName)}, 
			{ "datepickertimeformat", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDatePickerTimeFormatEntity.LocalViewName, ENDatePickerTimeFormatEntity.AttributeDatabaseName)}, 
			{ "accordionicontype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENAccordionIconTypeEntity.LocalViewName, ENAccordionIconTypeEntity.AttributeDatabaseName)}, 
			{ "direction", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDirectionEntity.LocalViewName, ENDirectionEntity.AttributeDatabaseName)}, 
			{ "breakcolumns", new Tuple<Func<long?, string, string>, Func<string, string>>(ENBreakColumnsEntity.LocalViewName, ENBreakColumnsEntity.AttributeDatabaseName)}, 
			{ "rangeslidertype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENRangeSliderTypeEntity.LocalViewName, ENRangeSliderTypeEntity.AttributeDatabaseName)}, 
			{ "shape", new Tuple<Func<long?, string, string>, Func<string, string>>(ENShapeEntity.LocalViewName, ENShapeEntity.AttributeDatabaseName)}, 
			{ "stackedcardsposition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENStackedCardsPositionEntity.LocalViewName, ENStackedCardsPositionEntity.AttributeDatabaseName)}, 
			{ "carouseldirection", new Tuple<Func<long?, string, string>, Func<string, string>>(ENCarouselDirectionEntity.LocalViewName, ENCarouselDirectionEntity.AttributeDatabaseName)}, 
			{ "rangesliderprovider", new Tuple<Func<long?, string, string>, Func<string, string>>(ENRangeSliderProviderEntity.LocalViewName, ENRangeSliderProviderEntity.AttributeDatabaseName)}, 
			{ "registeredcallbackevents", new Tuple<Func<long?, string, string>, Func<string, string>>(ENRegisteredCallbackEventsEntity.LocalViewName, ENRegisteredCallbackEventsEntity.AttributeDatabaseName)}, 
			{ "autoplay", new Tuple<Func<long?, string, string>, Func<string, string>>(ENAutoplayEntity.LocalViewName, ENAutoplayEntity.AttributeDatabaseName)}, 
			{ "position", new Tuple<Func<long?, string, string>, Func<string, string>>(ENPositionEntity.LocalViewName, ENPositionEntity.AttributeDatabaseName)}, 
			{ "identityprovider", new Tuple<Func<long?, string, string>, Func<string, string>>(ENIdentityProviderEntity.LocalViewName, ENIdentityProviderEntity.AttributeDatabaseName)}, 
			{ "trigger", new Tuple<Func<long?, string, string>, Func<string, string>>(ENTriggerEntity.LocalViewName, ENTriggerEntity.AttributeDatabaseName)}, 
			{ "space", new Tuple<Func<long?, string, string>, Func<string, string>>(ENSpaceEntity.LocalViewName, ENSpaceEntity.AttributeDatabaseName)}, 
			{ "alert", new Tuple<Func<long?, string, string>, Func<string, string>>(ENAlertEntity.LocalViewName, ENAlertEntity.AttributeDatabaseName)}, 
			{ "floatingposition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENFloatingPositionEntity.LocalViewName, ENFloatingPositionEntity.AttributeDatabaseName)}, 
			{ "booleantypes", new Tuple<Func<long?, string, string>, Func<string, string>>(ENBooleanTypesEntity.LocalViewName, ENBooleanTypesEntity.AttributeDatabaseName)}, 
			{ "menuaction", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMenuActionEntity.LocalViewName, ENMenuActionEntity.AttributeDatabaseName)}, 
			{ "accordioniconposition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENAccordionIconPositionEntity.LocalViewName, ENAccordionIconPositionEntity.AttributeDatabaseName)}, 
			{ "datepickercalendartype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDatePickerCalendarTypeEntity.LocalViewName, ENDatePickerCalendarTypeEntity.AttributeDatabaseName)}, 
			{ "logtype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENLogTypeEntity.LocalViewName, ENLogTypeEntity.AttributeDatabaseName)}, 
			{ "progresstype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProgressTypeEntity.LocalViewName, ENProgressTypeEntity.AttributeDatabaseName)}, 
			{ "messagestatus", new Tuple<Func<long?, string, string>, Func<string, string>>(ENMessageStatusEntity.LocalViewName, ENMessageStatusEntity.AttributeDatabaseName)}, 
			{ "scrollbarstyle", new Tuple<Func<long?, string, string>, Func<string, string>>(ENScrollbarStyleEntity.LocalViewName, ENScrollbarStyleEntity.AttributeDatabaseName)}, 
			{ "dropdownprovider", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDropdownProviderEntity.LocalViewName, ENDropdownProviderEntity.AttributeDatabaseName)}, 
			{ "color", new Tuple<Func<long?, string, string>, Func<string, string>>(ENColorEntity.LocalViewName, ENColorEntity.AttributeDatabaseName)}, 
			{ "columnbreak", new Tuple<Func<long?, string, string>, Func<string, string>>(ENColumnBreakEntity.LocalViewName, ENColumnBreakEntity.AttributeDatabaseName)}, 
			{ "dropdowntype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDropdownTypeEntity.LocalViewName, ENDropdownTypeEntity.AttributeDatabaseName)}, 
			{ "steps", new Tuple<Func<long?, string, string>, Func<string, string>>(ENStepsEntity.LocalViewName, ENStepsEntity.AttributeDatabaseName)}, 
			{ "datepickerprovider", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDatePickerProviderEntity.LocalViewName, ENDatePickerProviderEntity.AttributeDatabaseName)}, 
			{ "carouselnavigation", new Tuple<Func<long?, string, string>, Func<string, string>>(ENCarouselNavigationEntity.LocalViewName, ENCarouselNavigationEntity.AttributeDatabaseName)}, 
			{ "videostate", new Tuple<Func<long?, string, string>, Func<string, string>>(ENVideoStateEntity.LocalViewName, ENVideoStateEntity.AttributeDatabaseName)}, 
			{ "datepickerweekday", new Tuple<Func<long?, string, string>, Func<string, string>>(ENDatePickerWeekDayEntity.LocalViewName, ENDatePickerWeekDayEntity.AttributeDatabaseName)}
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

        private static readonly ObjectKey eSpaceKey = ObjectKey.Parse("8be17f2a-431c-4958-b894-c77b988a7271") ?? ObjectKey.Dummy;
        public ObjectKey ESpaceKey {
            get {
                return eSpaceKey;
            }
        }

        // The name of the eSpace, should be used for code generation purposes and identifiers.
        public string ESpaceName {
            get {
                return "OutSystemsUI";
            }
        }

        // The base URL path for the application, should be used for constructing URLs and path related stuff.
        public string ESpaceUrlBasePath {
            get {
                return "OutSystemsUI";
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
