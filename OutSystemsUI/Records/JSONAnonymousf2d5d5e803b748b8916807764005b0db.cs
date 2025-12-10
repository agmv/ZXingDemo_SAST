using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// LogTypeRecord
public class JSONRC_cc83188402b0c2897ce694332899ab49 : AbstractRESTStructure<RC_cc83188402b0c2897ce694332899ab49> {
[JsonProperty("LogType")]
[JsonPropertyName("LogType")]
public ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord AttrLogType;

public JSONRC_cc83188402b0c2897ce694332899ab49() { }

public JSONRC_cc83188402b0c2897ce694332899ab49 (RC_cc83188402b0c2897ce694332899ab49 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLogType = ConvertToRestWithoutDefaults(s.ssENLogType, new EN_79dd905420a035342bdbafd506073863EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord.FromStructureDelegate(config));
  } else {
AttrLogType = ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord.FromStructure(s.ssENLogType, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_cc83188402b0c2897ce694332899ab49, RC_cc83188402b0c2897ce694332899ab49> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_cc83188402b0c2897ce694332899ab49 s) => ToStructure(s, config);
}
public static RC_cc83188402b0c2897ce694332899ab49 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_cc83188402b0c2897ce694332899ab49 obj, IBehaviorsConfiguration config) { 
  RC_cc83188402b0c2897ce694332899ab49 s = new RC_cc83188402b0c2897ce694332899ab49();
  if(obj != null) {
  s.ssENLogType = ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord.ToStructure(obj.AttrLogType, config);
  }
  return s;
}

public static Func<RC_cc83188402b0c2897ce694332899ab49, ssOutSystemsUI.RestRecords.JSONRC_cc83188402b0c2897ce694332899ab49> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cc83188402b0c2897ce694332899ab49 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_cc83188402b0c2897ce694332899ab49 FromStructure(RC_cc83188402b0c2897ce694332899ab49 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_cc83188402b0c2897ce694332899ab49(s, config);
}

}


