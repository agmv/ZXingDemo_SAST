using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionsProvider
public class JSONEN_714295b6f712e509405abbf66debf617EntityRecord : AbstractRESTStructure<EN_714295b6f712e509405abbf66debf617EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_714295b6f712e509405abbf66debf617EntityRecord() { }

public JSONEN_714295b6f712e509405abbf66debf617EntityRecord (EN_714295b6f712e509405abbf66debf617EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord, EN_714295b6f712e509405abbf66debf617EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord s) => ToStructure(s, config);
}
public static EN_714295b6f712e509405abbf66debf617EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_714295b6f712e509405abbf66debf617EntityRecord s = new EN_714295b6f712e509405abbf66debf617EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_714295b6f712e509405abbf66debf617EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_714295b6f712e509405abbf66debf617EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord FromStructure(EN_714295b6f712e509405abbf66debf617EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_714295b6f712e509405abbf66debf617EntityRecord(s, config);
}

}


