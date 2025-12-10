using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionOptions
public class RESTST_78b0cd1737b6725aac7ae45759769b93Structure : AbstractRESTStructure<ST_78b0cd1737b6725aac7ae45759769b93Structure> {
[JsonProperty("Origin")]
public string AttrOrigin;

[JsonProperty("Destination")]
public string AttrDestination;

[JsonProperty("TravelMode")]
public string AttrTravelMode;

[JsonProperty("Waypoints")]
public RestList<string> AttrWaypoints;

[JsonProperty("OptimizeWaypoints")]
public bool? AttrOptimizeWaypoints;

[JsonProperty("Exclude")]
public ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure AttrExclude;

public RESTST_78b0cd1737b6725aac7ae45759769b93Structure() { }

public RESTST_78b0cd1737b6725aac7ae45759769b93Structure (ST_78b0cd1737b6725aac7ae45759769b93Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrigin = s.ssOrigin;
AttrDestination = s.ssDestination;
AttrTravelMode = s.ssTravelMode;
AttrWaypoints = s.ssWaypoints.Length == 0 ? null : s.ssWaypoints.ToRestList();
AttrOptimizeWaypoints = ConvertToRestWithoutDefaults(s.ssOptimizeWaypoints, false);
AttrExclude = ConvertToRestWithoutDefaults(s.ssExclude, new ST_78fd8c130caeaf241d821392d1010014Structure(), ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure.FromStructureDelegate(config));
  } else {
AttrOrigin = s.ssOrigin;
AttrDestination = s.ssDestination;
AttrTravelMode = s.ssTravelMode;
AttrWaypoints = s.ssWaypoints.ToRestList();
AttrOptimizeWaypoints = (bool?) s.ssOptimizeWaypoints;
AttrExclude = ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure.FromStructure(s.ssExclude, config);
  }
}

public static ST_78b0cd1737b6725aac7ae45759769b93Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_78b0cd1737b6725aac7ae45759769b93Structure obj) { 
  ST_78b0cd1737b6725aac7ae45759769b93Structure s = new ST_78b0cd1737b6725aac7ae45759769b93Structure();
  if(obj != null) {
  s.ssOrigin = obj.AttrOrigin == null ? "" : obj.AttrOrigin;
  s.ssDestination = obj.AttrDestination == null ? "" : obj.AttrDestination;
  s.ssTravelMode = obj.AttrTravelMode == null ? "" : obj.AttrTravelMode;
  s.ssWaypoints = BasicTypeList<string>.FromRestList(obj.AttrWaypoints);
  s.ssOptimizeWaypoints = obj.AttrOptimizeWaypoints == null ? false : obj.AttrOptimizeWaypoints.Value;
  s.ssExclude = ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure.ToStructure(obj.AttrExclude);
  }
  return s;
}

public static Func<ST_78b0cd1737b6725aac7ae45759769b93Structure, ssOutSystemsMaps.RestRecords.RESTST_78b0cd1737b6725aac7ae45759769b93Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_78b0cd1737b6725aac7ae45759769b93Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_78b0cd1737b6725aac7ae45759769b93Structure FromStructure(ST_78b0cd1737b6725aac7ae45759769b93Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_78b0cd1737b6725aac7ae45759769b93Structure(s, config);
}

}


