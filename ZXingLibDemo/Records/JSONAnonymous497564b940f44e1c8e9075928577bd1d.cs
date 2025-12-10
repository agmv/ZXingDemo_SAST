using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// CalendarEventRecord
public class JSONRC_2796116ff1beb3c001fb57dc12652270 : AbstractRESTStructure<RC_2796116ff1beb3c001fb57dc12652270> {
[JsonProperty("CalendarEvent")]
[JsonPropertyName("CalendarEvent")]
public ssZXingLibDemo.RestRecords.JSONST_8738e857d4fb6695d1e17d4c03428ee2Structure AttrCalendarEvent;

public JSONRC_2796116ff1beb3c001fb57dc12652270() { }

public JSONRC_2796116ff1beb3c001fb57dc12652270 (RC_2796116ff1beb3c001fb57dc12652270 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCalendarEvent = ConvertToRestWithoutDefaults(s.ssSTCalendarEvent, new ST_8738e857d4fb6695d1e17d4c03428ee2Structure(), ssZXingLibDemo.RestRecords.JSONST_8738e857d4fb6695d1e17d4c03428ee2Structure.FromStructureDelegate(config));
  } else {
AttrCalendarEvent = ssZXingLibDemo.RestRecords.JSONST_8738e857d4fb6695d1e17d4c03428ee2Structure.FromStructure(s.ssSTCalendarEvent, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_2796116ff1beb3c001fb57dc12652270, RC_2796116ff1beb3c001fb57dc12652270> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_2796116ff1beb3c001fb57dc12652270 s) => ToStructure(s, config);
}
public static RC_2796116ff1beb3c001fb57dc12652270 ToStructure(ssZXingLibDemo.RestRecords.JSONRC_2796116ff1beb3c001fb57dc12652270 obj, IBehaviorsConfiguration config) { 
  RC_2796116ff1beb3c001fb57dc12652270 s = new RC_2796116ff1beb3c001fb57dc12652270();
  if(obj != null) {
  s.ssSTCalendarEvent = ssZXingLibDemo.RestRecords.JSONST_8738e857d4fb6695d1e17d4c03428ee2Structure.ToStructure(obj.AttrCalendarEvent, config);
  }
  return s;
}

public static Func<RC_2796116ff1beb3c001fb57dc12652270, ssZXingLibDemo.RestRecords.JSONRC_2796116ff1beb3c001fb57dc12652270> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2796116ff1beb3c001fb57dc12652270 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_2796116ff1beb3c001fb57dc12652270 FromStructure(RC_2796116ff1beb3c001fb57dc12652270 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_2796116ff1beb3c001fb57dc12652270(s, config);
}

}


