using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeEventRecord
public class RESTRC_edb1f7bb91ddbc761736a4f9fe9ed955 : AbstractRESTStructure<RC_edb1f7bb91ddbc761736a4f9fe9ed955> {
[JsonProperty("ShapeEvent")]
public ssOutSystemsMaps.RestRecords.RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord AttrShapeEvent;

public RESTRC_edb1f7bb91ddbc761736a4f9fe9ed955() { }

public RESTRC_edb1f7bb91ddbc761736a4f9fe9ed955 (RC_edb1f7bb91ddbc761736a4f9fe9ed955 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShapeEvent = ConvertToRestWithoutDefaults(s.ssENShapeEvent, new EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord.FromStructureDelegate(config));
  } else {
AttrShapeEvent = ssOutSystemsMaps.RestRecords.RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord.FromStructure(s.ssENShapeEvent, config);
  }
}

public static RC_edb1f7bb91ddbc761736a4f9fe9ed955 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_edb1f7bb91ddbc761736a4f9fe9ed955 obj) { 
  RC_edb1f7bb91ddbc761736a4f9fe9ed955 s = new RC_edb1f7bb91ddbc761736a4f9fe9ed955();
  if(obj != null) {
  s.ssENShapeEvent = ssOutSystemsMaps.RestRecords.RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord.ToStructure(obj.AttrShapeEvent);
  }
  return s;
}

public static Func<RC_edb1f7bb91ddbc761736a4f9fe9ed955, ssOutSystemsMaps.RestRecords.RESTRC_edb1f7bb91ddbc761736a4f9fe9ed955> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_edb1f7bb91ddbc761736a4f9fe9ed955 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_edb1f7bb91ddbc761736a4f9fe9ed955 FromStructure(RC_edb1f7bb91ddbc761736a4f9fe9ed955 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_edb1f7bb91ddbc761736a4f9fe9ed955(s, config);
}

}


