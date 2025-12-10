using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapEventTriggeredRecord
public class RESTRC_bf75694d8016688134fa555a2fd4f5d7 : AbstractRESTStructure<RC_bf75694d8016688134fa555a2fd4f5d7> {
[JsonProperty("MapEventTriggered")]
public ssOutSystemsMaps.RestRecords.RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord AttrMapEventTriggered;

public RESTRC_bf75694d8016688134fa555a2fd4f5d7() { }

public RESTRC_bf75694d8016688134fa555a2fd4f5d7 (RC_bf75694d8016688134fa555a2fd4f5d7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMapEventTriggered = ConvertToRestWithoutDefaults(s.ssENMapEventTriggered, new EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord.FromStructureDelegate(config));
  } else {
AttrMapEventTriggered = ssOutSystemsMaps.RestRecords.RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord.FromStructure(s.ssENMapEventTriggered, config);
  }
}

public static RC_bf75694d8016688134fa555a2fd4f5d7 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_bf75694d8016688134fa555a2fd4f5d7 obj) { 
  RC_bf75694d8016688134fa555a2fd4f5d7 s = new RC_bf75694d8016688134fa555a2fd4f5d7();
  if(obj != null) {
  s.ssENMapEventTriggered = ssOutSystemsMaps.RestRecords.RESTEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord.ToStructure(obj.AttrMapEventTriggered);
  }
  return s;
}

public static Func<RC_bf75694d8016688134fa555a2fd4f5d7, ssOutSystemsMaps.RestRecords.RESTRC_bf75694d8016688134fa555a2fd4f5d7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bf75694d8016688134fa555a2fd4f5d7 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_bf75694d8016688134fa555a2fd4f5d7 FromStructure(RC_bf75694d8016688134fa555a2fd4f5d7 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_bf75694d8016688134fa555a2fd4f5d7(s, config);
}

}


