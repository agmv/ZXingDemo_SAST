using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerCalendarTypeRecord
public class JSONRC_de3deb221a4b1656cc37f0db973c4e9a : AbstractRESTStructure<RC_de3deb221a4b1656cc37f0db973c4e9a> {
[JsonProperty("DatePickerCalendarType")]
[JsonPropertyName("DatePickerCalendarType")]
public ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord AttrDatePickerCalendarType;

public JSONRC_de3deb221a4b1656cc37f0db973c4e9a() { }

public JSONRC_de3deb221a4b1656cc37f0db973c4e9a (RC_de3deb221a4b1656cc37f0db973c4e9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerCalendarType = ConvertToRestWithoutDefaults(s.ssENDatePickerCalendarType, new EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord.FromStructureDelegate(config));
  } else {
AttrDatePickerCalendarType = ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord.FromStructure(s.ssENDatePickerCalendarType, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_de3deb221a4b1656cc37f0db973c4e9a, RC_de3deb221a4b1656cc37f0db973c4e9a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_de3deb221a4b1656cc37f0db973c4e9a s) => ToStructure(s, config);
}
public static RC_de3deb221a4b1656cc37f0db973c4e9a ToStructure(ssOutSystemsUI.RestRecords.JSONRC_de3deb221a4b1656cc37f0db973c4e9a obj, IBehaviorsConfiguration config) { 
  RC_de3deb221a4b1656cc37f0db973c4e9a s = new RC_de3deb221a4b1656cc37f0db973c4e9a();
  if(obj != null) {
  s.ssENDatePickerCalendarType = ssOutSystemsUI.RestRecords.JSONEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord.ToStructure(obj.AttrDatePickerCalendarType, config);
  }
  return s;
}

public static Func<RC_de3deb221a4b1656cc37f0db973c4e9a, ssOutSystemsUI.RestRecords.JSONRC_de3deb221a4b1656cc37f0db973c4e9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_de3deb221a4b1656cc37f0db973c4e9a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_de3deb221a4b1656cc37f0db973c4e9a FromStructure(RC_de3deb221a4b1656cc37f0db973c4e9a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_de3deb221a4b1656cc37f0db973c4e9a(s, config);
}

}


