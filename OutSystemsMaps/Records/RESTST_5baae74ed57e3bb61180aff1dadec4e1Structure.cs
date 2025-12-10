using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_configs
public class RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure : AbstractRESTStructure<ST_5baae74ed57e3bb61180aff1dadec4e1Structure> {
[JsonProperty("advancedFormat")]
public string AttradvancedFormat;

[JsonProperty("apiKey")]
public string AttrapiKey;

[JsonProperty("autoZoomOnShapes")]
public bool? AttrautoZoomOnShapes;

[JsonProperty("center")]
public string Attrcenter;

[JsonProperty("height")]
public string Attrheight;

[JsonProperty("offset")]
public ssOutSystemsMaps.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure Attroffset;

[JsonProperty("showTraffic")]
public bool? AttrshowTraffic;

[JsonProperty("staticMap")]
public bool? AttrstaticMap;

[JsonProperty("style")]
public int? Attrstyle;

[JsonProperty("type")]
public string Attrtype;

[JsonProperty("zoom")]
public int? Attrzoom;

[JsonProperty("markerClusterer")]
public ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure AttrmarkerClusterer;

[JsonProperty("respectUserZoom")]
public bool? AttrrespectUserZoom;

[JsonProperty("localization")]
public ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure Attrlocalization;

[JsonProperty("useAdvancedMarkers")]
public bool? AttruseAdvancedMarkers;

[JsonProperty("mapStyleId")]
public string AttrmapStyleId;

public RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure() { }

public RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure (ST_5baae74ed57e3bb61180aff1dadec4e1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttradvancedFormat = ConvertToRestWithoutDefaults(s.ssadvancedFormat, "");
AttrapiKey = s.ssapiKey;
AttrautoZoomOnShapes = ConvertToRestWithoutDefaults(s.ssautoZoomOnShapes, false);
Attrcenter = ConvertToRestWithoutDefaults(s.sscenter, "");
Attrheight = s.ssheight;
Attroffset = ssOutSystemsMaps.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.FromStructure(s.ssoffset, config);
AttrshowTraffic = (bool?) s.ssshowTraffic;
AttrstaticMap = (bool?) s.ssstaticMap;
Attrstyle = (int?) s.ssstyle;
Attrtype = s.sstype;
Attrzoom = (int?) s.sszoom;
AttrmarkerClusterer = ConvertToRestWithoutDefaults(s.ssmarkerClusterer, new ST_9f8ac95fe4e47e327de12de1b56bed45Structure(), ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure.FromStructureDelegate(config));
AttrrespectUserZoom = ConvertToRestWithoutDefaults(s.ssrespectUserZoom, false);
Attrlocalization = ConvertToRestWithoutDefaults(s.sslocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
AttruseAdvancedMarkers = ConvertToRestWithoutDefaults(s.ssuseAdvancedMarkers, false);
AttrmapStyleId = ConvertToRestWithoutDefaults(s.ssmapStyleId, "");
  } else {
AttradvancedFormat = s.ssadvancedFormat;
AttrapiKey = s.ssapiKey;
AttrautoZoomOnShapes = (bool?) s.ssautoZoomOnShapes;
Attrcenter = s.sscenter;
Attrheight = s.ssheight;
Attroffset = ssOutSystemsMaps.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.FromStructure(s.ssoffset, config);
AttrshowTraffic = (bool?) s.ssshowTraffic;
AttrstaticMap = (bool?) s.ssstaticMap;
Attrstyle = (int?) s.ssstyle;
Attrtype = s.sstype;
Attrzoom = (int?) s.sszoom;
AttrmarkerClusterer = ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure.FromStructure(s.ssmarkerClusterer, config);
AttrrespectUserZoom = (bool?) s.ssrespectUserZoom;
Attrlocalization = ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.sslocalization, config);
AttruseAdvancedMarkers = (bool?) s.ssuseAdvancedMarkers;
AttrmapStyleId = s.ssmapStyleId;
  }
}

public static ST_5baae74ed57e3bb61180aff1dadec4e1Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure obj) { 
  ST_5baae74ed57e3bb61180aff1dadec4e1Structure s = new ST_5baae74ed57e3bb61180aff1dadec4e1Structure();
  if(obj != null) {
  s.ssadvancedFormat = obj.AttradvancedFormat == null ? "" : obj.AttradvancedFormat;
  s.ssapiKey = obj.AttrapiKey == null ? "" : obj.AttrapiKey;
  s.ssautoZoomOnShapes = obj.AttrautoZoomOnShapes == null ? false : obj.AttrautoZoomOnShapes.Value;
  s.sscenter = obj.Attrcenter == null ? "" : obj.Attrcenter;
  s.ssheight = obj.Attrheight == null ? "" : obj.Attrheight;
  s.ssoffset = ssOutSystemsMaps.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.ToStructure(obj.Attroffset);
  s.ssshowTraffic = obj.AttrshowTraffic == null ? false : obj.AttrshowTraffic.Value;
  s.ssstaticMap = obj.AttrstaticMap == null ? false : obj.AttrstaticMap.Value;
  s.ssstyle = obj.Attrstyle == null ? 0 : obj.Attrstyle.Value;
  s.sstype = obj.Attrtype == null ? "" : obj.Attrtype;
  s.sszoom = obj.Attrzoom == null ? 0 : obj.Attrzoom.Value;
  s.ssmarkerClusterer = ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure.ToStructure(obj.AttrmarkerClusterer);
  s.ssrespectUserZoom = obj.AttrrespectUserZoom == null ? false : obj.AttrrespectUserZoom.Value;
  s.sslocalization = ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.Attrlocalization);
  s.ssuseAdvancedMarkers = obj.AttruseAdvancedMarkers == null ? false : obj.AttruseAdvancedMarkers.Value;
  s.ssmapStyleId = obj.AttrmapStyleId == null ? "" : obj.AttrmapStyleId;
  }
  return s;
}

public static Func<ST_5baae74ed57e3bb61180aff1dadec4e1Structure, ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5baae74ed57e3bb61180aff1dadec4e1Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure FromStructure(ST_5baae74ed57e3bb61180aff1dadec4e1Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure(s, config);
}

}


