using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// PopupEvent
public class RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord : AbstractRESTStructure<EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord() { }

public RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord (EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord obj) { 
  EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord s = new EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord FromStructure(EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord(s, config);
}

}


