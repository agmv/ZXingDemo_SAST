using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ExcludeCriteria
public class JSONST_78fd8c130caeaf241d821392d1010014Structure : AbstractRESTStructure<ST_78fd8c130caeaf241d821392d1010014Structure> {
[JsonProperty("avoidTolls")]
[JsonPropertyName("avoidTolls")]
public bool? AttrAvoidTolls;

[JsonProperty("avoidHighways")]
[JsonPropertyName("avoidHighways")]
public bool? AttrAvoidHighways;

[JsonProperty("avoidFerries")]
[JsonPropertyName("avoidFerries")]
public bool? AttrAvoidFerries;

public JSONST_78fd8c130caeaf241d821392d1010014Structure() { }

public JSONST_78fd8c130caeaf241d821392d1010014Structure (ST_78fd8c130caeaf241d821392d1010014Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAvoidTolls = ConvertToRestWithoutDefaults(s.ssAvoidTolls, false);
AttrAvoidHighways = ConvertToRestWithoutDefaults(s.ssAvoidHighways, false);
AttrAvoidFerries = ConvertToRestWithoutDefaults(s.ssAvoidFerries, false);
  } else {
AttrAvoidTolls = (bool?) s.ssAvoidTolls;
AttrAvoidHighways = (bool?) s.ssAvoidHighways;
AttrAvoidFerries = (bool?) s.ssAvoidFerries;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure, ST_78fd8c130caeaf241d821392d1010014Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure s) => ToStructure(s, config);
}
public static ST_78fd8c130caeaf241d821392d1010014Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure obj, IBehaviorsConfiguration config) { 
  ST_78fd8c130caeaf241d821392d1010014Structure s = new ST_78fd8c130caeaf241d821392d1010014Structure();
  if(obj != null) {
  s.ssAvoidTolls = obj.AttrAvoidTolls == null ? false : obj.AttrAvoidTolls.Value;
  s.ssAvoidHighways = obj.AttrAvoidHighways == null ? false : obj.AttrAvoidHighways.Value;
  s.ssAvoidFerries = obj.AttrAvoidFerries == null ? false : obj.AttrAvoidFerries.Value;
  }
  return s;
}

public static Func<ST_78fd8c130caeaf241d821392d1010014Structure, ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_78fd8c130caeaf241d821392d1010014Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure FromStructure(ST_78fd8c130caeaf241d821392d1010014Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure(s, config);
}

}


