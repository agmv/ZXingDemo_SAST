using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DirectionRecord
public class JSONRC_070998dc6b3dc951b52d8108550fe380 : AbstractRESTStructure<RC_070998dc6b3dc951b52d8108550fe380> {
[JsonProperty("Direction")]
[JsonPropertyName("Direction")]
public ssOutSystemsUI.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord AttrDirection;

public JSONRC_070998dc6b3dc951b52d8108550fe380() { }

public JSONRC_070998dc6b3dc951b52d8108550fe380 (RC_070998dc6b3dc951b52d8108550fe380 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirection = ConvertToRestWithoutDefaults(s.ssENDirection, new EN_50814454e481dd1773c2250bc248da5eEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord.FromStructureDelegate(config));
  } else {
AttrDirection = ssOutSystemsUI.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord.FromStructure(s.ssENDirection, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380, RC_070998dc6b3dc951b52d8108550fe380> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380 s) => ToStructure(s, config);
}
public static RC_070998dc6b3dc951b52d8108550fe380 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380 obj, IBehaviorsConfiguration config) { 
  RC_070998dc6b3dc951b52d8108550fe380 s = new RC_070998dc6b3dc951b52d8108550fe380();
  if(obj != null) {
  s.ssENDirection = ssOutSystemsUI.RestRecords.JSONEN_50814454e481dd1773c2250bc248da5eEntityRecord.ToStructure(obj.AttrDirection, config);
  }
  return s;
}

public static Func<RC_070998dc6b3dc951b52d8108550fe380, ssOutSystemsUI.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_070998dc6b3dc951b52d8108550fe380 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380 FromStructure(RC_070998dc6b3dc951b52d8108550fe380 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_070998dc6b3dc951b52d8108550fe380(s, config);
}

}


