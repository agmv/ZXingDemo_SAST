using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Zoom
public class JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord : AbstractRESTStructure<EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Zoom")]
[JsonPropertyName("Zoom")]
public int? AttrZoom;

public JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord() { }

public JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord (EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
AttrZoom = (int?) s.ssZoom;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrZoom = (int?) s.ssZoom;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord, EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord s) => ToStructure(s, config);
}
public static EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord ToStructure(ssZXingLibDemo.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord s = new EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssZoom = obj.AttrZoom == null ? 0 : obj.AttrZoom.Value;
  }
  return s;
}

public static Func<EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord, ssZXingLibDemo.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord FromStructure(EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord(s, config);
}

}


