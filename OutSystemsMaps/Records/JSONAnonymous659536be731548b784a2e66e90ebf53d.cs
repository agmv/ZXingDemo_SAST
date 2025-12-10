using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal__Marker_ConfigsRecord
public class JSONRC_7f3fab599cac29adb40d23996cbe5a3b : AbstractRESTStructure<RC_7f3fab599cac29adb40d23996cbe5a3b> {
[JsonProperty("Internal__Marker_Configs")]
[JsonPropertyName("Internal__Marker_Configs")]
public ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure AttrInternal__Marker_Configs;

public JSONRC_7f3fab599cac29adb40d23996cbe5a3b() { }

public JSONRC_7f3fab599cac29adb40d23996cbe5a3b (RC_7f3fab599cac29adb40d23996cbe5a3b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal__Marker_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal__Marker_Configs, new ST_3d593ae1aad35ac58e1616049bb8da2cStructure(), ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure.FromStructureDelegate(config));
  } else {
AttrInternal__Marker_Configs = ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure.FromStructure(s.ssSTInternal__Marker_Configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_7f3fab599cac29adb40d23996cbe5a3b, RC_7f3fab599cac29adb40d23996cbe5a3b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_7f3fab599cac29adb40d23996cbe5a3b s) => ToStructure(s, config);
}
public static RC_7f3fab599cac29adb40d23996cbe5a3b ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_7f3fab599cac29adb40d23996cbe5a3b obj, IBehaviorsConfiguration config) { 
  RC_7f3fab599cac29adb40d23996cbe5a3b s = new RC_7f3fab599cac29adb40d23996cbe5a3b();
  if(obj != null) {
  s.ssSTInternal__Marker_Configs = ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure.ToStructure(obj.AttrInternal__Marker_Configs, config);
  }
  return s;
}

public static Func<RC_7f3fab599cac29adb40d23996cbe5a3b, ssOutSystemsMaps.RestRecords.JSONRC_7f3fab599cac29adb40d23996cbe5a3b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7f3fab599cac29adb40d23996cbe5a3b s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_7f3fab599cac29adb40d23996cbe5a3b FromStructure(RC_7f3fab599cac29adb40d23996cbe5a3b s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_7f3fab599cac29adb40d23996cbe5a3b(s, config);
}

}


