using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MessageStatusRecord
public class JSONRC_63c659b6dc554b0b4f81d60382bf5fd6 : AbstractRESTStructure<RC_63c659b6dc554b0b4f81d60382bf5fd6> {
[JsonProperty("MessageStatus")]
[JsonPropertyName("MessageStatus")]
public ssOutSystemsUI.RestRecords.JSONEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord AttrMessageStatus;

public JSONRC_63c659b6dc554b0b4f81d60382bf5fd6() { }

public JSONRC_63c659b6dc554b0b4f81d60382bf5fd6 (RC_63c659b6dc554b0b4f81d60382bf5fd6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMessageStatus = ConvertToRestWithoutDefaults(s.ssENMessageStatus, new EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord.FromStructureDelegate(config));
  } else {
AttrMessageStatus = ssOutSystemsUI.RestRecords.JSONEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord.FromStructure(s.ssENMessageStatus, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_63c659b6dc554b0b4f81d60382bf5fd6, RC_63c659b6dc554b0b4f81d60382bf5fd6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_63c659b6dc554b0b4f81d60382bf5fd6 s) => ToStructure(s, config);
}
public static RC_63c659b6dc554b0b4f81d60382bf5fd6 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_63c659b6dc554b0b4f81d60382bf5fd6 obj, IBehaviorsConfiguration config) { 
  RC_63c659b6dc554b0b4f81d60382bf5fd6 s = new RC_63c659b6dc554b0b4f81d60382bf5fd6();
  if(obj != null) {
  s.ssENMessageStatus = ssOutSystemsUI.RestRecords.JSONEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord.ToStructure(obj.AttrMessageStatus, config);
  }
  return s;
}

public static Func<RC_63c659b6dc554b0b4f81d60382bf5fd6, ssOutSystemsUI.RestRecords.JSONRC_63c659b6dc554b0b4f81d60382bf5fd6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_63c659b6dc554b0b4f81d60382bf5fd6 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_63c659b6dc554b0b4f81d60382bf5fd6 FromStructure(RC_63c659b6dc554b0b4f81d60382bf5fd6 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_63c659b6dc554b0b4f81d60382bf5fd6(s, config);
}

}


