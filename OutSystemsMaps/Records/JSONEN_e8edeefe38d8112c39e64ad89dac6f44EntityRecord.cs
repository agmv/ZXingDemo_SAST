using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeType
public class JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord : AbstractRESTStructure<EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord() { }

public JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord (EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord, EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord s) => ToStructure(s, config);
}
public static EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord s = new EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord FromStructure(EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord(s, config);
}

}


