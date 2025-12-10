using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_Configs
public class RESTST_78d3133d124713193d703c2644ecd39bStructure : AbstractRESTStructure<ST_78d3133d124713193d703c2644ecd39bStructure> {
[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("Height")]
public string AttrHeight;

[JsonProperty("Internal_to_provider_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure AttrInternal_to_provider_configs;

[JsonProperty("StaticMapURL")]
public string AttrStaticMapURL;

[JsonProperty("UniqueId")]
public string AttrUniqueId;

public RESTST_78d3133d124713193d703c2644ecd39bStructure() { }

public RESTST_78d3133d124713193d703c2644ecd39bStructure (ST_78d3133d124713193d703c2644ecd39bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
AttrHeight = ConvertToRestWithoutDefaults(s.ssHeight, "");
AttrInternal_to_provider_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_configs, new ST_5baae74ed57e3bb61180aff1dadec4e1Structure(), ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure.FromStructureDelegate(config));
AttrStaticMapURL = ConvertToRestWithoutDefaults(s.ssStaticMapURL, "");
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrExtendedClass = s.ssExtendedClass;
AttrHeight = s.ssHeight;
AttrInternal_to_provider_configs = ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure.FromStructure(s.ssInternal_to_provider_configs, config);
AttrStaticMapURL = s.ssStaticMapURL;
AttrUniqueId = s.ssUniqueId;
  }
}

public static ST_78d3133d124713193d703c2644ecd39bStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure obj) { 
  ST_78d3133d124713193d703c2644ecd39bStructure s = new ST_78d3133d124713193d703c2644ecd39bStructure();
  if(obj != null) {
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssHeight = obj.AttrHeight == null ? "" : obj.AttrHeight;
  s.ssInternal_to_provider_configs = ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure.ToStructure(obj.AttrInternal_to_provider_configs);
  s.ssStaticMapURL = obj.AttrStaticMapURL == null ? "" : obj.AttrStaticMapURL;
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_78d3133d124713193d703c2644ecd39bStructure, ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_78d3133d124713193d703c2644ecd39bStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure FromStructure(ST_78d3133d124713193d703c2644ecd39bStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure(s, config);
}

}


