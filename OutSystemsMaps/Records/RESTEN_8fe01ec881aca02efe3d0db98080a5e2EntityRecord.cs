using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchPlacesEvent
public class RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord : AbstractRESTStructure<EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord() { }

public RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord (EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord obj) { 
  EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord s = new EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord FromStructure(EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord(s, config);
}

}


