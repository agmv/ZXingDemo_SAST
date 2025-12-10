using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_drawNotFilledShape_configs
public class RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure : AbstractRESTStructure<ST_86d2610e9625abf0ecb7241e6d8099fbStructure> {
[JsonProperty("allowDrag")]
public bool? AttrallowDrag;

[JsonProperty("allowEdit")]
public bool? AttrallowEdit;

[JsonProperty("strokeColor")]
public string AttrstrokeColor;

[JsonProperty("strokeOpacity")]
public decimal? AttrstrokeOpacity;

[JsonProperty("strokeWeight")]
public int? AttrstrokeWeight;

public RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure() { }

public RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure (ST_86d2610e9625abf0ecb7241e6d8099fbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrallowDrag = ConvertToRestWithoutDefaults(s.ssallowDrag, false);
AttrallowEdit = ConvertToRestWithoutDefaults(s.ssallowEdit, false);
AttrstrokeColor = s.ssstrokeColor;
AttrstrokeOpacity = (decimal?) s.ssstrokeOpacity;
AttrstrokeWeight = (int?) s.ssstrokeWeight;
  } else {
AttrallowDrag = (bool?) s.ssallowDrag;
AttrallowEdit = (bool?) s.ssallowEdit;
AttrstrokeColor = s.ssstrokeColor;
AttrstrokeOpacity = (decimal?) s.ssstrokeOpacity;
AttrstrokeWeight = (int?) s.ssstrokeWeight;
  }
}

public static ST_86d2610e9625abf0ecb7241e6d8099fbStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure obj) { 
  ST_86d2610e9625abf0ecb7241e6d8099fbStructure s = new ST_86d2610e9625abf0ecb7241e6d8099fbStructure();
  if(obj != null) {
  s.ssallowDrag = obj.AttrallowDrag == null ? false : obj.AttrallowDrag.Value;
  s.ssallowEdit = obj.AttrallowEdit == null ? false : obj.AttrallowEdit.Value;
  s.ssstrokeColor = obj.AttrstrokeColor == null ? "#000000" : obj.AttrstrokeColor;
  s.ssstrokeOpacity = obj.AttrstrokeOpacity == null ? (((decimal)1)) : obj.AttrstrokeOpacity.Value;
  s.ssstrokeWeight = obj.AttrstrokeWeight == null ? 2 : obj.AttrstrokeWeight.Value;
  }
  return s;
}

public static Func<ST_86d2610e9625abf0ecb7241e6d8099fbStructure, ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_86d2610e9625abf0ecb7241e6d8099fbStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure FromStructure(ST_86d2610e9625abf0ecb7241e6d8099fbStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure(s, config);
}

}


