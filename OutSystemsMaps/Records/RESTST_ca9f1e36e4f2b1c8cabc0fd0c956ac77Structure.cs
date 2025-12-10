using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Points
public class RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure : AbstractRESTStructure<ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure> {
[JsonProperty("Lat")]
public decimal? AttrLat;

[JsonProperty("Lng")]
public decimal? AttrLng;

[JsonProperty("Weight")]
public decimal? AttrWeight;

public RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure() { }

public RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure (ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLat = (decimal?) s.ssLat;
AttrLng = (decimal?) s.ssLng;
AttrWeight = ConvertToRestWithoutDefaults(s.ssWeight, 1.0m);
  } else {
AttrLat = (decimal?) s.ssLat;
AttrLng = (decimal?) s.ssLng;
AttrWeight = (decimal?) s.ssWeight;
  }
}

public static ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure obj) { 
  ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure s = new ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure();
  if(obj != null) {
  s.ssLat = obj.AttrLat == null ? 0.0M : obj.AttrLat.Value;
  s.ssLng = obj.AttrLng == null ? 0.0M : obj.AttrLng.Value;
  s.ssWeight = obj.AttrWeight == null ? 1.0m : obj.AttrWeight.Value;
  }
  return s;
}

public static Func<ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure, ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure FromStructure(ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure(s, config);
}

}


