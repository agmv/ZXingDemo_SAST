using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_Shape_Configs
public class RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure : AbstractRESTStructure<ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure> {
[JsonProperty("Internal_to_provider_shape_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_4d96f69748c4f35fb433f7995d061407Structure AttrInternal_to_provider_shape_configs;

[JsonProperty("UniqueId")]
public string AttrUniqueId;

public RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure() { }

public RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure (ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_shape_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_shape_configs, new ST_4d96f69748c4f35fb433f7995d061407Structure(), ssOutSystemsMaps.RestRecords.RESTST_4d96f69748c4f35fb433f7995d061407Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_shape_configs = ssOutSystemsMaps.RestRecords.RESTST_4d96f69748c4f35fb433f7995d061407Structure.FromStructure(s.ssInternal_to_provider_shape_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure obj) { 
  ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure s = new ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure();
  if(obj != null) {
  s.ssInternal_to_provider_shape_configs = ssOutSystemsMaps.RestRecords.RESTST_4d96f69748c4f35fb433f7995d061407Structure.ToStructure(obj.AttrInternal_to_provider_shape_configs);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure, ssOutSystemsMaps.RestRecords.RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure FromStructure(ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure(s, config);
}

}


