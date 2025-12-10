using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchAreaRecord
public class JSONRC_f5926d9764d9dfa431e4fc134e2e6a98 : AbstractRESTStructure<RC_f5926d9764d9dfa431e4fc134e2e6a98> {
[JsonProperty("SearchArea")]
[JsonPropertyName("SearchArea")]
public ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure AttrSearchArea;

public JSONRC_f5926d9764d9dfa431e4fc134e2e6a98() { }

public JSONRC_f5926d9764d9dfa431e4fc134e2e6a98 (RC_f5926d9764d9dfa431e4fc134e2e6a98 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSearchArea = ConvertToRestWithoutDefaults(s.ssSTSearchArea, new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure(), ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructureDelegate(config));
  } else {
AttrSearchArea = ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructure(s.ssSTSearchArea, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_f5926d9764d9dfa431e4fc134e2e6a98, RC_f5926d9764d9dfa431e4fc134e2e6a98> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_f5926d9764d9dfa431e4fc134e2e6a98 s) => ToStructure(s, config);
}
public static RC_f5926d9764d9dfa431e4fc134e2e6a98 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_f5926d9764d9dfa431e4fc134e2e6a98 obj, IBehaviorsConfiguration config) { 
  RC_f5926d9764d9dfa431e4fc134e2e6a98 s = new RC_f5926d9764d9dfa431e4fc134e2e6a98();
  if(obj != null) {
  s.ssSTSearchArea = ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.ToStructure(obj.AttrSearchArea, config);
  }
  return s;
}

public static Func<RC_f5926d9764d9dfa431e4fc134e2e6a98, ssOutSystemsMaps.RestRecords.JSONRC_f5926d9764d9dfa431e4fc134e2e6a98> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f5926d9764d9dfa431e4fc134e2e6a98 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_f5926d9764d9dfa431e4fc134e2e6a98 FromStructure(RC_f5926d9764d9dfa431e4fc134e2e6a98 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_f5926d9764d9dfa431e4fc134e2e6a98(s, config);
}

}


