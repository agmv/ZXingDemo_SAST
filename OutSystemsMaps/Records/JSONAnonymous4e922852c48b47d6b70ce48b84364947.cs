using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchPlacesEventRecord
public class JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5 : AbstractRESTStructure<RC_f1764d7c40e4f0543f1781c01f8cbcf5> {
[JsonProperty("SearchPlacesEvent")]
[JsonPropertyName("SearchPlacesEvent")]
public ssOutSystemsMaps.RestRecords.JSONEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord AttrSearchPlacesEvent;

public JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5() { }

public JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5 (RC_f1764d7c40e4f0543f1781c01f8cbcf5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSearchPlacesEvent = ConvertToRestWithoutDefaults(s.ssENSearchPlacesEvent, new EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord.FromStructureDelegate(config));
  } else {
AttrSearchPlacesEvent = ssOutSystemsMaps.RestRecords.JSONEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord.FromStructure(s.ssENSearchPlacesEvent, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5, RC_f1764d7c40e4f0543f1781c01f8cbcf5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5 s) => ToStructure(s, config);
}
public static RC_f1764d7c40e4f0543f1781c01f8cbcf5 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5 obj, IBehaviorsConfiguration config) { 
  RC_f1764d7c40e4f0543f1781c01f8cbcf5 s = new RC_f1764d7c40e4f0543f1781c01f8cbcf5();
  if(obj != null) {
  s.ssENSearchPlacesEvent = ssOutSystemsMaps.RestRecords.JSONEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord.ToStructure(obj.AttrSearchPlacesEvent, config);
  }
  return s;
}

public static Func<RC_f1764d7c40e4f0543f1781c01f8cbcf5, ssOutSystemsMaps.RestRecords.JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f1764d7c40e4f0543f1781c01f8cbcf5 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5 FromStructure(RC_f1764d7c40e4f0543f1781c01f8cbcf5 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_f1764d7c40e4f0543f1781c01f8cbcf5(s, config);
}

}


