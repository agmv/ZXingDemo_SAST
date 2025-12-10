using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// CalendarEvent
public class RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure : AbstractRESTStructure<ST_8738e857d4fb6695d1e17d4c03428ee2Structure> {
[JsonProperty("title")]
public string Attrtitle;

[JsonProperty("isAllDay")]
public bool? AttrisAllDay;

[JsonProperty("startDateTime")]
public String AttrstartDateTime;

[JsonProperty("endDateTime")]
public String AttrendDateTime;

[JsonProperty("location")]
public string Attrlocation;

[JsonProperty("description")]
public string Attrdescription;

[JsonProperty("eventClass")]
public string AttreventClass;

[JsonProperty("organizer")]
public string Attrorganizer;

[JsonProperty("priority")]
public int? Attrpriority;

[JsonProperty("showAsBusy")]
public bool? AttrshowAsBusy;

public RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure() { }

public RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure (ST_8738e857d4fb6695d1e17d4c03428ee2Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrtitle = s.sstitle;
AttrisAllDay = (bool?) s.ssisAllDay;
AttrstartDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssstartDateTime, config.DateTimeFormat);
AttrendDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssendDateTime, config.DateTimeFormat);
Attrlocation = ConvertToRestWithoutDefaults(s.sslocation, "");
Attrdescription = ConvertToRestWithoutDefaults(s.ssdescription, "");
AttreventClass = ConvertToRestWithoutDefaults(s.sseventClass, "");
Attrorganizer = ConvertToRestWithoutDefaults(s.ssorganizer, "");
Attrpriority = ConvertToRestWithoutDefaults(s.sspriority, 0);
AttrshowAsBusy = ConvertToRestWithoutDefaults(s.ssshowAsBusy, false);
  } else {
Attrtitle = s.sstitle;
AttrisAllDay = (bool?) s.ssisAllDay;
AttrstartDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssstartDateTime, config.DateTimeFormat);
AttrendDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssendDateTime, config.DateTimeFormat);
Attrlocation = s.sslocation;
Attrdescription = s.ssdescription;
AttreventClass = s.sseventClass;
Attrorganizer = s.ssorganizer;
Attrpriority = (int?) s.sspriority;
AttrshowAsBusy = (bool?) s.ssshowAsBusy;
  }
}

public static ST_8738e857d4fb6695d1e17d4c03428ee2Structure ToStructure(ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure obj) { 
  ST_8738e857d4fb6695d1e17d4c03428ee2Structure s = new ST_8738e857d4fb6695d1e17d4c03428ee2Structure();
  if(obj != null) {
  s.sstitle = obj.Attrtitle == null ? "" : obj.Attrtitle;
  s.ssisAllDay = obj.AttrisAllDay == null ? false : obj.AttrisAllDay.Value;
  s.ssstartDateTime = obj.AttrstartDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrstartDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssendDateTime = obj.AttrendDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrendDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.sslocation = obj.Attrlocation == null ? "" : obj.Attrlocation;
  s.ssdescription = obj.Attrdescription == null ? "" : obj.Attrdescription;
  s.sseventClass = obj.AttreventClass == null ? "" : obj.AttreventClass;
  s.ssorganizer = obj.Attrorganizer == null ? "" : obj.Attrorganizer;
  s.sspriority = obj.Attrpriority == null ? 0 : obj.Attrpriority.Value;
  s.ssshowAsBusy = obj.AttrshowAsBusy == null ? false : obj.AttrshowAsBusy.Value;
  }
  return s;
}

public static Func<ST_8738e857d4fb6695d1e17d4c03428ee2Structure, ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8738e857d4fb6695d1e17d4c03428ee2Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure FromStructure(ST_8738e857d4fb6695d1e17d4c03428ee2Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure(s, config);
}

}


