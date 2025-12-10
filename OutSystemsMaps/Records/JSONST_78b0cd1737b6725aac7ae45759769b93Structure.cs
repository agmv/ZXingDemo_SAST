using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionOptions
public class JSONST_78b0cd1737b6725aac7ae45759769b93Structure : AbstractRESTStructure<ST_78b0cd1737b6725aac7ae45759769b93Structure> {
[JsonProperty("originRoute")]
[JsonPropertyName("originRoute")]
public string AttrOrigin;

[JsonProperty("destinationRoute")]
[JsonPropertyName("destinationRoute")]
public string AttrDestination;

[JsonProperty("travelMode")]
[JsonPropertyName("travelMode")]
public string AttrTravelMode;

[JsonProperty("waypoints")]
[JsonPropertyName("waypoints")]
public string[] AttrWaypoints;

[JsonProperty("optimizeWaypoints")]
[JsonPropertyName("optimizeWaypoints")]
public bool? AttrOptimizeWaypoints;

[JsonProperty("exclude")]
[JsonPropertyName("exclude")]
public ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure AttrExclude;

public JSONST_78b0cd1737b6725aac7ae45759769b93Structure() { }

public JSONST_78b0cd1737b6725aac7ae45759769b93Structure (ST_78b0cd1737b6725aac7ae45759769b93Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrigin = s.ssOrigin;
AttrDestination = s.ssDestination;
AttrTravelMode = s.ssTravelMode;
AttrWaypoints = s.ssWaypoints.Length == 0 ? null : s.ssWaypoints.ToArray();
AttrOptimizeWaypoints = ConvertToRestWithoutDefaults(s.ssOptimizeWaypoints, false);
AttrExclude = ConvertToRestWithoutDefaults(s.ssExclude, new ST_78fd8c130caeaf241d821392d1010014Structure(), ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure.FromStructureDelegate(config));
  } else {
AttrOrigin = s.ssOrigin;
AttrDestination = s.ssDestination;
AttrTravelMode = s.ssTravelMode;
AttrWaypoints = s.ssWaypoints.ToArray();
AttrOptimizeWaypoints = (bool?) s.ssOptimizeWaypoints;
AttrExclude = ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure.FromStructure(s.ssExclude, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure, ST_78b0cd1737b6725aac7ae45759769b93Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure s) => ToStructure(s, config);
}
public static ST_78b0cd1737b6725aac7ae45759769b93Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure obj, IBehaviorsConfiguration config) { 
  ST_78b0cd1737b6725aac7ae45759769b93Structure s = new ST_78b0cd1737b6725aac7ae45759769b93Structure();
  if(obj != null) {
  s.ssOrigin = obj.AttrOrigin == null ? "" : obj.AttrOrigin;
  s.ssDestination = obj.AttrDestination == null ? "" : obj.AttrDestination;
  s.ssTravelMode = obj.AttrTravelMode == null ? "" : obj.AttrTravelMode;
  s.ssWaypoints = BasicTypeList<string>.ToList(obj.AttrWaypoints);
  s.ssOptimizeWaypoints = obj.AttrOptimizeWaypoints == null ? false : obj.AttrOptimizeWaypoints.Value;
  s.ssExclude = ssOutSystemsMaps.RestRecords.JSONST_78fd8c130caeaf241d821392d1010014Structure.ToStructure(obj.AttrExclude, config);
  }
  return s;
}

public static Func<ST_78b0cd1737b6725aac7ae45759769b93Structure, ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_78b0cd1737b6725aac7ae45759769b93Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure FromStructure(ST_78b0cd1737b6725aac7ae45759769b93Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure(s, config);
}

}


