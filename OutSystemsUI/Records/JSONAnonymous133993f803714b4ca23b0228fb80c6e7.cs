using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerRange_InternalConfigRecord
public class JSONRC_1d16add6c65a995967ac402e66fde3ff : AbstractRESTStructure<RC_1d16add6c65a995967ac402e66fde3ff> {
[JsonProperty("DatePickerRange_InternalConfig")]
[JsonPropertyName("DatePickerRange_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure AttrDatePickerRange_InternalConfig;

public JSONRC_1d16add6c65a995967ac402e66fde3ff() { }

public JSONRC_1d16add6c65a995967ac402e66fde3ff (RC_1d16add6c65a995967ac402e66fde3ff s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerRange_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTDatePickerRange_InternalConfig, new ST_256310aee13520906f2ba115af101f62Structure(), ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure.FromStructureDelegate(config));
  } else {
AttrDatePickerRange_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure.FromStructure(s.ssSTDatePickerRange_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_1d16add6c65a995967ac402e66fde3ff, RC_1d16add6c65a995967ac402e66fde3ff> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_1d16add6c65a995967ac402e66fde3ff s) => ToStructure(s, config);
}
public static RC_1d16add6c65a995967ac402e66fde3ff ToStructure(ssOutSystemsUI.RestRecords.JSONRC_1d16add6c65a995967ac402e66fde3ff obj, IBehaviorsConfiguration config) { 
  RC_1d16add6c65a995967ac402e66fde3ff s = new RC_1d16add6c65a995967ac402e66fde3ff();
  if(obj != null) {
  s.ssSTDatePickerRange_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure.ToStructure(obj.AttrDatePickerRange_InternalConfig, config);
  }
  return s;
}

public static Func<RC_1d16add6c65a995967ac402e66fde3ff, ssOutSystemsUI.RestRecords.JSONRC_1d16add6c65a995967ac402e66fde3ff> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1d16add6c65a995967ac402e66fde3ff s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_1d16add6c65a995967ac402e66fde3ff FromStructure(RC_1d16add6c65a995967ac402e66fde3ff s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_1d16add6c65a995967ac402e66fde3ff(s, config);
}

}


