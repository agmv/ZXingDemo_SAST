using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// StyleRecord
public class RESTRC_97843bcb52146db1681dfc816cff70a0 : AbstractRESTStructure<RC_97843bcb52146db1681dfc816cff70a0> {
[JsonProperty("Style")]
public ssZXingLibDemo.RestRecords.RESTEN_e7686de199fbd20281899419f0b6ff11EntityRecord AttrStyle;

public RESTRC_97843bcb52146db1681dfc816cff70a0() { }

public RESTRC_97843bcb52146db1681dfc816cff70a0 (RC_97843bcb52146db1681dfc816cff70a0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStyle = ConvertToRestWithoutDefaults(s.ssENStyle, new EN_e7686de199fbd20281899419f0b6ff11EntityRecord(), ssZXingLibDemo.RestRecords.RESTEN_e7686de199fbd20281899419f0b6ff11EntityRecord.FromStructureDelegate(config));
  } else {
AttrStyle = ssZXingLibDemo.RestRecords.RESTEN_e7686de199fbd20281899419f0b6ff11EntityRecord.FromStructure(s.ssENStyle, config);
  }
}

public static RC_97843bcb52146db1681dfc816cff70a0 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_97843bcb52146db1681dfc816cff70a0 obj) { 
  RC_97843bcb52146db1681dfc816cff70a0 s = new RC_97843bcb52146db1681dfc816cff70a0();
  if(obj != null) {
  s.ssENStyle = ssZXingLibDemo.RestRecords.RESTEN_e7686de199fbd20281899419f0b6ff11EntityRecord.ToStructure(obj.AttrStyle);
  }
  return s;
}

public static Func<RC_97843bcb52146db1681dfc816cff70a0, ssZXingLibDemo.RestRecords.RESTRC_97843bcb52146db1681dfc816cff70a0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_97843bcb52146db1681dfc816cff70a0 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_97843bcb52146db1681dfc816cff70a0 FromStructure(RC_97843bcb52146db1681dfc816cff70a0 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_97843bcb52146db1681dfc816cff70a0(s, config);
}

}


