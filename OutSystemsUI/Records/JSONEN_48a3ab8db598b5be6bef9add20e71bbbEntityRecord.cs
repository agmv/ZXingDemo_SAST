using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// GutterSize
public class JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord : AbstractRESTStructure<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> {
[JsonProperty("GutterSize")]
[JsonPropertyName("GutterSize")]
public string AttrGutterSize;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

public JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord() { }

public JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGutterSize = s.ssGutterSize;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrGutterSize = s.ssGutterSize;
AttrOrder = (int?) s.ssOrder;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord, EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s) => ToStructure(s, config);
}
public static EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s = new EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord();
  if(obj != null) {
  s.ssGutterSize = obj.AttrGutterSize == null ? "" : obj.AttrGutterSize;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord, ssOutSystemsUI.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord FromStructure(EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord(s, config);
}

}


