using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawCircle_ConfigsRecord
public class RESTRC_6e989af6610cf33b5d07b40b7d0a9306 : AbstractRESTStructure<RC_6e989af6610cf33b5d07b40b7d0a9306> {
[JsonProperty("Internal_DrawCircle_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_5d8d0b250562ec29250400c2b0c3eb66Structure AttrInternal_DrawCircle_Configs;

public RESTRC_6e989af6610cf33b5d07b40b7d0a9306() { }

public RESTRC_6e989af6610cf33b5d07b40b7d0a9306 (RC_6e989af6610cf33b5d07b40b7d0a9306 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawCircle_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawCircle_Configs, new ST_5d8d0b250562ec29250400c2b0c3eb66Structure(), ssOutSystemsMaps.RestRecords.RESTST_5d8d0b250562ec29250400c2b0c3eb66Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawCircle_Configs = ssOutSystemsMaps.RestRecords.RESTST_5d8d0b250562ec29250400c2b0c3eb66Structure.FromStructure(s.ssSTInternal_DrawCircle_Configs, config);
  }
}

public static RC_6e989af6610cf33b5d07b40b7d0a9306 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_6e989af6610cf33b5d07b40b7d0a9306 obj) { 
  RC_6e989af6610cf33b5d07b40b7d0a9306 s = new RC_6e989af6610cf33b5d07b40b7d0a9306();
  if(obj != null) {
  s.ssSTInternal_DrawCircle_Configs = ssOutSystemsMaps.RestRecords.RESTST_5d8d0b250562ec29250400c2b0c3eb66Structure.ToStructure(obj.AttrInternal_DrawCircle_Configs);
  }
  return s;
}

public static Func<RC_6e989af6610cf33b5d07b40b7d0a9306, ssOutSystemsMaps.RestRecords.RESTRC_6e989af6610cf33b5d07b40b7d0a9306> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6e989af6610cf33b5d07b40b7d0a9306 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_6e989af6610cf33b5d07b40b7d0a9306 FromStructure(RC_6e989af6610cf33b5d07b40b7d0a9306 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_6e989af6610cf33b5d07b40b7d0a9306(s, config);
}

}


