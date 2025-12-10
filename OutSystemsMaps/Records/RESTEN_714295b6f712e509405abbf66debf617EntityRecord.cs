using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionsProvider
public class RESTEN_714295b6f712e509405abbf66debf617EntityRecord : AbstractRESTStructure<EN_714295b6f712e509405abbf66debf617EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_714295b6f712e509405abbf66debf617EntityRecord() { }

public RESTEN_714295b6f712e509405abbf66debf617EntityRecord (EN_714295b6f712e509405abbf66debf617EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_714295b6f712e509405abbf66debf617EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_714295b6f712e509405abbf66debf617EntityRecord obj) { 
  EN_714295b6f712e509405abbf66debf617EntityRecord s = new EN_714295b6f712e509405abbf66debf617EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_714295b6f712e509405abbf66debf617EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_714295b6f712e509405abbf66debf617EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_714295b6f712e509405abbf66debf617EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_714295b6f712e509405abbf66debf617EntityRecord FromStructure(EN_714295b6f712e509405abbf66debf617EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_714295b6f712e509405abbf66debf617EntityRecord(s, config);
}

}


