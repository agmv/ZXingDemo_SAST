using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ExcludeCriteria
public class RESTST_78fd8c130caeaf241d821392d1010014Structure : AbstractRESTStructure<ST_78fd8c130caeaf241d821392d1010014Structure> {
[JsonProperty("AvoidTolls")]
public bool? AttrAvoidTolls;

[JsonProperty("AvoidHighways")]
public bool? AttrAvoidHighways;

[JsonProperty("AvoidFerries")]
public bool? AttrAvoidFerries;

public RESTST_78fd8c130caeaf241d821392d1010014Structure() { }

public RESTST_78fd8c130caeaf241d821392d1010014Structure (ST_78fd8c130caeaf241d821392d1010014Structure s, IBehaviorsConfiguration config) {
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

public static ST_78fd8c130caeaf241d821392d1010014Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure obj) { 
  ST_78fd8c130caeaf241d821392d1010014Structure s = new ST_78fd8c130caeaf241d821392d1010014Structure();
  if(obj != null) {
  s.ssAvoidTolls = obj.AttrAvoidTolls == null ? false : obj.AttrAvoidTolls.Value;
  s.ssAvoidHighways = obj.AttrAvoidHighways == null ? false : obj.AttrAvoidHighways.Value;
  s.ssAvoidFerries = obj.AttrAvoidFerries == null ? false : obj.AttrAvoidFerries.Value;
  }
  return s;
}

public static Func<ST_78fd8c130caeaf241d821392d1010014Structure, ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_78fd8c130caeaf241d821392d1010014Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure FromStructure(ST_78fd8c130caeaf241d821392d1010014Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure(s, config);
}

}


