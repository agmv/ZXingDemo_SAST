using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawPolyline_ConfigsRecord
public class RESTRC_ac174f96b960b9152d73b4583f3f4d43 : AbstractRESTStructure<RC_ac174f96b960b9152d73b4583f3f4d43> {
[JsonProperty("Internal_DrawPolyline_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure AttrInternal_DrawPolyline_Configs;

public RESTRC_ac174f96b960b9152d73b4583f3f4d43() { }

public RESTRC_ac174f96b960b9152d73b4583f3f4d43 (RC_ac174f96b960b9152d73b4583f3f4d43 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawPolyline_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawPolyline_Configs, new ST_5223ca706bfb3de574fb0b39ebba3fb6Structure(), ssOutSystemsMaps.RestRecords.RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawPolyline_Configs = ssOutSystemsMaps.RestRecords.RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure.FromStructure(s.ssSTInternal_DrawPolyline_Configs, config);
  }
}

public static RC_ac174f96b960b9152d73b4583f3f4d43 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_ac174f96b960b9152d73b4583f3f4d43 obj) { 
  RC_ac174f96b960b9152d73b4583f3f4d43 s = new RC_ac174f96b960b9152d73b4583f3f4d43();
  if(obj != null) {
  s.ssSTInternal_DrawPolyline_Configs = ssOutSystemsMaps.RestRecords.RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure.ToStructure(obj.AttrInternal_DrawPolyline_Configs);
  }
  return s;
}

public static Func<RC_ac174f96b960b9152d73b4583f3f4d43, ssOutSystemsMaps.RestRecords.RESTRC_ac174f96b960b9152d73b4583f3f4d43> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ac174f96b960b9152d73b4583f3f4d43 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_ac174f96b960b9152d73b4583f3f4d43 FromStructure(RC_ac174f96b960b9152d73b4583f3f4d43 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_ac174f96b960b9152d73b4583f3f4d43(s, config);
}

}


