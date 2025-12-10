using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapEventRecord
public class JSONRC_227974ef92f7b64b18b95570fef9abe3 : AbstractRESTStructure<RC_227974ef92f7b64b18b95570fef9abe3> {
[JsonProperty("MapEvent")]
[JsonPropertyName("MapEvent")]
public ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord AttrMapEvent;

public JSONRC_227974ef92f7b64b18b95570fef9abe3() { }

public JSONRC_227974ef92f7b64b18b95570fef9abe3 (RC_227974ef92f7b64b18b95570fef9abe3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMapEvent = ConvertToRestWithoutDefaults(s.ssENMapEvent, new EN_e5ca0002e0338a827923cc311de3f95cEntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord.FromStructureDelegate(config));
  } else {
AttrMapEvent = ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord.FromStructure(s.ssENMapEvent, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_227974ef92f7b64b18b95570fef9abe3, RC_227974ef92f7b64b18b95570fef9abe3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_227974ef92f7b64b18b95570fef9abe3 s) => ToStructure(s, config);
}
public static RC_227974ef92f7b64b18b95570fef9abe3 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_227974ef92f7b64b18b95570fef9abe3 obj, IBehaviorsConfiguration config) { 
  RC_227974ef92f7b64b18b95570fef9abe3 s = new RC_227974ef92f7b64b18b95570fef9abe3();
  if(obj != null) {
  s.ssENMapEvent = ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord.ToStructure(obj.AttrMapEvent, config);
  }
  return s;
}

public static Func<RC_227974ef92f7b64b18b95570fef9abe3, ssOutSystemsMaps.RestRecords.JSONRC_227974ef92f7b64b18b95570fef9abe3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_227974ef92f7b64b18b95570fef9abe3 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_227974ef92f7b64b18b95570fef9abe3 FromStructure(RC_227974ef92f7b64b18b95570fef9abe3 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_227974ef92f7b64b18b95570fef9abe3(s, config);
}

}


