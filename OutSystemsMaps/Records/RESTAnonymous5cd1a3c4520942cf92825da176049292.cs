using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawMarker_ConfigsRecord
public class RESTRC_a9d3f6b226a37f22bb219f2bf72cf852 : AbstractRESTStructure<RC_a9d3f6b226a37f22bb219f2bf72cf852> {
[JsonProperty("Internal_DrawMarker_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_60018fad8b9768f5644ffadf96040a85Structure AttrInternal_DrawMarker_Configs;

public RESTRC_a9d3f6b226a37f22bb219f2bf72cf852() { }

public RESTRC_a9d3f6b226a37f22bb219f2bf72cf852 (RC_a9d3f6b226a37f22bb219f2bf72cf852 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawMarker_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawMarker_Configs, new ST_60018fad8b9768f5644ffadf96040a85Structure(), ssOutSystemsMaps.RestRecords.RESTST_60018fad8b9768f5644ffadf96040a85Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawMarker_Configs = ssOutSystemsMaps.RestRecords.RESTST_60018fad8b9768f5644ffadf96040a85Structure.FromStructure(s.ssSTInternal_DrawMarker_Configs, config);
  }
}

public static RC_a9d3f6b226a37f22bb219f2bf72cf852 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_a9d3f6b226a37f22bb219f2bf72cf852 obj) { 
  RC_a9d3f6b226a37f22bb219f2bf72cf852 s = new RC_a9d3f6b226a37f22bb219f2bf72cf852();
  if(obj != null) {
  s.ssSTInternal_DrawMarker_Configs = ssOutSystemsMaps.RestRecords.RESTST_60018fad8b9768f5644ffadf96040a85Structure.ToStructure(obj.AttrInternal_DrawMarker_Configs);
  }
  return s;
}

public static Func<RC_a9d3f6b226a37f22bb219f2bf72cf852, ssOutSystemsMaps.RestRecords.RESTRC_a9d3f6b226a37f22bb219f2bf72cf852> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a9d3f6b226a37f22bb219f2bf72cf852 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_a9d3f6b226a37f22bb219f2bf72cf852 FromStructure(RC_a9d3f6b226a37f22bb219f2bf72cf852 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_a9d3f6b226a37f22bb219f2bf72cf852(s, config);
}

}


