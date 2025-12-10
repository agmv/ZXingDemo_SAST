using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_configs
public class JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure : AbstractRESTStructure<ST_5baae74ed57e3bb61180aff1dadec4e1Structure> {
[JsonProperty("advancedFormat")]
[JsonPropertyName("advancedFormat")]
public string AttradvancedFormat;

[JsonProperty("apiKey")]
[JsonPropertyName("apiKey")]
public string AttrapiKey;

[JsonProperty("autoZoomOnShapes")]
[JsonPropertyName("autoZoomOnShapes")]
public bool? AttrautoZoomOnShapes;

[JsonProperty("center")]
[JsonPropertyName("center")]
public string Attrcenter;

[JsonProperty("height")]
[JsonPropertyName("height")]
public string Attrheight;

[JsonProperty("offset")]
[JsonPropertyName("offset")]
public ssOutSystemsMaps.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure Attroffset;

[JsonProperty("showTraffic")]
[JsonPropertyName("showTraffic")]
public bool? AttrshowTraffic;

[JsonProperty("staticMap")]
[JsonPropertyName("staticMap")]
public bool? AttrstaticMap;

[JsonProperty("style")]
[JsonPropertyName("style")]
public int? Attrstyle;

[JsonProperty("type")]
[JsonPropertyName("type")]
public string Attrtype;

[JsonProperty("zoom")]
[JsonPropertyName("zoom")]
public int? Attrzoom;

[JsonProperty("markerClusterer")]
[JsonPropertyName("markerClusterer")]
public ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure AttrmarkerClusterer;

[JsonProperty("respectUserZoom")]
[JsonPropertyName("respectUserZoom")]
public bool? AttrrespectUserZoom;

[JsonProperty("localization")]
[JsonPropertyName("localization")]
public ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure Attrlocalization;

[JsonProperty("useAdvancedMarkers")]
[JsonPropertyName("useAdvancedMarkers")]
public bool? AttruseAdvancedMarkers;

[JsonProperty("mapStyleId")]
[JsonPropertyName("mapStyleId")]
public string AttrmapStyleId;

public JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure() { }

public JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure (ST_5baae74ed57e3bb61180aff1dadec4e1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttradvancedFormat = ConvertToRestWithoutDefaults(s.ssadvancedFormat, "");
AttrapiKey = s.ssapiKey;
AttrautoZoomOnShapes = ConvertToRestWithoutDefaults(s.ssautoZoomOnShapes, false);
Attrcenter = ConvertToRestWithoutDefaults(s.sscenter, "");
Attrheight = s.ssheight;
Attroffset = ssOutSystemsMaps.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.FromStructure(s.ssoffset, config);
AttrshowTraffic = (bool?) s.ssshowTraffic;
AttrstaticMap = (bool?) s.ssstaticMap;
Attrstyle = (int?) s.ssstyle;
Attrtype = s.sstype;
Attrzoom = (int?) s.sszoom;
AttrmarkerClusterer = ConvertToRestWithoutDefaults(s.ssmarkerClusterer, new ST_9f8ac95fe4e47e327de12de1b56bed45Structure(), ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure.FromStructureDelegate(config));
AttrrespectUserZoom = ConvertToRestWithoutDefaults(s.ssrespectUserZoom, false);
Attrlocalization = ConvertToRestWithoutDefaults(s.sslocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
AttruseAdvancedMarkers = ConvertToRestWithoutDefaults(s.ssuseAdvancedMarkers, false);
AttrmapStyleId = ConvertToRestWithoutDefaults(s.ssmapStyleId, "");
  } else {
AttradvancedFormat = s.ssadvancedFormat;
AttrapiKey = s.ssapiKey;
AttrautoZoomOnShapes = (bool?) s.ssautoZoomOnShapes;
Attrcenter = s.sscenter;
Attrheight = s.ssheight;
Attroffset = ssOutSystemsMaps.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.FromStructure(s.ssoffset, config);
AttrshowTraffic = (bool?) s.ssshowTraffic;
AttrstaticMap = (bool?) s.ssstaticMap;
Attrstyle = (int?) s.ssstyle;
Attrtype = s.sstype;
Attrzoom = (int?) s.sszoom;
AttrmarkerClusterer = ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure.FromStructure(s.ssmarkerClusterer, config);
AttrrespectUserZoom = (bool?) s.ssrespectUserZoom;
Attrlocalization = ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.sslocalization, config);
AttruseAdvancedMarkers = (bool?) s.ssuseAdvancedMarkers;
AttrmapStyleId = s.ssmapStyleId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure, ST_5baae74ed57e3bb61180aff1dadec4e1Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure s) => ToStructure(s, config);
}
public static ST_5baae74ed57e3bb61180aff1dadec4e1Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure obj, IBehaviorsConfiguration config) { 
  ST_5baae74ed57e3bb61180aff1dadec4e1Structure s = new ST_5baae74ed57e3bb61180aff1dadec4e1Structure();
  if(obj != null) {
  s.ssadvancedFormat = obj.AttradvancedFormat == null ? "" : obj.AttradvancedFormat;
  s.ssapiKey = obj.AttrapiKey == null ? "" : obj.AttrapiKey;
  s.ssautoZoomOnShapes = obj.AttrautoZoomOnShapes == null ? false : obj.AttrautoZoomOnShapes.Value;
  s.sscenter = obj.Attrcenter == null ? "" : obj.Attrcenter;
  s.ssheight = obj.Attrheight == null ? "" : obj.Attrheight;
  s.ssoffset = ssOutSystemsMaps.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.ToStructure(obj.Attroffset, config);
  s.ssshowTraffic = obj.AttrshowTraffic == null ? false : obj.AttrshowTraffic.Value;
  s.ssstaticMap = obj.AttrstaticMap == null ? false : obj.AttrstaticMap.Value;
  s.ssstyle = obj.Attrstyle == null ? 0 : obj.Attrstyle.Value;
  s.sstype = obj.Attrtype == null ? "" : obj.Attrtype;
  s.sszoom = obj.Attrzoom == null ? 0 : obj.Attrzoom.Value;
  s.ssmarkerClusterer = ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure.ToStructure(obj.AttrmarkerClusterer, config);
  s.ssrespectUserZoom = obj.AttrrespectUserZoom == null ? false : obj.AttrrespectUserZoom.Value;
  s.sslocalization = ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.Attrlocalization, config);
  s.ssuseAdvancedMarkers = obj.AttruseAdvancedMarkers == null ? false : obj.AttruseAdvancedMarkers.Value;
  s.ssmapStyleId = obj.AttrmapStyleId == null ? "" : obj.AttrmapStyleId;
  }
  return s;
}

public static Func<ST_5baae74ed57e3bb61180aff1dadec4e1Structure, ssOutSystemsMaps.RestRecords.JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5baae74ed57e3bb61180aff1dadec4e1Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure FromStructure(ST_5baae74ed57e3bb61180aff1dadec4e1Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_5baae74ed57e3bb61180aff1dadec4e1Structure(s, config);
}

}


