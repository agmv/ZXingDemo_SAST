using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeEventRecord
public class JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955 : AbstractRESTStructure<RC_edb1f7bb91ddbc761736a4f9fe9ed955> {
[JsonProperty("ShapeEvent")]
[JsonPropertyName("ShapeEvent")]
public ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord AttrShapeEvent;

public JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955() { }

public JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955 (RC_edb1f7bb91ddbc761736a4f9fe9ed955 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShapeEvent = ConvertToRestWithoutDefaults(s.ssENShapeEvent, new EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord.FromStructureDelegate(config));
  } else {
AttrShapeEvent = ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord.FromStructure(s.ssENShapeEvent, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955, RC_edb1f7bb91ddbc761736a4f9fe9ed955> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955 s) => ToStructure(s, config);
}
public static RC_edb1f7bb91ddbc761736a4f9fe9ed955 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955 obj, IBehaviorsConfiguration config) { 
  RC_edb1f7bb91ddbc761736a4f9fe9ed955 s = new RC_edb1f7bb91ddbc761736a4f9fe9ed955();
  if(obj != null) {
  s.ssENShapeEvent = ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord.ToStructure(obj.AttrShapeEvent, config);
  }
  return s;
}

public static Func<RC_edb1f7bb91ddbc761736a4f9fe9ed955, ssOutSystemsMaps.RestRecords.JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_edb1f7bb91ddbc761736a4f9fe9ed955 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955 FromStructure(RC_edb1f7bb91ddbc761736a4f9fe9ed955 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_edb1f7bb91ddbc761736a4f9fe9ed955(s, config);
}

}


