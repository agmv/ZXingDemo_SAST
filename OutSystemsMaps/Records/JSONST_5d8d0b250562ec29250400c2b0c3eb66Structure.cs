using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawCircle_Configs
public class JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure : AbstractRESTStructure<ST_5d8d0b250562ec29250400c2b0c3eb66Structure> {
[JsonProperty("Internal_to_provider_tools_configs")]
[JsonPropertyName("Internal_to_provider_tools_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_d25262c67f1be04c1df274811b8c7ee4Structure AttrInternal_to_provider_tools_configs;

[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

public JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure() { }

public JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure (ST_5d8d0b250562ec29250400c2b0c3eb66Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_tools_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_tools_configs, new ST_d25262c67f1be04c1df274811b8c7ee4Structure(), ssOutSystemsMaps.RestRecords.JSONST_d25262c67f1be04c1df274811b8c7ee4Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.JSONST_d25262c67f1be04c1df274811b8c7ee4Structure.FromStructure(s.ssInternal_to_provider_tools_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure, ST_5d8d0b250562ec29250400c2b0c3eb66Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure s) => ToStructure(s, config);
}
public static ST_5d8d0b250562ec29250400c2b0c3eb66Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure obj, IBehaviorsConfiguration config) { 
  ST_5d8d0b250562ec29250400c2b0c3eb66Structure s = new ST_5d8d0b250562ec29250400c2b0c3eb66Structure();
  if(obj != null) {
  s.ssInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.JSONST_d25262c67f1be04c1df274811b8c7ee4Structure.ToStructure(obj.AttrInternal_to_provider_tools_configs, config);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_5d8d0b250562ec29250400c2b0c3eb66Structure, ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5d8d0b250562ec29250400c2b0c3eb66Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure FromStructure(ST_5d8d0b250562ec29250400c2b0c3eb66Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure(s, config);
}

}


