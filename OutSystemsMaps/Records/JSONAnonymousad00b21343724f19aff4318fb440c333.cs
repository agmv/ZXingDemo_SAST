using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_drawingTools_configsRecord
public class JSONRC_86c442a46c095f494cab514734ffc71c : AbstractRESTStructure<RC_86c442a46c095f494cab514734ffc71c> {
[JsonProperty("Internal_to_provider_drawingTools_configs")]
[JsonPropertyName("Internal_to_provider_drawingTools_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_3f16cd459ccd861deffd4483bc1bbac3Structure AttrInternal_to_provider_drawingTools_configs;

public JSONRC_86c442a46c095f494cab514734ffc71c() { }

public JSONRC_86c442a46c095f494cab514734ffc71c (RC_86c442a46c095f494cab514734ffc71c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_drawingTools_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_drawingTools_configs, new ST_3f16cd459ccd861deffd4483bc1bbac3Structure(), ssOutSystemsMaps.RestRecords.JSONST_3f16cd459ccd861deffd4483bc1bbac3Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_drawingTools_configs = ssOutSystemsMaps.RestRecords.JSONST_3f16cd459ccd861deffd4483bc1bbac3Structure.FromStructure(s.ssSTInternal_to_provider_drawingTools_configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_86c442a46c095f494cab514734ffc71c, RC_86c442a46c095f494cab514734ffc71c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_86c442a46c095f494cab514734ffc71c s) => ToStructure(s, config);
}
public static RC_86c442a46c095f494cab514734ffc71c ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_86c442a46c095f494cab514734ffc71c obj, IBehaviorsConfiguration config) { 
  RC_86c442a46c095f494cab514734ffc71c s = new RC_86c442a46c095f494cab514734ffc71c();
  if(obj != null) {
  s.ssSTInternal_to_provider_drawingTools_configs = ssOutSystemsMaps.RestRecords.JSONST_3f16cd459ccd861deffd4483bc1bbac3Structure.ToStructure(obj.AttrInternal_to_provider_drawingTools_configs, config);
  }
  return s;
}

public static Func<RC_86c442a46c095f494cab514734ffc71c, ssOutSystemsMaps.RestRecords.JSONRC_86c442a46c095f494cab514734ffc71c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_86c442a46c095f494cab514734ffc71c s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_86c442a46c095f494cab514734ffc71c FromStructure(RC_86c442a46c095f494cab514734ffc71c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_86c442a46c095f494cab514734ffc71c(s, config);
}

}


