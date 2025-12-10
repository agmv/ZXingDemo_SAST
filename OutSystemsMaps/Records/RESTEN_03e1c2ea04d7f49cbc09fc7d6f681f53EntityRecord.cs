using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// FileLayerEvent
public class RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord : AbstractRESTStructure<EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord() { }

public RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord (EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord obj) { 
  EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord s = new EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord FromStructure(EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord(s, config);
}

}


