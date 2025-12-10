using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawCircle_ConfigsRecord
public class JSONRC_6e989af6610cf33b5d07b40b7d0a9306 : AbstractRESTStructure<RC_6e989af6610cf33b5d07b40b7d0a9306> {
[JsonProperty("Internal_DrawCircle_Configs")]
[JsonPropertyName("Internal_DrawCircle_Configs")]
public ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure AttrInternal_DrawCircle_Configs;

public JSONRC_6e989af6610cf33b5d07b40b7d0a9306() { }

public JSONRC_6e989af6610cf33b5d07b40b7d0a9306 (RC_6e989af6610cf33b5d07b40b7d0a9306 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawCircle_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawCircle_Configs, new ST_5d8d0b250562ec29250400c2b0c3eb66Structure(), ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawCircle_Configs = ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure.FromStructure(s.ssSTInternal_DrawCircle_Configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_6e989af6610cf33b5d07b40b7d0a9306, RC_6e989af6610cf33b5d07b40b7d0a9306> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_6e989af6610cf33b5d07b40b7d0a9306 s) => ToStructure(s, config);
}
public static RC_6e989af6610cf33b5d07b40b7d0a9306 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_6e989af6610cf33b5d07b40b7d0a9306 obj, IBehaviorsConfiguration config) { 
  RC_6e989af6610cf33b5d07b40b7d0a9306 s = new RC_6e989af6610cf33b5d07b40b7d0a9306();
  if(obj != null) {
  s.ssSTInternal_DrawCircle_Configs = ssOutSystemsMaps.RestRecords.JSONST_5d8d0b250562ec29250400c2b0c3eb66Structure.ToStructure(obj.AttrInternal_DrawCircle_Configs, config);
  }
  return s;
}

public static Func<RC_6e989af6610cf33b5d07b40b7d0a9306, ssOutSystemsMaps.RestRecords.JSONRC_6e989af6610cf33b5d07b40b7d0a9306> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6e989af6610cf33b5d07b40b7d0a9306 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_6e989af6610cf33b5d07b40b7d0a9306 FromStructure(RC_6e989af6610cf33b5d07b40b7d0a9306 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_6e989af6610cf33b5d07b40b7d0a9306(s, config);
}

}


