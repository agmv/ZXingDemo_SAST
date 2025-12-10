using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerCalendarType
public class JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord : AbstractRESTStructure<EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord> {
[JsonProperty("Mode")]
[JsonPropertyName("Mode")]
public string AttrMode;

public JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord() { }

public JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord (EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMode = s.ssMode;
  } else {
AttrMode = s.ssMode;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord, EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s) => ToStructure(s, config);
}
public static EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s = new EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord();
  if(obj != null) {
  s.ssMode = obj.AttrMode == null ? "" : obj.AttrMode;
  }
  return s;
}

public static Func<EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord FromStructure(EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord(s, config);
}

}


