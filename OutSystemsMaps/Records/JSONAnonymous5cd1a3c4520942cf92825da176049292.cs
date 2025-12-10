using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawMarker_ConfigsRecord
public class JSONRC_a9d3f6b226a37f22bb219f2bf72cf852 : AbstractRESTStructure<RC_a9d3f6b226a37f22bb219f2bf72cf852> {
[JsonProperty("Internal_DrawMarker_Configs")]
[JsonPropertyName("Internal_DrawMarker_Configs")]
public ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure AttrInternal_DrawMarker_Configs;

public JSONRC_a9d3f6b226a37f22bb219f2bf72cf852() { }

public JSONRC_a9d3f6b226a37f22bb219f2bf72cf852 (RC_a9d3f6b226a37f22bb219f2bf72cf852 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawMarker_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawMarker_Configs, new ST_60018fad8b9768f5644ffadf96040a85Structure(), ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawMarker_Configs = ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure.FromStructure(s.ssSTInternal_DrawMarker_Configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_a9d3f6b226a37f22bb219f2bf72cf852, RC_a9d3f6b226a37f22bb219f2bf72cf852> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_a9d3f6b226a37f22bb219f2bf72cf852 s) => ToStructure(s, config);
}
public static RC_a9d3f6b226a37f22bb219f2bf72cf852 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_a9d3f6b226a37f22bb219f2bf72cf852 obj, IBehaviorsConfiguration config) { 
  RC_a9d3f6b226a37f22bb219f2bf72cf852 s = new RC_a9d3f6b226a37f22bb219f2bf72cf852();
  if(obj != null) {
  s.ssSTInternal_DrawMarker_Configs = ssOutSystemsMaps.RestRecords.JSONST_60018fad8b9768f5644ffadf96040a85Structure.ToStructure(obj.AttrInternal_DrawMarker_Configs, config);
  }
  return s;
}

public static Func<RC_a9d3f6b226a37f22bb219f2bf72cf852, ssOutSystemsMaps.RestRecords.JSONRC_a9d3f6b226a37f22bb219f2bf72cf852> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a9d3f6b226a37f22bb219f2bf72cf852 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_a9d3f6b226a37f22bb219f2bf72cf852 FromStructure(RC_a9d3f6b226a37f22bb219f2bf72cf852 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_a9d3f6b226a37f22bb219f2bf72cf852(s, config);
}

}


