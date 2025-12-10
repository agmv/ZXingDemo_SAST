using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// LogType
public class RESTEN_79dd905420a035342bdbafd506073863EntityRecord : AbstractRESTStructure<EN_79dd905420a035342bdbafd506073863EntityRecord> {
[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_79dd905420a035342bdbafd506073863EntityRecord() { }

public RESTEN_79dd905420a035342bdbafd506073863EntityRecord (EN_79dd905420a035342bdbafd506073863EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_79dd905420a035342bdbafd506073863EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_79dd905420a035342bdbafd506073863EntityRecord obj) { 
  EN_79dd905420a035342bdbafd506073863EntityRecord s = new EN_79dd905420a035342bdbafd506073863EntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_79dd905420a035342bdbafd506073863EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_79dd905420a035342bdbafd506073863EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_79dd905420a035342bdbafd506073863EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_79dd905420a035342bdbafd506073863EntityRecord FromStructure(EN_79dd905420a035342bdbafd506073863EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_79dd905420a035342bdbafd506073863EntityRecord(s, config);
}

}


