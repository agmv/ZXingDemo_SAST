using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// TypeRecord
public class RESTRC_b32e755d03dd085a4b975b8c0c7d4454 : AbstractRESTStructure<RC_b32e755d03dd085a4b975b8c0c7d4454> {
[JsonProperty("Type")]
public ssOutSystemsMaps.RestRecords.RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord AttrType;

public RESTRC_b32e755d03dd085a4b975b8c0c7d4454() { }

public RESTRC_b32e755d03dd085a4b975b8c0c7d4454 (RC_b32e755d03dd085a4b975b8c0c7d4454 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = ConvertToRestWithoutDefaults(s.ssENType, new EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord.FromStructureDelegate(config));
  } else {
AttrType = ssOutSystemsMaps.RestRecords.RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord.FromStructure(s.ssENType, config);
  }
}

public static RC_b32e755d03dd085a4b975b8c0c7d4454 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_b32e755d03dd085a4b975b8c0c7d4454 obj) { 
  RC_b32e755d03dd085a4b975b8c0c7d4454 s = new RC_b32e755d03dd085a4b975b8c0c7d4454();
  if(obj != null) {
  s.ssENType = ssOutSystemsMaps.RestRecords.RESTEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord.ToStructure(obj.AttrType);
  }
  return s;
}

public static Func<RC_b32e755d03dd085a4b975b8c0c7d4454, ssOutSystemsMaps.RestRecords.RESTRC_b32e755d03dd085a4b975b8c0c7d4454> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b32e755d03dd085a4b975b8c0c7d4454 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_b32e755d03dd085a4b975b8c0c7d4454 FromStructure(RC_b32e755d03dd085a4b975b8c0c7d4454 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_b32e755d03dd085a4b975b8c0c7d4454(s, config);
}

}


