using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// LogTypeRecord
public class JSONRC_6633adb48f346ff9147637b286666408 : AbstractRESTStructure<RC_6633adb48f346ff9147637b286666408> {
[JsonProperty("LogType")]
[JsonPropertyName("LogType")]
public ssOutSystemsMaps.RestRecords.JSONEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord AttrLogType;

public JSONRC_6633adb48f346ff9147637b286666408() { }

public JSONRC_6633adb48f346ff9147637b286666408 (RC_6633adb48f346ff9147637b286666408 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLogType = ConvertToRestWithoutDefaults(s.ssENLogType, new EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord.FromStructureDelegate(config));
  } else {
AttrLogType = ssOutSystemsMaps.RestRecords.JSONEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord.FromStructure(s.ssENLogType, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_6633adb48f346ff9147637b286666408, RC_6633adb48f346ff9147637b286666408> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_6633adb48f346ff9147637b286666408 s) => ToStructure(s, config);
}
public static RC_6633adb48f346ff9147637b286666408 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_6633adb48f346ff9147637b286666408 obj, IBehaviorsConfiguration config) { 
  RC_6633adb48f346ff9147637b286666408 s = new RC_6633adb48f346ff9147637b286666408();
  if(obj != null) {
  s.ssENLogType = ssOutSystemsMaps.RestRecords.JSONEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord.ToStructure(obj.AttrLogType, config);
  }
  return s;
}

public static Func<RC_6633adb48f346ff9147637b286666408, ssOutSystemsMaps.RestRecords.JSONRC_6633adb48f346ff9147637b286666408> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6633adb48f346ff9147637b286666408 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_6633adb48f346ff9147637b286666408 FromStructure(RC_6633adb48f346ff9147637b286666408 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_6633adb48f346ff9147637b286666408(s, config);
}

}


