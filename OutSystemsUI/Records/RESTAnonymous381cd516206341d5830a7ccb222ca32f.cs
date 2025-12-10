using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthRecord
public class RESTRC_e092deacf9bc8885dd34714ac00f33e4 : AbstractRESTStructure<RC_e092deacf9bc8885dd34714ac00f33e4> {
[JsonProperty("Month")]
public ssOutSystemsUI.RestRecords.RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord AttrMonth;

public RESTRC_e092deacf9bc8885dd34714ac00f33e4() { }

public RESTRC_e092deacf9bc8885dd34714ac00f33e4 (RC_e092deacf9bc8885dd34714ac00f33e4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonth = ConvertToRestWithoutDefaults(s.ssENMonth, new EN_5be8b31925746693c09b3f64c4898006EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord.FromStructureDelegate(config));
  } else {
AttrMonth = ssOutSystemsUI.RestRecords.RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord.FromStructure(s.ssENMonth, config);
  }
}

public static RC_e092deacf9bc8885dd34714ac00f33e4 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_e092deacf9bc8885dd34714ac00f33e4 obj) { 
  RC_e092deacf9bc8885dd34714ac00f33e4 s = new RC_e092deacf9bc8885dd34714ac00f33e4();
  if(obj != null) {
  s.ssENMonth = ssOutSystemsUI.RestRecords.RESTEN_5be8b31925746693c09b3f64c4898006EntityRecord.ToStructure(obj.AttrMonth);
  }
  return s;
}

public static Func<RC_e092deacf9bc8885dd34714ac00f33e4, ssOutSystemsUI.RestRecords.RESTRC_e092deacf9bc8885dd34714ac00f33e4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e092deacf9bc8885dd34714ac00f33e4 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_e092deacf9bc8885dd34714ac00f33e4 FromStructure(RC_e092deacf9bc8885dd34714ac00f33e4 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_e092deacf9bc8885dd34714ac00f33e4(s, config);
}

}


