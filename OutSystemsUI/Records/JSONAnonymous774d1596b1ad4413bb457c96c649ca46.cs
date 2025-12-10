using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerTimeFormatRecord
public class JSONRC_51b1c15949308af5f9b2dba7043d5ae6 : AbstractRESTStructure<RC_51b1c15949308af5f9b2dba7043d5ae6> {
[JsonProperty("DatePickerTimeFormat")]
[JsonPropertyName("DatePickerTimeFormat")]
public ssOutSystemsUI.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord AttrDatePickerTimeFormat;

public JSONRC_51b1c15949308af5f9b2dba7043d5ae6() { }

public JSONRC_51b1c15949308af5f9b2dba7043d5ae6 (RC_51b1c15949308af5f9b2dba7043d5ae6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerTimeFormat = ConvertToRestWithoutDefaults(s.ssENDatePickerTimeFormat, new EN_b4e36c9529d7446e086560192df48d7cEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord.FromStructureDelegate(config));
  } else {
AttrDatePickerTimeFormat = ssOutSystemsUI.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord.FromStructure(s.ssENDatePickerTimeFormat, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_51b1c15949308af5f9b2dba7043d5ae6, RC_51b1c15949308af5f9b2dba7043d5ae6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_51b1c15949308af5f9b2dba7043d5ae6 s) => ToStructure(s, config);
}
public static RC_51b1c15949308af5f9b2dba7043d5ae6 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_51b1c15949308af5f9b2dba7043d5ae6 obj, IBehaviorsConfiguration config) { 
  RC_51b1c15949308af5f9b2dba7043d5ae6 s = new RC_51b1c15949308af5f9b2dba7043d5ae6();
  if(obj != null) {
  s.ssENDatePickerTimeFormat = ssOutSystemsUI.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord.ToStructure(obj.AttrDatePickerTimeFormat, config);
  }
  return s;
}

public static Func<RC_51b1c15949308af5f9b2dba7043d5ae6, ssOutSystemsUI.RestRecords.JSONRC_51b1c15949308af5f9b2dba7043d5ae6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_51b1c15949308af5f9b2dba7043d5ae6 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_51b1c15949308af5f9b2dba7043d5ae6 FromStructure(RC_51b1c15949308af5f9b2dba7043d5ae6 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_51b1c15949308af5f9b2dba7043d5ae6(s, config);
}

}


