using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthYearRecord
public class JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef : AbstractRESTStructure<RC_4835a3b0a2d4ab28e154f8a8831a00ef> {
[JsonProperty("MonthYear")]
[JsonPropertyName("MonthYear")]
public ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure AttrMonthYear;

public JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef() { }

public JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef (RC_4835a3b0a2d4ab28e154f8a8831a00ef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonthYear = ConvertToRestWithoutDefaults(s.ssSTMonthYear, new ST_5c08eaa15b890a2d617cabe547c34f0bStructure(), ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructureDelegate(config));
  } else {
AttrMonthYear = ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.FromStructure(s.ssSTMonthYear, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef, RC_4835a3b0a2d4ab28e154f8a8831a00ef> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef s) => ToStructure(s, config);
}
public static RC_4835a3b0a2d4ab28e154f8a8831a00ef ToStructure(ssOutSystemsUI.RestRecords.JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef obj, IBehaviorsConfiguration config) { 
  RC_4835a3b0a2d4ab28e154f8a8831a00ef s = new RC_4835a3b0a2d4ab28e154f8a8831a00ef();
  if(obj != null) {
  s.ssSTMonthYear = ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure.ToStructure(obj.AttrMonthYear, config);
  }
  return s;
}

public static Func<RC_4835a3b0a2d4ab28e154f8a8831a00ef, ssOutSystemsUI.RestRecords.JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4835a3b0a2d4ab28e154f8a8831a00ef s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef FromStructure(RC_4835a3b0a2d4ab28e154f8a8831a00ef s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_4835a3b0a2d4ab28e154f8a8831a00ef(s, config);
}

}


