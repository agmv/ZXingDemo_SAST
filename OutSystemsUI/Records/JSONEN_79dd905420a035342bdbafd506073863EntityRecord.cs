using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// LogType
public class JSONEN_79dd905420a035342bdbafd506073863EntityRecord : AbstractRESTStructure<EN_79dd905420a035342bdbafd506073863EntityRecord> {
[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

public JSONEN_79dd905420a035342bdbafd506073863EntityRecord() { }

public JSONEN_79dd905420a035342bdbafd506073863EntityRecord (EN_79dd905420a035342bdbafd506073863EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord, EN_79dd905420a035342bdbafd506073863EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord s) => ToStructure(s, config);
}
public static EN_79dd905420a035342bdbafd506073863EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_79dd905420a035342bdbafd506073863EntityRecord s = new EN_79dd905420a035342bdbafd506073863EntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_79dd905420a035342bdbafd506073863EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_79dd905420a035342bdbafd506073863EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord FromStructure(EN_79dd905420a035342bdbafd506073863EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_79dd905420a035342bdbafd506073863EntityRecord(s, config);
}

}


