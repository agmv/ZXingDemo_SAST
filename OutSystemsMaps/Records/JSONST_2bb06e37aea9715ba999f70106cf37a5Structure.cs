using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalFileLayerConfigs
public class JSONST_2bb06e37aea9715ba999f70106cf37a5Structure : AbstractRESTStructure<ST_2bb06e37aea9715ba999f70106cf37a5Structure> {
[JsonProperty("SuppressPopups")]
[JsonPropertyName("SuppressPopups")]
public bool? AttrSuppressPopups;

[JsonProperty("PreserveViewport")]
[JsonPropertyName("PreserveViewport")]
public bool? AttrPreserveViewport;

public JSONST_2bb06e37aea9715ba999f70106cf37a5Structure() { }

public JSONST_2bb06e37aea9715ba999f70106cf37a5Structure (ST_2bb06e37aea9715ba999f70106cf37a5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuppressPopups = ConvertToRestWithoutDefaults(s.ssSuppressPopups, false);
AttrPreserveViewport = ConvertToRestWithoutDefaults(s.ssPreserveViewport, false);
  } else {
AttrSuppressPopups = (bool?) s.ssSuppressPopups;
AttrPreserveViewport = (bool?) s.ssPreserveViewport;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_2bb06e37aea9715ba999f70106cf37a5Structure, ST_2bb06e37aea9715ba999f70106cf37a5Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_2bb06e37aea9715ba999f70106cf37a5Structure s) => ToStructure(s, config);
}
public static ST_2bb06e37aea9715ba999f70106cf37a5Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_2bb06e37aea9715ba999f70106cf37a5Structure obj, IBehaviorsConfiguration config) { 
  ST_2bb06e37aea9715ba999f70106cf37a5Structure s = new ST_2bb06e37aea9715ba999f70106cf37a5Structure();
  if(obj != null) {
  s.ssSuppressPopups = obj.AttrSuppressPopups == null ? false : obj.AttrSuppressPopups.Value;
  s.ssPreserveViewport = obj.AttrPreserveViewport == null ? false : obj.AttrPreserveViewport.Value;
  }
  return s;
}

public static Func<ST_2bb06e37aea9715ba999f70106cf37a5Structure, ssOutSystemsMaps.RestRecords.JSONST_2bb06e37aea9715ba999f70106cf37a5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2bb06e37aea9715ba999f70106cf37a5Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_2bb06e37aea9715ba999f70106cf37a5Structure FromStructure(ST_2bb06e37aea9715ba999f70106cf37a5Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_2bb06e37aea9715ba999f70106cf37a5Structure(s, config);
}

}


