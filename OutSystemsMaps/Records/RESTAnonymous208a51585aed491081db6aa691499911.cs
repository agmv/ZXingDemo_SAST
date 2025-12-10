using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ErrorMessageRecord
public class RESTRC_098b5b5f4bf19fe0ddbe136503d3bd5a : AbstractRESTStructure<RC_098b5b5f4bf19fe0ddbe136503d3bd5a> {
[JsonProperty("ErrorMessage")]
public ssOutSystemsMaps.RestRecords.RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure AttrErrorMessage;

public RESTRC_098b5b5f4bf19fe0ddbe136503d3bd5a() { }

public RESTRC_098b5b5f4bf19fe0ddbe136503d3bd5a (RC_098b5b5f4bf19fe0ddbe136503d3bd5a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssSTErrorMessage, new ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure(), ssOutSystemsMaps.RestRecords.RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure.FromStructureDelegate(config));
  } else {
AttrErrorMessage = ssOutSystemsMaps.RestRecords.RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure.FromStructure(s.ssSTErrorMessage, config);
  }
}

public static RC_098b5b5f4bf19fe0ddbe136503d3bd5a ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_098b5b5f4bf19fe0ddbe136503d3bd5a obj) { 
  RC_098b5b5f4bf19fe0ddbe136503d3bd5a s = new RC_098b5b5f4bf19fe0ddbe136503d3bd5a();
  if(obj != null) {
  s.ssSTErrorMessage = ssOutSystemsMaps.RestRecords.RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure.ToStructure(obj.AttrErrorMessage);
  }
  return s;
}

public static Func<RC_098b5b5f4bf19fe0ddbe136503d3bd5a, ssOutSystemsMaps.RestRecords.RESTRC_098b5b5f4bf19fe0ddbe136503d3bd5a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_098b5b5f4bf19fe0ddbe136503d3bd5a s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_098b5b5f4bf19fe0ddbe136503d3bd5a FromStructure(RC_098b5b5f4bf19fe0ddbe136503d3bd5a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_098b5b5f4bf19fe0ddbe136503d3bd5a(s, config);
}

}


