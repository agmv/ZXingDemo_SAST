using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalFileLayerConfigs
public class RESTST_2bb06e37aea9715ba999f70106cf37a5Structure : AbstractRESTStructure<ST_2bb06e37aea9715ba999f70106cf37a5Structure> {
[JsonProperty("SuppressPopups")]
public bool? AttrSuppressPopups;

[JsonProperty("PreserveViewport")]
public bool? AttrPreserveViewport;

public RESTST_2bb06e37aea9715ba999f70106cf37a5Structure() { }

public RESTST_2bb06e37aea9715ba999f70106cf37a5Structure (ST_2bb06e37aea9715ba999f70106cf37a5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuppressPopups = ConvertToRestWithoutDefaults(s.ssSuppressPopups, false);
AttrPreserveViewport = ConvertToRestWithoutDefaults(s.ssPreserveViewport, false);
  } else {
AttrSuppressPopups = (bool?) s.ssSuppressPopups;
AttrPreserveViewport = (bool?) s.ssPreserveViewport;
  }
}

public static ST_2bb06e37aea9715ba999f70106cf37a5Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_2bb06e37aea9715ba999f70106cf37a5Structure obj) { 
  ST_2bb06e37aea9715ba999f70106cf37a5Structure s = new ST_2bb06e37aea9715ba999f70106cf37a5Structure();
  if(obj != null) {
  s.ssSuppressPopups = obj.AttrSuppressPopups == null ? false : obj.AttrSuppressPopups.Value;
  s.ssPreserveViewport = obj.AttrPreserveViewport == null ? false : obj.AttrPreserveViewport.Value;
  }
  return s;
}

public static Func<ST_2bb06e37aea9715ba999f70106cf37a5Structure, ssOutSystemsMaps.RestRecords.RESTST_2bb06e37aea9715ba999f70106cf37a5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2bb06e37aea9715ba999f70106cf37a5Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_2bb06e37aea9715ba999f70106cf37a5Structure FromStructure(ST_2bb06e37aea9715ba999f70106cf37a5Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_2bb06e37aea9715ba999f70106cf37a5Structure(s, config);
}

}


