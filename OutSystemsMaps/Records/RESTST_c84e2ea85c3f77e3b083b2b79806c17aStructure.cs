using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalHeatmapLayerConfigs
public class RESTST_c84e2ea85c3f77e3b083b2b79806c17aStructure : AbstractRESTStructure<ST_c84e2ea85c3f77e3b083b2b79806c17aStructure> {
[JsonProperty("MaxIntensity")]
public decimal? AttrMaxIntensity;

[JsonProperty("Opacity")]
public decimal? AttrOpacity;

[JsonProperty("Radius")]
public int? AttrRadius;

[JsonProperty("DissipateOnZoom")]
public bool? AttrDissipateOnZoom;

[JsonProperty("Gradient")]
public RestList<string> AttrGradient;

public RESTST_c84e2ea85c3f77e3b083b2b79806c17aStructure() { }

public RESTST_c84e2ea85c3f77e3b083b2b79806c17aStructure (ST_c84e2ea85c3f77e3b083b2b79806c17aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMaxIntensity = ConvertToRestWithoutDefaults(s.ssMaxIntensity, 0.0M);
AttrOpacity = ConvertToRestWithoutDefaults(s.ssOpacity, 0.6m);
AttrRadius = ConvertToRestWithoutDefaults(s.ssRadius, 3);
AttrDissipateOnZoom = ConvertToRestWithoutDefaults(s.ssDissipateOnZoom, true);
AttrGradient = s.ssGradient.Length == 0 ? null : s.ssGradient.ToRestList();
  } else {
AttrMaxIntensity = (decimal?) s.ssMaxIntensity;
AttrOpacity = (decimal?) s.ssOpacity;
AttrRadius = (int?) s.ssRadius;
AttrDissipateOnZoom = (bool?) s.ssDissipateOnZoom;
AttrGradient = s.ssGradient.ToRestList();
  }
}

public static ST_c84e2ea85c3f77e3b083b2b79806c17aStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_c84e2ea85c3f77e3b083b2b79806c17aStructure obj) { 
  ST_c84e2ea85c3f77e3b083b2b79806c17aStructure s = new ST_c84e2ea85c3f77e3b083b2b79806c17aStructure();
  if(obj != null) {
  s.ssMaxIntensity = obj.AttrMaxIntensity == null ? 0.0M : obj.AttrMaxIntensity.Value;
  s.ssOpacity = obj.AttrOpacity == null ? 0.6m : obj.AttrOpacity.Value;
  s.ssRadius = obj.AttrRadius == null ? 3 : obj.AttrRadius.Value;
  s.ssDissipateOnZoom = obj.AttrDissipateOnZoom == null ? true : obj.AttrDissipateOnZoom.Value;
  s.ssGradient = BasicTypeList<string>.FromRestList(obj.AttrGradient);
  }
  return s;
}

public static Func<ST_c84e2ea85c3f77e3b083b2b79806c17aStructure, ssOutSystemsMaps.RestRecords.RESTST_c84e2ea85c3f77e3b083b2b79806c17aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c84e2ea85c3f77e3b083b2b79806c17aStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_c84e2ea85c3f77e3b083b2b79806c17aStructure FromStructure(ST_c84e2ea85c3f77e3b083b2b79806c17aStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_c84e2ea85c3f77e3b083b2b79806c17aStructure(s, config);
}

}


