using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TimePicker_InternalConfigRecord
public class JSONRC_8f31728044d1321864213488837bc67a : AbstractRESTStructure<RC_8f31728044d1321864213488837bc67a> {
[JsonProperty("TimePicker_InternalConfig")]
[JsonPropertyName("TimePicker_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_613242ff7dd22d356200cb1f89298a39Structure AttrTimePicker_InternalConfig;

public JSONRC_8f31728044d1321864213488837bc67a() { }

public JSONRC_8f31728044d1321864213488837bc67a (RC_8f31728044d1321864213488837bc67a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTimePicker_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTTimePicker_InternalConfig, new ST_613242ff7dd22d356200cb1f89298a39Structure(), ssOutSystemsUI.RestRecords.JSONST_613242ff7dd22d356200cb1f89298a39Structure.FromStructureDelegate(config));
  } else {
AttrTimePicker_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_613242ff7dd22d356200cb1f89298a39Structure.FromStructure(s.ssSTTimePicker_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_8f31728044d1321864213488837bc67a, RC_8f31728044d1321864213488837bc67a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_8f31728044d1321864213488837bc67a s) => ToStructure(s, config);
}
public static RC_8f31728044d1321864213488837bc67a ToStructure(ssOutSystemsUI.RestRecords.JSONRC_8f31728044d1321864213488837bc67a obj, IBehaviorsConfiguration config) { 
  RC_8f31728044d1321864213488837bc67a s = new RC_8f31728044d1321864213488837bc67a();
  if(obj != null) {
  s.ssSTTimePicker_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_613242ff7dd22d356200cb1f89298a39Structure.ToStructure(obj.AttrTimePicker_InternalConfig, config);
  }
  return s;
}

public static Func<RC_8f31728044d1321864213488837bc67a, ssOutSystemsUI.RestRecords.JSONRC_8f31728044d1321864213488837bc67a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f31728044d1321864213488837bc67a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_8f31728044d1321864213488837bc67a FromStructure(RC_8f31728044d1321864213488837bc67a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_8f31728044d1321864213488837bc67a(s, config);
}

}


