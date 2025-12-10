using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchAreaRecord
public class RESTRC_f5926d9764d9dfa431e4fc134e2e6a98 : AbstractRESTStructure<RC_f5926d9764d9dfa431e4fc134e2e6a98> {
[JsonProperty("SearchArea")]
public ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure AttrSearchArea;

public RESTRC_f5926d9764d9dfa431e4fc134e2e6a98() { }

public RESTRC_f5926d9764d9dfa431e4fc134e2e6a98 (RC_f5926d9764d9dfa431e4fc134e2e6a98 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSearchArea = ConvertToRestWithoutDefaults(s.ssSTSearchArea, new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure(), ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructureDelegate(config));
  } else {
AttrSearchArea = ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructure(s.ssSTSearchArea, config);
  }
}

public static RC_f5926d9764d9dfa431e4fc134e2e6a98 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_f5926d9764d9dfa431e4fc134e2e6a98 obj) { 
  RC_f5926d9764d9dfa431e4fc134e2e6a98 s = new RC_f5926d9764d9dfa431e4fc134e2e6a98();
  if(obj != null) {
  s.ssSTSearchArea = ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.ToStructure(obj.AttrSearchArea);
  }
  return s;
}

public static Func<RC_f5926d9764d9dfa431e4fc134e2e6a98, ssOutSystemsMaps.RestRecords.RESTRC_f5926d9764d9dfa431e4fc134e2e6a98> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f5926d9764d9dfa431e4fc134e2e6a98 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_f5926d9764d9dfa431e4fc134e2e6a98 FromStructure(RC_f5926d9764d9dfa431e4fc134e2e6a98 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_f5926d9764d9dfa431e4fc134e2e6a98(s, config);
}

}


