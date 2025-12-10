using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawPolyline_ConfigsRecord
public class JSONRC_ac174f96b960b9152d73b4583f3f4d43 : AbstractRESTStructure<RC_ac174f96b960b9152d73b4583f3f4d43> {
[JsonProperty("Internal_DrawPolyline_Configs")]
[JsonPropertyName("Internal_DrawPolyline_Configs")]
public ssOutSystemsMaps.RestRecords.JSONST_5223ca706bfb3de574fb0b39ebba3fb6Structure AttrInternal_DrawPolyline_Configs;

public JSONRC_ac174f96b960b9152d73b4583f3f4d43() { }

public JSONRC_ac174f96b960b9152d73b4583f3f4d43 (RC_ac174f96b960b9152d73b4583f3f4d43 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawPolyline_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawPolyline_Configs, new ST_5223ca706bfb3de574fb0b39ebba3fb6Structure(), ssOutSystemsMaps.RestRecords.JSONST_5223ca706bfb3de574fb0b39ebba3fb6Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawPolyline_Configs = ssOutSystemsMaps.RestRecords.JSONST_5223ca706bfb3de574fb0b39ebba3fb6Structure.FromStructure(s.ssSTInternal_DrawPolyline_Configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_ac174f96b960b9152d73b4583f3f4d43, RC_ac174f96b960b9152d73b4583f3f4d43> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_ac174f96b960b9152d73b4583f3f4d43 s) => ToStructure(s, config);
}
public static RC_ac174f96b960b9152d73b4583f3f4d43 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_ac174f96b960b9152d73b4583f3f4d43 obj, IBehaviorsConfiguration config) { 
  RC_ac174f96b960b9152d73b4583f3f4d43 s = new RC_ac174f96b960b9152d73b4583f3f4d43();
  if(obj != null) {
  s.ssSTInternal_DrawPolyline_Configs = ssOutSystemsMaps.RestRecords.JSONST_5223ca706bfb3de574fb0b39ebba3fb6Structure.ToStructure(obj.AttrInternal_DrawPolyline_Configs, config);
  }
  return s;
}

public static Func<RC_ac174f96b960b9152d73b4583f3f4d43, ssOutSystemsMaps.RestRecords.JSONRC_ac174f96b960b9152d73b4583f3f4d43> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ac174f96b960b9152d73b4583f3f4d43 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_ac174f96b960b9152d73b4583f3f4d43 FromStructure(RC_ac174f96b960b9152d73b4583f3f4d43 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_ac174f96b960b9152d73b4583f3f4d43(s, config);
}

}


