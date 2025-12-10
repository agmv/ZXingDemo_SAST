using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_heatmapLayer_configs
public class JSONST_ca5fecbdf222b72d179909c1f030119cStructure : AbstractRESTStructure<ST_ca5fecbdf222b72d179909c1f030119cStructure> {
[JsonProperty("points")]
[JsonPropertyName("points")]
public ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure[] Attrpoints;

[JsonProperty("maxIntensity")]
[JsonPropertyName("maxIntensity")]
public decimal? AttrmaxIntensity;

[JsonProperty("opacity")]
[JsonPropertyName("opacity")]
public decimal? Attropacity;

[JsonProperty("radius")]
[JsonPropertyName("radius")]
public int? Attrradius;

[JsonProperty("dissipateOnZoom")]
[JsonPropertyName("dissipateOnZoom")]
public bool? AttrdissipateOnZoom;

[JsonProperty("gradient")]
[JsonPropertyName("gradient")]
public string[] Attrgradient;

public JSONST_ca5fecbdf222b72d179909c1f030119cStructure() { }

public JSONST_ca5fecbdf222b72d179909c1f030119cStructure (ST_ca5fecbdf222b72d179909c1f030119cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrpoints = s.sspoints.Length == 0 ? null : s.sspoints.ToArray<ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure>(ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.FromStructureDelegate(config));
AttrmaxIntensity = ConvertToRestWithoutDefaults(s.ssmaxIntensity, (new Decimal (0)));
Attropacity = ConvertToRestWithoutDefaults(s.ssopacity, (new Decimal (0)));
Attrradius = ConvertToRestWithoutDefaults(s.ssradius, 0);
AttrdissipateOnZoom = ConvertToRestWithoutDefaults(s.ssdissipateOnZoom, true);
Attrgradient = s.ssgradient.Length == 0 ? null : s.ssgradient.ToArray();
  } else {
Attrpoints = s.sspoints.ToArray<ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure>(ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.FromStructureDelegate(config));
AttrmaxIntensity = (decimal?) s.ssmaxIntensity;
Attropacity = (decimal?) s.ssopacity;
Attrradius = (int?) s.ssradius;
AttrdissipateOnZoom = (bool?) s.ssdissipateOnZoom;
Attrgradient = s.ssgradient.ToArray();
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_ca5fecbdf222b72d179909c1f030119cStructure, ST_ca5fecbdf222b72d179909c1f030119cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_ca5fecbdf222b72d179909c1f030119cStructure s) => ToStructure(s, config);
}
public static ST_ca5fecbdf222b72d179909c1f030119cStructure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_ca5fecbdf222b72d179909c1f030119cStructure obj, IBehaviorsConfiguration config) { 
  ST_ca5fecbdf222b72d179909c1f030119cStructure s = new ST_ca5fecbdf222b72d179909c1f030119cStructure();
  if(obj != null) {
  s.sspoints = RL_3e9d003efe19bfd5edf008a600c8d3af.ToList(obj.Attrpoints, ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.ToStructureDelegate(config));
  s.ssmaxIntensity = obj.AttrmaxIntensity == null ? (new Decimal (0)) : obj.AttrmaxIntensity.Value;
  s.ssopacity = obj.Attropacity == null ? (new Decimal (0)) : obj.Attropacity.Value;
  s.ssradius = obj.Attrradius == null ? 0 : obj.Attrradius.Value;
  s.ssdissipateOnZoom = obj.AttrdissipateOnZoom == null ? true : obj.AttrdissipateOnZoom.Value;
  s.ssgradient = BasicTypeList<string>.ToList(obj.Attrgradient);
  }
  return s;
}

public static Func<ST_ca5fecbdf222b72d179909c1f030119cStructure, ssOutSystemsMaps.RestRecords.JSONST_ca5fecbdf222b72d179909c1f030119cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ca5fecbdf222b72d179909c1f030119cStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_ca5fecbdf222b72d179909c1f030119cStructure FromStructure(ST_ca5fecbdf222b72d179909c1f030119cStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_ca5fecbdf222b72d179909c1f030119cStructure(s, config);
}

}


