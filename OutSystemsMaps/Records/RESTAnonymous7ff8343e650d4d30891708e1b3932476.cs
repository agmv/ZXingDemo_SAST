using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_HeatmapLayer_ConfigsRecord
public class RESTRC_2f373495341cd6d1bc0753ee5c713769 : AbstractRESTStructure<RC_2f373495341cd6d1bc0753ee5c713769> {
[JsonProperty("Internal_HeatmapLayer_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_f2c047cd8082950bd1961446a5ec1949Structure AttrInternal_HeatmapLayer_Configs;

public RESTRC_2f373495341cd6d1bc0753ee5c713769() { }

public RESTRC_2f373495341cd6d1bc0753ee5c713769 (RC_2f373495341cd6d1bc0753ee5c713769 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_HeatmapLayer_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_HeatmapLayer_Configs, new ST_f2c047cd8082950bd1961446a5ec1949Structure(), ssOutSystemsMaps.RestRecords.RESTST_f2c047cd8082950bd1961446a5ec1949Structure.FromStructureDelegate(config));
  } else {
AttrInternal_HeatmapLayer_Configs = ssOutSystemsMaps.RestRecords.RESTST_f2c047cd8082950bd1961446a5ec1949Structure.FromStructure(s.ssSTInternal_HeatmapLayer_Configs, config);
  }
}

public static RC_2f373495341cd6d1bc0753ee5c713769 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_2f373495341cd6d1bc0753ee5c713769 obj) { 
  RC_2f373495341cd6d1bc0753ee5c713769 s = new RC_2f373495341cd6d1bc0753ee5c713769();
  if(obj != null) {
  s.ssSTInternal_HeatmapLayer_Configs = ssOutSystemsMaps.RestRecords.RESTST_f2c047cd8082950bd1961446a5ec1949Structure.ToStructure(obj.AttrInternal_HeatmapLayer_Configs);
  }
  return s;
}

public static Func<RC_2f373495341cd6d1bc0753ee5c713769, ssOutSystemsMaps.RestRecords.RESTRC_2f373495341cd6d1bc0753ee5c713769> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2f373495341cd6d1bc0753ee5c713769 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_2f373495341cd6d1bc0753ee5c713769 FromStructure(RC_2f373495341cd6d1bc0753ee5c713769 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_2f373495341cd6d1bc0753ee5c713769(s, config);
}

}


