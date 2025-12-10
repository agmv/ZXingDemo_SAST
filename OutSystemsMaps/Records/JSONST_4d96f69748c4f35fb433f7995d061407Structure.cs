using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_shape_configs
public class JSONST_4d96f69748c4f35fb433f7995d061407Structure : AbstractRESTStructure<ST_4d96f69748c4f35fb433f7995d061407Structure> {
[JsonProperty("locations")]
[JsonPropertyName("locations")]
public string Attrlocations;

[JsonProperty("center")]
[JsonPropertyName("center")]
public string Attrcenter;

[JsonProperty("bounds")]
[JsonPropertyName("bounds")]
public string Attrbounds;

[JsonProperty("radius")]
[JsonPropertyName("radius")]
public int? Attrradius;

[JsonProperty("allowDrag")]
[JsonPropertyName("allowDrag")]
public bool? AttrallowDrag;

[JsonProperty("allowEdit")]
[JsonPropertyName("allowEdit")]
public bool? AttrallowEdit;

[JsonProperty("strokeColor")]
[JsonPropertyName("strokeColor")]
public string AttrstrokeColor;

[JsonProperty("strokeOpacity")]
[JsonPropertyName("strokeOpacity")]
public decimal? AttrstrokeOpacity;

[JsonProperty("strokeWeight")]
[JsonPropertyName("strokeWeight")]
public int? AttrstrokeWeight;

[JsonProperty("fillColor")]
[JsonPropertyName("fillColor")]
public string AttrfillColor;

[JsonProperty("fillOpacity")]
[JsonPropertyName("fillOpacity")]
public decimal? AttrfillOpacity;

public JSONST_4d96f69748c4f35fb433f7995d061407Structure() { }

public JSONST_4d96f69748c4f35fb433f7995d061407Structure (ST_4d96f69748c4f35fb433f7995d061407Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrlocations = ConvertToRestWithoutDefaults(s.sslocations, "");
Attrcenter = ConvertToRestWithoutDefaults(s.sscenter, "");
Attrbounds = ConvertToRestWithoutDefaults(s.ssbounds, "");
Attrradius = ConvertToRestWithoutDefaults(s.ssradius, 0);
AttrallowDrag = (bool?) s.ssallowDrag;
AttrallowEdit = (bool?) s.ssallowEdit;
AttrstrokeColor = s.ssstrokeColor;
AttrstrokeOpacity = (decimal?) s.ssstrokeOpacity;
AttrstrokeWeight = (int?) s.ssstrokeWeight;
AttrfillColor = s.ssfillColor;
AttrfillOpacity = (decimal?) s.ssfillOpacity;
  } else {
Attrlocations = s.sslocations;
Attrcenter = s.sscenter;
Attrbounds = s.ssbounds;
Attrradius = (int?) s.ssradius;
AttrallowDrag = (bool?) s.ssallowDrag;
AttrallowEdit = (bool?) s.ssallowEdit;
AttrstrokeColor = s.ssstrokeColor;
AttrstrokeOpacity = (decimal?) s.ssstrokeOpacity;
AttrstrokeWeight = (int?) s.ssstrokeWeight;
AttrfillColor = s.ssfillColor;
AttrfillOpacity = (decimal?) s.ssfillOpacity;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure, ST_4d96f69748c4f35fb433f7995d061407Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure s) => ToStructure(s, config);
}
public static ST_4d96f69748c4f35fb433f7995d061407Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure obj, IBehaviorsConfiguration config) { 
  ST_4d96f69748c4f35fb433f7995d061407Structure s = new ST_4d96f69748c4f35fb433f7995d061407Structure();
  if(obj != null) {
  s.sslocations = obj.Attrlocations == null ? "" : obj.Attrlocations;
  s.sscenter = obj.Attrcenter == null ? "" : obj.Attrcenter;
  s.ssbounds = obj.Attrbounds == null ? "" : obj.Attrbounds;
  s.ssradius = obj.Attrradius == null ? 0 : obj.Attrradius.Value;
  s.ssallowDrag = obj.AttrallowDrag == null ? false : obj.AttrallowDrag.Value;
  s.ssallowEdit = obj.AttrallowEdit == null ? false : obj.AttrallowEdit.Value;
  s.ssstrokeColor = obj.AttrstrokeColor == null ? "#000000" : obj.AttrstrokeColor;
  s.ssstrokeOpacity = obj.AttrstrokeOpacity == null ? (((decimal)1)) : obj.AttrstrokeOpacity.Value;
  s.ssstrokeWeight = obj.AttrstrokeWeight == null ? 2 : obj.AttrstrokeWeight.Value;
  s.ssfillColor = obj.AttrfillColor == null ? "#000000" : obj.AttrfillColor;
  s.ssfillOpacity = obj.AttrfillOpacity == null ? (((decimal)1)) : obj.AttrfillOpacity.Value;
  }
  return s;
}

public static Func<ST_4d96f69748c4f35fb433f7995d061407Structure, ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4d96f69748c4f35fb433f7995d061407Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure FromStructure(ST_4d96f69748c4f35fb433f7995d061407Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure(s, config);
}

}


