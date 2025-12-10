using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// CalendarEventRecord
public class RESTRC_2796116ff1beb3c001fb57dc12652270 : AbstractRESTStructure<RC_2796116ff1beb3c001fb57dc12652270> {
[JsonProperty("CalendarEvent")]
public ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure AttrCalendarEvent;

public RESTRC_2796116ff1beb3c001fb57dc12652270() { }

public RESTRC_2796116ff1beb3c001fb57dc12652270 (RC_2796116ff1beb3c001fb57dc12652270 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCalendarEvent = ConvertToRestWithoutDefaults(s.ssSTCalendarEvent, new ST_8738e857d4fb6695d1e17d4c03428ee2Structure(), ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure.FromStructureDelegate(config));
  } else {
AttrCalendarEvent = ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure.FromStructure(s.ssSTCalendarEvent, config);
  }
}

public static RC_2796116ff1beb3c001fb57dc12652270 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_2796116ff1beb3c001fb57dc12652270 obj) { 
  RC_2796116ff1beb3c001fb57dc12652270 s = new RC_2796116ff1beb3c001fb57dc12652270();
  if(obj != null) {
  s.ssSTCalendarEvent = ssZXingLibDemo.RestRecords.RESTST_8738e857d4fb6695d1e17d4c03428ee2Structure.ToStructure(obj.AttrCalendarEvent);
  }
  return s;
}

public static Func<RC_2796116ff1beb3c001fb57dc12652270, ssZXingLibDemo.RestRecords.RESTRC_2796116ff1beb3c001fb57dc12652270> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2796116ff1beb3c001fb57dc12652270 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_2796116ff1beb3c001fb57dc12652270 FromStructure(RC_2796116ff1beb3c001fb57dc12652270 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_2796116ff1beb3c001fb57dc12652270(s, config);
}

}


