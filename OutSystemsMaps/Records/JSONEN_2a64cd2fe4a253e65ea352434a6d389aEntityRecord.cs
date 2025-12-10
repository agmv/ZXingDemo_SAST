using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchTypes
public class JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord : AbstractRESTStructure<EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord() { }

public JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord (EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord, EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord s) => ToStructure(s, config);
}
public static EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord s = new EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord FromStructure(EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord(s, config);
}

}


