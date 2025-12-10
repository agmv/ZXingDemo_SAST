using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerCalendarTypeRecord
public class RESTRC_de3deb221a4b1656cc37f0db973c4e9a : AbstractRESTStructure<RC_de3deb221a4b1656cc37f0db973c4e9a> {
[JsonProperty("DatePickerCalendarType")]
public ssOutSystemsUI.RestRecords.RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord AttrDatePickerCalendarType;

public RESTRC_de3deb221a4b1656cc37f0db973c4e9a() { }

public RESTRC_de3deb221a4b1656cc37f0db973c4e9a (RC_de3deb221a4b1656cc37f0db973c4e9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerCalendarType = ConvertToRestWithoutDefaults(s.ssENDatePickerCalendarType, new EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord.FromStructureDelegate(config));
  } else {
AttrDatePickerCalendarType = ssOutSystemsUI.RestRecords.RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord.FromStructure(s.ssENDatePickerCalendarType, config);
  }
}

public static RC_de3deb221a4b1656cc37f0db973c4e9a ToStructure(ssOutSystemsUI.RestRecords.RESTRC_de3deb221a4b1656cc37f0db973c4e9a obj) { 
  RC_de3deb221a4b1656cc37f0db973c4e9a s = new RC_de3deb221a4b1656cc37f0db973c4e9a();
  if(obj != null) {
  s.ssENDatePickerCalendarType = ssOutSystemsUI.RestRecords.RESTEN_c521eea762e9dd37e04340f2864e8aa0EntityRecord.ToStructure(obj.AttrDatePickerCalendarType);
  }
  return s;
}

public static Func<RC_de3deb221a4b1656cc37f0db973c4e9a, ssOutSystemsUI.RestRecords.RESTRC_de3deb221a4b1656cc37f0db973c4e9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_de3deb221a4b1656cc37f0db973c4e9a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_de3deb221a4b1656cc37f0db973c4e9a FromStructure(RC_de3deb221a4b1656cc37f0db973c4e9a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_de3deb221a4b1656cc37f0db973c4e9a(s, config);
}

}


