using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchArea
public class RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure : AbstractRESTStructure<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> {
[JsonProperty("North")]
public string AttrNorth;

[JsonProperty("South")]
public string AttrSouth;

[JsonProperty("West")]
public string AttrWest;

[JsonProperty("East")]
public string AttrEast;

public RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure() { }

public RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s, IBehaviorsConfiguration config) {
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

public static ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure obj) { 
  ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s = new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure();
  if(obj != null) {
  s.ssNorth = obj.AttrNorth == null ? "" : obj.AttrNorth;
  s.ssSouth = obj.AttrSouth == null ? "" : obj.AttrSouth;
  s.ssWest = obj.AttrWest == null ? "" : obj.AttrWest;
  s.ssEast = obj.AttrEast == null ? "" : obj.AttrEast;
  }
  return s;
}

public static Func<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure, ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure FromStructure(ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure(s, config);
}

}


