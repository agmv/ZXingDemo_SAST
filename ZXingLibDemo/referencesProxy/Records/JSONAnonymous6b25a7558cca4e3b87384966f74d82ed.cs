using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// StyleRecord
public class JSONRC_97843bcb52146db1681dfc816cff70a0 : AbstractRESTStructure<RC_97843bcb52146db1681dfc816cff70a0> {
[JsonProperty("Style")]
[JsonPropertyName("Style")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord AttrStyle;

public JSONRC_97843bcb52146db1681dfc816cff70a0() { }

public JSONRC_97843bcb52146db1681dfc816cff70a0 (RC_97843bcb52146db1681dfc816cff70a0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStyle = ConvertToRestWithoutDefaults(s.ssENStyle, new EN_e7686de199fbd20281899419f0b6ff11EntityRecord(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord.FromStructureDelegate(config));
  } else {
AttrStyle = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord.FromStructure(s.ssENStyle, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_97843bcb52146db1681dfc816cff70a0, RC_97843bcb52146db1681dfc816cff70a0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_97843bcb52146db1681dfc816cff70a0 s) => ToStructure(s, config);
}
public static RC_97843bcb52146db1681dfc816cff70a0 ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_97843bcb52146db1681dfc816cff70a0 obj, IBehaviorsConfiguration config) { 
  RC_97843bcb52146db1681dfc816cff70a0 s = new RC_97843bcb52146db1681dfc816cff70a0();
  if(obj != null) {
  s.ssENStyle = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord.ToStructure(obj.AttrStyle, config);
  }
  return s;
}

public static Func<RC_97843bcb52146db1681dfc816cff70a0, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_97843bcb52146db1681dfc816cff70a0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_97843bcb52146db1681dfc816cff70a0 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_97843bcb52146db1681dfc816cff70a0 FromStructure(RC_97843bcb52146db1681dfc816cff70a0 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_97843bcb52146db1681dfc816cff70a0(s, config);
}

}


