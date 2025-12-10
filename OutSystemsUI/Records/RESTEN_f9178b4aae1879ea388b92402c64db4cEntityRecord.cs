using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// IdentityProvider
public class RESTEN_f9178b4aae1879ea388b92402c64db4cEntityRecord : AbstractRESTStructure<EN_f9178b4aae1879ea388b92402c64db4cEntityRecord> {
[JsonProperty("Provider")]
public string AttrProvider;

public RESTEN_f9178b4aae1879ea388b92402c64db4cEntityRecord() { }

public RESTEN_f9178b4aae1879ea388b92402c64db4cEntityRecord (EN_f9178b4aae1879ea388b92402c64db4cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProvider = s.ssProvider;
  } else {
AttrProvider = s.ssProvider;
  }
}

public static EN_f9178b4aae1879ea388b92402c64db4cEntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_f9178b4aae1879ea388b92402c64db4cEntityRecord obj) { 
  EN_f9178b4aae1879ea388b92402c64db4cEntityRecord s = new EN_f9178b4aae1879ea388b92402c64db4cEntityRecord();
  if(obj != null) {
  s.ssProvider = obj.AttrProvider == null ? "" : obj.AttrProvider;
  }
  return s;
}

public static Func<EN_f9178b4aae1879ea388b92402c64db4cEntityRecord, ssOutSystemsUI.RestRecords.RESTEN_f9178b4aae1879ea388b92402c64db4cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f9178b4aae1879ea388b92402c64db4cEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_f9178b4aae1879ea388b92402c64db4cEntityRecord FromStructure(EN_f9178b4aae1879ea388b92402c64db4cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_f9178b4aae1879ea388b92402c64db4cEntityRecord(s, config);
}

}


