using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// Style
public class JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord : AbstractRESTStructure<EN_e7686de199fbd20281899419f0b6ff11EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Style")]
[JsonPropertyName("Style")]
public string AttrStyle;

[JsonProperty("URLStyle")]
[JsonPropertyName("URLStyle")]
public string AttrURLStyle;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord() { }

public JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord (EN_e7686de199fbd20281899419f0b6ff11EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrStyle = ConvertToRestWithoutDefaults(s.ssStyle, "");
AttrURLStyle = ConvertToRestWithoutDefaults(s.ssURLStyle, "");
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrStyle = s.ssStyle;
AttrURLStyle = s.ssURLStyle;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord, EN_e7686de199fbd20281899419f0b6ff11EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord s) => ToStructure(s, config);
}
public static EN_e7686de199fbd20281899419f0b6ff11EntityRecord ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_e7686de199fbd20281899419f0b6ff11EntityRecord s = new EN_e7686de199fbd20281899419f0b6ff11EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssStyle = obj.AttrStyle == null ? "" : obj.AttrStyle;
  s.ssURLStyle = obj.AttrURLStyle == null ? "" : obj.AttrURLStyle;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_e7686de199fbd20281899419f0b6ff11EntityRecord, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e7686de199fbd20281899419f0b6ff11EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord FromStructure(EN_e7686de199fbd20281899419f0b6ff11EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_e7686de199fbd20281899419f0b6ff11EntityRecord(s, config);
}

}


