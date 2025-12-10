using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MessageStatusRecord
public class RESTRC_63c659b6dc554b0b4f81d60382bf5fd6 : AbstractRESTStructure<RC_63c659b6dc554b0b4f81d60382bf5fd6> {
[JsonProperty("MessageStatus")]
public ssOutSystemsUI.RestRecords.RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord AttrMessageStatus;

public RESTRC_63c659b6dc554b0b4f81d60382bf5fd6() { }

public RESTRC_63c659b6dc554b0b4f81d60382bf5fd6 (RC_63c659b6dc554b0b4f81d60382bf5fd6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMessageStatus = ConvertToRestWithoutDefaults(s.ssENMessageStatus, new EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord.FromStructureDelegate(config));
  } else {
AttrMessageStatus = ssOutSystemsUI.RestRecords.RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord.FromStructure(s.ssENMessageStatus, config);
  }
}

public static RC_63c659b6dc554b0b4f81d60382bf5fd6 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_63c659b6dc554b0b4f81d60382bf5fd6 obj) { 
  RC_63c659b6dc554b0b4f81d60382bf5fd6 s = new RC_63c659b6dc554b0b4f81d60382bf5fd6();
  if(obj != null) {
  s.ssENMessageStatus = ssOutSystemsUI.RestRecords.RESTEN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord.ToStructure(obj.AttrMessageStatus);
  }
  return s;
}

public static Func<RC_63c659b6dc554b0b4f81d60382bf5fd6, ssOutSystemsUI.RestRecords.RESTRC_63c659b6dc554b0b4f81d60382bf5fd6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_63c659b6dc554b0b4f81d60382bf5fd6 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_63c659b6dc554b0b4f81d60382bf5fd6 FromStructure(RC_63c659b6dc554b0b4f81d60382bf5fd6 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_63c659b6dc554b0b4f81d60382bf5fd6(s, config);
}

}


