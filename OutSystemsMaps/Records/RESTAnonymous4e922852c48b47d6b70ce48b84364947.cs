using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchPlacesEventRecord
public class RESTRC_f1764d7c40e4f0543f1781c01f8cbcf5 : AbstractRESTStructure<RC_f1764d7c40e4f0543f1781c01f8cbcf5> {
[JsonProperty("SearchPlacesEvent")]
public ssOutSystemsMaps.RestRecords.RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord AttrSearchPlacesEvent;

public RESTRC_f1764d7c40e4f0543f1781c01f8cbcf5() { }

public RESTRC_f1764d7c40e4f0543f1781c01f8cbcf5 (RC_f1764d7c40e4f0543f1781c01f8cbcf5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSearchPlacesEvent = ConvertToRestWithoutDefaults(s.ssENSearchPlacesEvent, new EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord.FromStructureDelegate(config));
  } else {
AttrSearchPlacesEvent = ssOutSystemsMaps.RestRecords.RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord.FromStructure(s.ssENSearchPlacesEvent, config);
  }
}

public static RC_f1764d7c40e4f0543f1781c01f8cbcf5 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_f1764d7c40e4f0543f1781c01f8cbcf5 obj) { 
  RC_f1764d7c40e4f0543f1781c01f8cbcf5 s = new RC_f1764d7c40e4f0543f1781c01f8cbcf5();
  if(obj != null) {
  s.ssENSearchPlacesEvent = ssOutSystemsMaps.RestRecords.RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord.ToStructure(obj.AttrSearchPlacesEvent);
  }
  return s;
}

public static Func<RC_f1764d7c40e4f0543f1781c01f8cbcf5, ssOutSystemsMaps.RestRecords.RESTRC_f1764d7c40e4f0543f1781c01f8cbcf5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f1764d7c40e4f0543f1781c01f8cbcf5 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_f1764d7c40e4f0543f1781c01f8cbcf5 FromStructure(RC_f1764d7c40e4f0543f1781c01f8cbcf5 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_f1764d7c40e4f0543f1781c01f8cbcf5(s, config);
}

}


