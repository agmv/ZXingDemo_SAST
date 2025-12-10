using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TimePickerOptionalConfigs
public class JSONST_b96c67f06fdfae580256b7081d85460dStructure : AbstractRESTStructure<ST_b96c67f06fdfae580256b7081d85460dStructure> {
[JsonProperty("MinTime")]
[JsonPropertyName("MinTime")]
public String AttrMinTime;

[JsonProperty("MaxTime")]
[JsonPropertyName("MaxTime")]
public String AttrMaxTime;

public JSONST_b96c67f06fdfae580256b7081d85460dStructure() { }

public JSONST_b96c67f06fdfae580256b7081d85460dStructure (ST_b96c67f06fdfae580256b7081d85460dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMinTime = ConvertTimeToRestWithoutDefaults(s.ssMinTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrMaxTime = ConvertTimeToRestWithoutDefaults(s.ssMaxTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
  } else {
AttrMinTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.TimeToText(s.ssMinTime);
AttrMaxTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.TimeToText(s.ssMaxTime);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure, ST_b96c67f06fdfae580256b7081d85460dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure s) => ToStructure(s, config);
}
public static ST_b96c67f06fdfae580256b7081d85460dStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure obj, IBehaviorsConfiguration config) { 
  ST_b96c67f06fdfae580256b7081d85460dStructure s = new ST_b96c67f06fdfae580256b7081d85460dStructure();
  if(obj != null) {
  s.ssMinTime = obj.AttrMinTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToTime(obj.AttrMinTime);
  s.ssMaxTime = obj.AttrMaxTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToTime(obj.AttrMaxTime);
  }
  return s;
}

public static Func<ST_b96c67f06fdfae580256b7081d85460dStructure, ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b96c67f06fdfae580256b7081d85460dStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure FromStructure(ST_b96c67f06fdfae580256b7081d85460dStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_b96c67f06fdfae580256b7081d85460dStructure(s, config);
}

}


