using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// NoUiSliderConfigsRecord
public class JSONRC_1310596a4ac4ae2b0319b38dd9472639 : AbstractRESTStructure<RC_1310596a4ac4ae2b0319b38dd9472639> {
[JsonProperty("NoUiSliderConfigs")]
[JsonPropertyName("NoUiSliderConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure AttrNoUiSliderConfigs;

public JSONRC_1310596a4ac4ae2b0319b38dd9472639() { }

public JSONRC_1310596a4ac4ae2b0319b38dd9472639 (RC_1310596a4ac4ae2b0319b38dd9472639 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNoUiSliderConfigs = ConvertToRestWithoutDefaults(s.ssSTNoUiSliderConfigs, new ST_af087c80f6ec63e7de4ff7926f7da7d0Structure(), ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure.FromStructureDelegate(config));
  } else {
AttrNoUiSliderConfigs = ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure.FromStructure(s.ssSTNoUiSliderConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_1310596a4ac4ae2b0319b38dd9472639, RC_1310596a4ac4ae2b0319b38dd9472639> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_1310596a4ac4ae2b0319b38dd9472639 s) => ToStructure(s, config);
}
public static RC_1310596a4ac4ae2b0319b38dd9472639 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_1310596a4ac4ae2b0319b38dd9472639 obj, IBehaviorsConfiguration config) { 
  RC_1310596a4ac4ae2b0319b38dd9472639 s = new RC_1310596a4ac4ae2b0319b38dd9472639();
  if(obj != null) {
  s.ssSTNoUiSliderConfigs = ssOutSystemsUI.RestRecords.JSONST_af087c80f6ec63e7de4ff7926f7da7d0Structure.ToStructure(obj.AttrNoUiSliderConfigs, config);
  }
  return s;
}

public static Func<RC_1310596a4ac4ae2b0319b38dd9472639, ssOutSystemsUI.RestRecords.JSONRC_1310596a4ac4ae2b0319b38dd9472639> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1310596a4ac4ae2b0319b38dd9472639 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_1310596a4ac4ae2b0319b38dd9472639 FromStructure(RC_1310596a4ac4ae2b0319b38dd9472639 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_1310596a4ac4ae2b0319b38dd9472639(s, config);
}

}


