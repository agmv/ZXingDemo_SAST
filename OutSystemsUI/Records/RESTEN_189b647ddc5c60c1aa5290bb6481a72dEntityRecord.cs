using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MessageStatus
public class RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord : AbstractRESTStructure<EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord> {
[JsonProperty("Type")]
public string AttrType;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord() { }

public RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord (EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrType = s.ssType;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord obj) { 
  EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord s = new EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord, ssOutSystemsUI.RestRecords.RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord FromStructure(EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord(s, config);
}

}


