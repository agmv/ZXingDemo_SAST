using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapTypeRecord
public class JSONRC_992836b5ddde04d0d91f0c87e7233524 : AbstractRESTStructure<RC_992836b5ddde04d0d91f0c87e7233524> {
[JsonProperty("MapType")]
[JsonPropertyName("MapType")]
public ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord AttrMapType;

public JSONRC_992836b5ddde04d0d91f0c87e7233524() { }

public JSONRC_992836b5ddde04d0d91f0c87e7233524 (RC_992836b5ddde04d0d91f0c87e7233524 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMapType = ConvertToRestWithoutDefaults(s.ssENMapType, new EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord.FromStructureDelegate(config));
  } else {
AttrMapType = ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord.FromStructure(s.ssENMapType, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_992836b5ddde04d0d91f0c87e7233524, RC_992836b5ddde04d0d91f0c87e7233524> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_992836b5ddde04d0d91f0c87e7233524 s) => ToStructure(s, config);
}
public static RC_992836b5ddde04d0d91f0c87e7233524 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_992836b5ddde04d0d91f0c87e7233524 obj, IBehaviorsConfiguration config) { 
  RC_992836b5ddde04d0d91f0c87e7233524 s = new RC_992836b5ddde04d0d91f0c87e7233524();
  if(obj != null) {
  s.ssENMapType = ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord.ToStructure(obj.AttrMapType, config);
  }
  return s;
}

public static Func<RC_992836b5ddde04d0d91f0c87e7233524, ssOutSystemsMaps.RestRecords.JSONRC_992836b5ddde04d0d91f0c87e7233524> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_992836b5ddde04d0d91f0c87e7233524 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_992836b5ddde04d0d91f0c87e7233524 FromStructure(RC_992836b5ddde04d0d91f0c87e7233524 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_992836b5ddde04d0d91f0c87e7233524(s, config);
}

}


