using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerRecord
public class JSONRC_bff46e9299d53c31f52181ed865bd729 : AbstractRESTStructure<RC_bff46e9299d53c31f52181ed865bd729> {
[JsonProperty("Marker")]
[JsonPropertyName("Marker")]
public ssOutSystemsMaps.RestRecords.JSONST_5a7ef7acf3b11e0c41074aefa2466f75Structure AttrMarker;

public JSONRC_bff46e9299d53c31f52181ed865bd729() { }

public JSONRC_bff46e9299d53c31f52181ed865bd729 (RC_bff46e9299d53c31f52181ed865bd729 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarker = ConvertToRestWithoutDefaults(s.ssSTMarker, new ST_5a7ef7acf3b11e0c41074aefa2466f75Structure(), ssOutSystemsMaps.RestRecords.JSONST_5a7ef7acf3b11e0c41074aefa2466f75Structure.FromStructureDelegate(config));
  } else {
AttrMarker = ssOutSystemsMaps.RestRecords.JSONST_5a7ef7acf3b11e0c41074aefa2466f75Structure.FromStructure(s.ssSTMarker, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_bff46e9299d53c31f52181ed865bd729, RC_bff46e9299d53c31f52181ed865bd729> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_bff46e9299d53c31f52181ed865bd729 s) => ToStructure(s, config);
}
public static RC_bff46e9299d53c31f52181ed865bd729 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_bff46e9299d53c31f52181ed865bd729 obj, IBehaviorsConfiguration config) { 
  RC_bff46e9299d53c31f52181ed865bd729 s = new RC_bff46e9299d53c31f52181ed865bd729();
  if(obj != null) {
  s.ssSTMarker = ssOutSystemsMaps.RestRecords.JSONST_5a7ef7acf3b11e0c41074aefa2466f75Structure.ToStructure(obj.AttrMarker, config);
  }
  return s;
}

public static Func<RC_bff46e9299d53c31f52181ed865bd729, ssOutSystemsMaps.RestRecords.JSONRC_bff46e9299d53c31f52181ed865bd729> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bff46e9299d53c31f52181ed865bd729 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_bff46e9299d53c31f52181ed865bd729 FromStructure(RC_bff46e9299d53c31f52181ed865bd729 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_bff46e9299d53c31f52181ed865bd729(s, config);
}

}


