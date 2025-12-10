using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Color
public class RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord : AbstractRESTStructure<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> {
[JsonProperty("Color")]
public string AttrColor;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord() { }

public RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = s.ssColor;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrColor = s.ssColor;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord ToStructure(ssZXingLibDemo.RestRecords.RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord obj) { 
  EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s = new EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord();
  if(obj != null) {
  s.ssColor = obj.AttrColor == null ? "" : obj.AttrColor;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord, ssZXingLibDemo.RestRecords.RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord FromStructure(EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord(s, config);
}

}


