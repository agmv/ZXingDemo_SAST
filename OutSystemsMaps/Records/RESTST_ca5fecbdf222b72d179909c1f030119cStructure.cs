using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_heatmapLayer_configs
public class RESTST_ca5fecbdf222b72d179909c1f030119cStructure : AbstractRESTStructure<ST_ca5fecbdf222b72d179909c1f030119cStructure> {
[JsonProperty("points")]
public RestList<ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure> Attrpoints;

[JsonProperty("maxIntensity")]
public decimal? AttrmaxIntensity;

[JsonProperty("opacity")]
public decimal? Attropacity;

[JsonProperty("radius")]
public int? Attrradius;

[JsonProperty("dissipateOnZoom")]
public bool? AttrdissipateOnZoom;

[JsonProperty("gradient")]
public RestList<string> Attrgradient;

public RESTST_ca5fecbdf222b72d179909c1f030119cStructure() { }

public RESTST_ca5fecbdf222b72d179909c1f030119cStructure (ST_ca5fecbdf222b72d179909c1f030119cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrpoints = s.sspoints.Length == 0 ? null : s.sspoints.ToRestList<ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure>(ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.FromStructureDelegate(config));
AttrmaxIntensity = ConvertToRestWithoutDefaults(s.ssmaxIntensity, (new Decimal (0)));
Attropacity = ConvertToRestWithoutDefaults(s.ssopacity, (new Decimal (0)));
Attrradius = ConvertToRestWithoutDefaults(s.ssradius, 0);
AttrdissipateOnZoom = ConvertToRestWithoutDefaults(s.ssdissipateOnZoom, true);
Attrgradient = s.ssgradient.Length == 0 ? null : s.ssgradient.ToRestList();
  } else {
Attrpoints = s.sspoints.ToRestList<ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure>(ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.FromStructureDelegate(config));
AttrmaxIntensity = (decimal?) s.ssmaxIntensity;
Attropacity = (decimal?) s.ssopacity;
Attrradius = (int?) s.ssradius;
AttrdissipateOnZoom = (bool?) s.ssdissipateOnZoom;
Attrgradient = s.ssgradient.ToRestList();
  }
}

public static ST_ca5fecbdf222b72d179909c1f030119cStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure obj) { 
  ST_ca5fecbdf222b72d179909c1f030119cStructure s = new ST_ca5fecbdf222b72d179909c1f030119cStructure();
  if(obj != null) {
  s.sspoints = RL_3e9d003efe19bfd5edf008a600c8d3af.FromRestList(obj.Attrpoints, ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.ToStructure);
  s.ssmaxIntensity = obj.AttrmaxIntensity == null ? (new Decimal (0)) : obj.AttrmaxIntensity.Value;
  s.ssopacity = obj.Attropacity == null ? (new Decimal (0)) : obj.Attropacity.Value;
  s.ssradius = obj.Attrradius == null ? 0 : obj.Attrradius.Value;
  s.ssdissipateOnZoom = obj.AttrdissipateOnZoom == null ? true : obj.AttrdissipateOnZoom.Value;
  s.ssgradient = BasicTypeList<string>.FromRestList(obj.Attrgradient);
  }
  return s;
}

public static Func<ST_ca5fecbdf222b72d179909c1f030119cStructure, ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ca5fecbdf222b72d179909c1f030119cStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure FromStructure(ST_ca5fecbdf222b72d179909c1f030119cStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure(s, config);
}

}


