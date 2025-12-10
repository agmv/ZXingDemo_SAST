using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DeviceResponsive
public class JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord : AbstractRESTStructure<EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord> {
[JsonProperty("Type")]
[JsonPropertyName("Type")]
public string AttrType;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord() { }

public JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord (EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrType = s.ssType;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord, EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord s) => ToStructure(s, config);
}
public static EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord s = new EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord, ssOutSystemsUI.RestRecords.JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord FromStructure(EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord(s, config);
}

}


