using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawMarker_Configs
public class JSONST_60018fad8b9768f5644ffadf96040a85Structure : AbstractRESTStructure<ST_60018fad8b9768f5644ffadf96040a85Structure> {
[JsonProperty("Internal_to_provider_tools_configs")]
[JsonPropertyName("Internal_to_provider_tools_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_f121435b3edb481ee03ab7ef58e5b805Structure AttrInternal_to_provider_tools_configs;

[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

public JSONST_60018fad8b9768f5644ffadf96040a85Structure() { }

public JSONST_60018fad8b9768f5644ffadf96040a85Structure (ST_60018fad8b9768f5644ffadf96040a85Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_tools_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_tools_configs, new ST_f121435b3edb481ee03ab7ef58e5b805Structure(), ssOutSystemsMaps.RestRecords.JSONST_f121435b3edb481ee03ab7ef58e5b805Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.JSONST_f121435b3edb481ee03ab7ef58e5b805Structure.FromStructure(s.ssInternal_to_provider_tools_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure, ST_60018fad8b9768f5644ffadf96040a85Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure s) => ToStructure(s, config);
}
public static ST_60018fad8b9768f5644ffadf96040a85Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure obj, IBehaviorsConfiguration config) { 
  ST_60018fad8b9768f5644ffadf96040a85Structure s = new ST_60018fad8b9768f5644ffadf96040a85Structure();
  if(obj != null) {
  s.ssInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.JSONST_f121435b3edb481ee03ab7ef58e5b805Structure.ToStructure(obj.AttrInternal_to_provider_tools_configs, config);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_60018fad8b9768f5644ffadf96040a85Structure, ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_60018fad8b9768f5644ffadf96040a85Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure FromStructure(ST_60018fad8b9768f5644ffadf96040a85Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure(s, config);
}

}


