using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerCalendarType
public class RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord : AbstractRESTStructure<EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord> {
[JsonProperty("Mode")]
public string AttrMode;

public RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord() { }

public RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord (EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMode = s.ssMode;
  } else {
AttrMode = s.ssMode;
  }
}

public static EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord obj) { 
  EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s = new EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord();
  if(obj != null) {
  s.ssMode = obj.AttrMode == null ? "" : obj.AttrMode;
  }
  return s;
}

public static Func<EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord FromStructure(EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord(s, config);
}

}


