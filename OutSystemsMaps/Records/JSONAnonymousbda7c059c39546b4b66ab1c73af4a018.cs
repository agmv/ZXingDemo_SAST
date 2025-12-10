using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_fileLayer_configsRecord
public class JSONRC_9590e411027a378334a242a620d3f27e : AbstractRESTStructure<RC_9590e411027a378334a242a620d3f27e> {
[JsonProperty("Internal_to_provider_fileLayer_configs")]
[JsonPropertyName("Internal_to_provider_fileLayer_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure AttrInternal_to_provider_fileLayer_configs;

public JSONRC_9590e411027a378334a242a620d3f27e() { }

public JSONRC_9590e411027a378334a242a620d3f27e (RC_9590e411027a378334a242a620d3f27e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_fileLayer_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_fileLayer_configs, new ST_793e574f3ddb64f39831eacf8a4462b0Structure(), ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_fileLayer_configs = ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure.FromStructure(s.ssSTInternal_to_provider_fileLayer_configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_9590e411027a378334a242a620d3f27e, RC_9590e411027a378334a242a620d3f27e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_9590e411027a378334a242a620d3f27e s) => ToStructure(s, config);
}
public static RC_9590e411027a378334a242a620d3f27e ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_9590e411027a378334a242a620d3f27e obj, IBehaviorsConfiguration config) { 
  RC_9590e411027a378334a242a620d3f27e s = new RC_9590e411027a378334a242a620d3f27e();
  if(obj != null) {
  s.ssSTInternal_to_provider_fileLayer_configs = ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure.ToStructure(obj.AttrInternal_to_provider_fileLayer_configs, config);
  }
  return s;
}

public static Func<RC_9590e411027a378334a242a620d3f27e, ssOutSystemsMaps.RestRecords.JSONRC_9590e411027a378334a242a620d3f27e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9590e411027a378334a242a620d3f27e s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_9590e411027a378334a242a620d3f27e FromStructure(RC_9590e411027a378334a242a620d3f27e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_9590e411027a378334a242a620d3f27e(s, config);
}

}


