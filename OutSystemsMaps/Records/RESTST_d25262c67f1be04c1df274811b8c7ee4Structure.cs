using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_drawFilledShape_configs
public class RESTST_d25262c67f1be04c1df274811b8c7ee4Structure : AbstractRESTStructure<ST_d25262c67f1be04c1df274811b8c7ee4Structure> {
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

[JsonProperty("fillColor")]
public string AttrfillColor;

[JsonProperty("fillOpacity")]
public decimal? AttrfillOpacity;

public RESTST_d25262c67f1be04c1df274811b8c7ee4Structure() { }

public RESTST_d25262c67f1be04c1df274811b8c7ee4Structure (ST_d25262c67f1be04c1df274811b8c7ee4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrallowDrag = ConvertToRestWithoutDefaults(s.ssallowDrag, false);
AttrallowEdit = ConvertToRestWithoutDefaults(s.ssallowEdit, false);
AttrstrokeColor = s.ssstrokeColor;
AttrstrokeOpacity = (decimal?) s.ssstrokeOpacity;
AttrstrokeWeight = (int?) s.ssstrokeWeight;
AttrfillColor = s.ssfillColor;
AttrfillOpacity = (decimal?) s.ssfillOpacity;
  } else {
AttrallowDrag = (bool?) s.ssallowDrag;
AttrallowEdit = (bool?) s.ssallowEdit;
AttrstrokeColor = s.ssstrokeColor;
AttrstrokeOpacity = (decimal?) s.ssstrokeOpacity;
AttrstrokeWeight = (int?) s.ssstrokeWeight;
AttrfillColor = s.ssfillColor;
AttrfillOpacity = (decimal?) s.ssfillOpacity;
  }
}

public static ST_d25262c67f1be04c1df274811b8c7ee4Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure obj) { 
  ST_d25262c67f1be04c1df274811b8c7ee4Structure s = new ST_d25262c67f1be04c1df274811b8c7ee4Structure();
  if(obj != null) {
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

public static Func<ST_d25262c67f1be04c1df274811b8c7ee4Structure, ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d25262c67f1be04c1df274811b8c7ee4Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure FromStructure(ST_d25262c67f1be04c1df274811b8c7ee4Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure(s, config);
}

}


