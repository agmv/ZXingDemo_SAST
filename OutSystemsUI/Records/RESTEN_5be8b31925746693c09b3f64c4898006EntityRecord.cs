using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Month
public class RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord : AbstractRESTStructure<EN_5be8b31925746693c09b3f64c4898006EntityRecord> {
[JsonProperty("Month")]
public string AttrMonth;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord() { }

public RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord (EN_5be8b31925746693c09b3f64c4898006EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonth = s.ssMonth;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrMonth = s.ssMonth;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_5be8b31925746693c09b3f64c4898006EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord obj) { 
  EN_5be8b31925746693c09b3f64c4898006EntityRecord s = new EN_5be8b31925746693c09b3f64c4898006EntityRecord();
  if(obj != null) {
  s.ssMonth = obj.AttrMonth == null ? "" : obj.AttrMonth;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_5be8b31925746693c09b3f64c4898006EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5be8b31925746693c09b3f64c4898006EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord FromStructure(EN_5be8b31925746693c09b3f64c4898006EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord(s, config);
}

}


