using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionsProviderRecord
public class JSONRC_9c493adade9ae0a5806b7a20eb12f1e0 : AbstractRESTStructure<RC_9c493adade9ae0a5806b7a20eb12f1e0> {
[JsonProperty("DirectionsProvider")]
[JsonPropertyName("DirectionsProvider")]
public ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord AttrDirectionsProvider;

public JSONRC_9c493adade9ae0a5806b7a20eb12f1e0() { }

public JSONRC_9c493adade9ae0a5806b7a20eb12f1e0 (RC_9c493adade9ae0a5806b7a20eb12f1e0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectionsProvider = ConvertToRestWithoutDefaults(s.ssENDirectionsProvider, new EN_714295b6f712e509405abbf66debf617EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord.FromStructureDelegate(config));
  } else {
AttrDirectionsProvider = ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord.FromStructure(s.ssENDirectionsProvider, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_9c493adade9ae0a5806b7a20eb12f1e0, RC_9c493adade9ae0a5806b7a20eb12f1e0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_9c493adade9ae0a5806b7a20eb12f1e0 s) => ToStructure(s, config);
}
public static RC_9c493adade9ae0a5806b7a20eb12f1e0 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_9c493adade9ae0a5806b7a20eb12f1e0 obj, IBehaviorsConfiguration config) { 
  RC_9c493adade9ae0a5806b7a20eb12f1e0 s = new RC_9c493adade9ae0a5806b7a20eb12f1e0();
  if(obj != null) {
  s.ssENDirectionsProvider = ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord.ToStructure(obj.AttrDirectionsProvider, config);
  }
  return s;
}

public static Func<RC_9c493adade9ae0a5806b7a20eb12f1e0, ssOutSystemsMaps.RestRecords.JSONRC_9c493adade9ae0a5806b7a20eb12f1e0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9c493adade9ae0a5806b7a20eb12f1e0 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_9c493adade9ae0a5806b7a20eb12f1e0 FromStructure(RC_9c493adade9ae0a5806b7a20eb12f1e0 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_9c493adade9ae0a5806b7a20eb12f1e0(s, config);
}

}


