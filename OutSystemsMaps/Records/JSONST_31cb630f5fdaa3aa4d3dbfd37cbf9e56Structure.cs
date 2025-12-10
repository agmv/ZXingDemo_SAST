using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchArea
public class JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure : AbstractRESTStructure<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> {
[JsonProperty("north")]
[JsonPropertyName("north")]
public string AttrNorth;

[JsonProperty("south")]
[JsonPropertyName("south")]
public string AttrSouth;

[JsonProperty("west")]
[JsonPropertyName("west")]
public string AttrWest;

[JsonProperty("east")]
[JsonPropertyName("east")]
public string AttrEast;

public JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure() { }

public JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNorth = s.ssNorth;
AttrSouth = s.ssSouth;
AttrWest = s.ssWest;
AttrEast = s.ssEast;
  } else {
AttrNorth = s.ssNorth;
AttrSouth = s.ssSouth;
AttrWest = s.ssWest;
AttrEast = s.ssEast;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure, ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s) => ToStructure(s, config);
}
public static ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure obj, IBehaviorsConfiguration config) { 
  ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s = new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure();
  if(obj != null) {
  s.ssNorth = obj.AttrNorth == null ? "" : obj.AttrNorth;
  s.ssSouth = obj.AttrSouth == null ? "" : obj.AttrSouth;
  s.ssWest = obj.AttrWest == null ? "" : obj.AttrWest;
  s.ssEast = obj.AttrEast == null ? "" : obj.AttrEast;
  }
  return s;
}

public static Func<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure, ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure FromStructure(ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure(s, config);
}

}


