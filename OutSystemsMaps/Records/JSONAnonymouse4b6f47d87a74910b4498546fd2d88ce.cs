using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// StaticMarkerRecord
public class JSONRC_2e794e9950648fb781740aa3223ba10d : AbstractRESTStructure<RC_2e794e9950648fb781740aa3223ba10d> {
[JsonProperty("StaticMarker")]
[JsonPropertyName("StaticMarker")]
public ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure AttrStaticMarker;

public JSONRC_2e794e9950648fb781740aa3223ba10d() { }

public JSONRC_2e794e9950648fb781740aa3223ba10d (RC_2e794e9950648fb781740aa3223ba10d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStaticMarker = ConvertToRestWithoutDefaults(s.ssSTStaticMarker, new ST_832344699c82a4f799a423f89bbe7297Structure(), ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure.FromStructureDelegate(config));
  } else {
AttrStaticMarker = ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure.FromStructure(s.ssSTStaticMarker, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_2e794e9950648fb781740aa3223ba10d, RC_2e794e9950648fb781740aa3223ba10d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_2e794e9950648fb781740aa3223ba10d s) => ToStructure(s, config);
}
public static RC_2e794e9950648fb781740aa3223ba10d ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_2e794e9950648fb781740aa3223ba10d obj, IBehaviorsConfiguration config) { 
  RC_2e794e9950648fb781740aa3223ba10d s = new RC_2e794e9950648fb781740aa3223ba10d();
  if(obj != null) {
  s.ssSTStaticMarker = ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure.ToStructure(obj.AttrStaticMarker, config);
  }
  return s;
}

public static Func<RC_2e794e9950648fb781740aa3223ba10d, ssOutSystemsMaps.RestRecords.JSONRC_2e794e9950648fb781740aa3223ba10d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2e794e9950648fb781740aa3223ba10d s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_2e794e9950648fb781740aa3223ba10d FromStructure(RC_2e794e9950648fb781740aa3223ba10d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_2e794e9950648fb781740aa3223ba10d(s, config);
}

}


