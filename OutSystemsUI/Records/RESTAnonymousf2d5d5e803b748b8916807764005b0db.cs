using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// LogTypeRecord
public class RESTRC_cc83188402b0c2897ce694332899ab49 : AbstractRESTStructure<RC_cc83188402b0c2897ce694332899ab49> {
[JsonProperty("LogType")]
public ssOutSystemsUI.RestRecords.RESTEN_79dd905420a035342bdbafd506073863EntityRecord AttrLogType;

public RESTRC_cc83188402b0c2897ce694332899ab49() { }

public RESTRC_cc83188402b0c2897ce694332899ab49 (RC_cc83188402b0c2897ce694332899ab49 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLogType = ConvertToRestWithoutDefaults(s.ssENLogType, new EN_79dd905420a035342bdbafd506073863EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_79dd905420a035342bdbafd506073863EntityRecord.FromStructureDelegate(config));
  } else {
AttrLogType = ssOutSystemsUI.RestRecords.RESTEN_79dd905420a035342bdbafd506073863EntityRecord.FromStructure(s.ssENLogType, config);
  }
}

public static RC_cc83188402b0c2897ce694332899ab49 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_cc83188402b0c2897ce694332899ab49 obj) { 
  RC_cc83188402b0c2897ce694332899ab49 s = new RC_cc83188402b0c2897ce694332899ab49();
  if(obj != null) {
  s.ssENLogType = ssOutSystemsUI.RestRecords.RESTEN_79dd905420a035342bdbafd506073863EntityRecord.ToStructure(obj.AttrLogType);
  }
  return s;
}

public static Func<RC_cc83188402b0c2897ce694332899ab49, ssOutSystemsUI.RestRecords.RESTRC_cc83188402b0c2897ce694332899ab49> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cc83188402b0c2897ce694332899ab49 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_cc83188402b0c2897ce694332899ab49 FromStructure(RC_cc83188402b0c2897ce694332899ab49 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_cc83188402b0c2897ce694332899ab49(s, config);
}

}


