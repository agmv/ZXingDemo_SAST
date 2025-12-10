using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerWeekDayRecord
public class JSONRC_210f541f43ec6384ba59bfd8fe4b8837 : AbstractRESTStructure<RC_210f541f43ec6384ba59bfd8fe4b8837> {
[JsonProperty("DatePickerWeekDay")]
[JsonPropertyName("DatePickerWeekDay")]
public ssOutSystemsUI.RestRecords.JSONEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord AttrDatePickerWeekDay;

public JSONRC_210f541f43ec6384ba59bfd8fe4b8837() { }

public JSONRC_210f541f43ec6384ba59bfd8fe4b8837 (RC_210f541f43ec6384ba59bfd8fe4b8837 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerWeekDay = ConvertToRestWithoutDefaults(s.ssENDatePickerWeekDay, new EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord.FromStructureDelegate(config));
  } else {
AttrDatePickerWeekDay = ssOutSystemsUI.RestRecords.JSONEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord.FromStructure(s.ssENDatePickerWeekDay, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_210f541f43ec6384ba59bfd8fe4b8837, RC_210f541f43ec6384ba59bfd8fe4b8837> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_210f541f43ec6384ba59bfd8fe4b8837 s) => ToStructure(s, config);
}
public static RC_210f541f43ec6384ba59bfd8fe4b8837 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_210f541f43ec6384ba59bfd8fe4b8837 obj, IBehaviorsConfiguration config) { 
  RC_210f541f43ec6384ba59bfd8fe4b8837 s = new RC_210f541f43ec6384ba59bfd8fe4b8837();
  if(obj != null) {
  s.ssENDatePickerWeekDay = ssOutSystemsUI.RestRecords.JSONEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord.ToStructure(obj.AttrDatePickerWeekDay, config);
  }
  return s;
}

public static Func<RC_210f541f43ec6384ba59bfd8fe4b8837, ssOutSystemsUI.RestRecords.JSONRC_210f541f43ec6384ba59bfd8fe4b8837> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_210f541f43ec6384ba59bfd8fe4b8837 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_210f541f43ec6384ba59bfd8fe4b8837 FromStructure(RC_210f541f43ec6384ba59bfd8fe4b8837 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_210f541f43ec6384ba59bfd8fe4b8837(s, config);
}

}


