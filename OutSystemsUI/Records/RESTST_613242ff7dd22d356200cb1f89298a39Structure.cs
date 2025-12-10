using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TimePicker_InternalConfig
public class RESTST_613242ff7dd22d356200cb1f89298a39Structure : AbstractRESTStructure<ST_613242ff7dd22d356200cb1f89298a39Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("TimeFormat")]
public string AttrTimeFormat;

[JsonProperty("Is24Hours")]
public bool? AttrIs24Hours;

[JsonProperty("InitialTime")]
public String AttrInitialTime;

[JsonProperty("MinTime")]
public String AttrMinTime;

[JsonProperty("MaxTime")]
public String AttrMaxTime;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_613242ff7dd22d356200cb1f89298a39Structure() { }

public RESTST_613242ff7dd22d356200cb1f89298a39Structure (ST_613242ff7dd22d356200cb1f89298a39Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrTimeFormat = ConvertToRestWithoutDefaults(s.ssTimeFormat, "");
AttrIs24Hours = ConvertToRestWithoutDefaults(s.ssIs24Hours, true);
AttrInitialTime = ConvertTimeToRestWithoutDefaults(s.ssInitialTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrMinTime = ConvertTimeToRestWithoutDefaults(s.ssMinTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrMaxTime = ConvertTimeToRestWithoutDefaults(s.ssMaxTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrTimeFormat = s.ssTimeFormat;
AttrIs24Hours = (bool?) s.ssIs24Hours;
AttrInitialTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.TimeToText(s.ssInitialTime);
AttrMinTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.TimeToText(s.ssMinTime);
AttrMaxTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.TimeToText(s.ssMaxTime);
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_613242ff7dd22d356200cb1f89298a39Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_613242ff7dd22d356200cb1f89298a39Structure obj) { 
  ST_613242ff7dd22d356200cb1f89298a39Structure s = new ST_613242ff7dd22d356200cb1f89298a39Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssTimeFormat = obj.AttrTimeFormat == null ? "" : obj.AttrTimeFormat;
  s.ssIs24Hours = obj.AttrIs24Hours == null ? true : obj.AttrIs24Hours.Value;
  s.ssInitialTime = obj.AttrInitialTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToTime(obj.AttrInitialTime);
  s.ssMinTime = obj.AttrMinTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToTime(obj.AttrMinTime);
  s.ssMaxTime = obj.AttrMaxTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToTime(obj.AttrMaxTime);
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_613242ff7dd22d356200cb1f89298a39Structure, ssOutSystemsUI.RestRecords.RESTST_613242ff7dd22d356200cb1f89298a39Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_613242ff7dd22d356200cb1f89298a39Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_613242ff7dd22d356200cb1f89298a39Structure FromStructure(ST_613242ff7dd22d356200cb1f89298a39Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_613242ff7dd22d356200cb1f89298a39Structure(s, config);
}

}


