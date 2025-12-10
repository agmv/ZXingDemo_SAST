using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FloatingPositionRecord
public class RESTRC_95c473136722ba7379611f73a3471de3 : AbstractRESTStructure<RC_95c473136722ba7379611f73a3471de3> {
[JsonProperty("FloatingPosition")]
public ssOutSystemsUI.RestRecords.RESTEN_4f86046673de081f9834eb306850ab22EntityRecord AttrFloatingPosition;

public RESTRC_95c473136722ba7379611f73a3471de3() { }

public RESTRC_95c473136722ba7379611f73a3471de3 (RC_95c473136722ba7379611f73a3471de3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFloatingPosition = ConvertToRestWithoutDefaults(s.ssENFloatingPosition, new EN_4f86046673de081f9834eb306850ab22EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_4f86046673de081f9834eb306850ab22EntityRecord.FromStructureDelegate(config));
  } else {
AttrFloatingPosition = ssOutSystemsUI.RestRecords.RESTEN_4f86046673de081f9834eb306850ab22EntityRecord.FromStructure(s.ssENFloatingPosition, config);
  }
}

public static RC_95c473136722ba7379611f73a3471de3 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_95c473136722ba7379611f73a3471de3 obj) { 
  RC_95c473136722ba7379611f73a3471de3 s = new RC_95c473136722ba7379611f73a3471de3();
  if(obj != null) {
  s.ssENFloatingPosition = ssOutSystemsUI.RestRecords.RESTEN_4f86046673de081f9834eb306850ab22EntityRecord.ToStructure(obj.AttrFloatingPosition);
  }
  return s;
}

public static Func<RC_95c473136722ba7379611f73a3471de3, ssOutSystemsUI.RestRecords.RESTRC_95c473136722ba7379611f73a3471de3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_95c473136722ba7379611f73a3471de3 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_95c473136722ba7379611f73a3471de3 FromStructure(RC_95c473136722ba7379611f73a3471de3 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_95c473136722ba7379611f73a3471de3(s, config);
}

}


