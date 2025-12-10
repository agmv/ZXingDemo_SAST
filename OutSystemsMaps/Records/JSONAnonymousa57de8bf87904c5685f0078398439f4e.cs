using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawPolygon_ConfigsRecord
public class JSONRC_a7db230a655a3c54e1e9a992db69e805 : AbstractRESTStructure<RC_a7db230a655a3c54e1e9a992db69e805> {
[JsonProperty("Internal_DrawPolygon_Configs")]
[JsonPropertyName("Internal_DrawPolygon_Configs")]
public ssOutSystemsMaps.RestRecords.JSONST_707b1ead9a0d000606d8b9e0cca3c3f9Structure AttrInternal_DrawPolygon_Configs;

public JSONRC_a7db230a655a3c54e1e9a992db69e805() { }

public JSONRC_a7db230a655a3c54e1e9a992db69e805 (RC_a7db230a655a3c54e1e9a992db69e805 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawPolygon_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawPolygon_Configs, new ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure(), ssOutSystemsMaps.RestRecords.JSONST_707b1ead9a0d000606d8b9e0cca3c3f9Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawPolygon_Configs = ssOutSystemsMaps.RestRecords.JSONST_707b1ead9a0d000606d8b9e0cca3c3f9Structure.FromStructure(s.ssSTInternal_DrawPolygon_Configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_a7db230a655a3c54e1e9a992db69e805, RC_a7db230a655a3c54e1e9a992db69e805> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_a7db230a655a3c54e1e9a992db69e805 s) => ToStructure(s, config);
}
public static RC_a7db230a655a3c54e1e9a992db69e805 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_a7db230a655a3c54e1e9a992db69e805 obj, IBehaviorsConfiguration config) { 
  RC_a7db230a655a3c54e1e9a992db69e805 s = new RC_a7db230a655a3c54e1e9a992db69e805();
  if(obj != null) {
  s.ssSTInternal_DrawPolygon_Configs = ssOutSystemsMaps.RestRecords.JSONST_707b1ead9a0d000606d8b9e0cca3c3f9Structure.ToStructure(obj.AttrInternal_DrawPolygon_Configs, config);
  }
  return s;
}

public static Func<RC_a7db230a655a3c54e1e9a992db69e805, ssOutSystemsMaps.RestRecords.JSONRC_a7db230a655a3c54e1e9a992db69e805> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a7db230a655a3c54e1e9a992db69e805 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_a7db230a655a3c54e1e9a992db69e805 FromStructure(RC_a7db230a655a3c54e1e9a992db69e805 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_a7db230a655a3c54e1e9a992db69e805(s, config);
}

}


