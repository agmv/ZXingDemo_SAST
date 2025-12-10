using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Carousel_InternalConfig
public class RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure : AbstractRESTStructure<ST_736a0a0e931f1e6cffc1de4b3ad94539Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("Navigation")]
public string AttrNavigation;

[JsonProperty("Height")]
public string AttrHeight;

[JsonProperty("ItemsDesktop")]
public int? AttrItemsDesktop;

[JsonProperty("ItemsTablet")]
public int? AttrItemsTablet;

[JsonProperty("ItemsPhone")]
public int? AttrItemsPhone;

[JsonProperty("AutoPlay")]
public bool? AttrAutoPlay;

[JsonProperty("Loop")]
public bool? AttrLoop;

[JsonProperty("Padding")]
public string AttrPadding;

[JsonProperty("StartingPosition")]
public int? AttrStartingPosition;

[JsonProperty("ItemsGap")]
public string AttrItemsGap;

public RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure() { }

public RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure (ST_736a0a0e931f1e6cffc1de4b3ad94539Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
AttrNavigation = ConvertToRestWithoutDefaults(s.ssNavigation, "");
AttrHeight = ConvertToRestWithoutDefaults(s.ssHeight, "");
AttrItemsDesktop = ConvertToRestWithoutDefaults(s.ssItemsDesktop, 1);
AttrItemsTablet = ConvertToRestWithoutDefaults(s.ssItemsTablet, 1);
AttrItemsPhone = ConvertToRestWithoutDefaults(s.ssItemsPhone, 1);
AttrAutoPlay = ConvertToRestWithoutDefaults(s.ssAutoPlay, true);
AttrLoop = ConvertToRestWithoutDefaults(s.ssLoop, true);
AttrPadding = ConvertToRestWithoutDefaults(s.ssPadding, "0");
AttrStartingPosition = ConvertToRestWithoutDefaults(s.ssStartingPosition, 0);
AttrItemsGap = ConvertToRestWithoutDefaults(s.ssItemsGap, "0");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
AttrNavigation = s.ssNavigation;
AttrHeight = s.ssHeight;
AttrItemsDesktop = (int?) s.ssItemsDesktop;
AttrItemsTablet = (int?) s.ssItemsTablet;
AttrItemsPhone = (int?) s.ssItemsPhone;
AttrAutoPlay = (bool?) s.ssAutoPlay;
AttrLoop = (bool?) s.ssLoop;
AttrPadding = s.ssPadding;
AttrStartingPosition = (int?) s.ssStartingPosition;
AttrItemsGap = s.ssItemsGap;
  }
}

public static ST_736a0a0e931f1e6cffc1de4b3ad94539Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure obj) { 
  ST_736a0a0e931f1e6cffc1de4b3ad94539Structure s = new ST_736a0a0e931f1e6cffc1de4b3ad94539Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssNavigation = obj.AttrNavigation == null ? "" : obj.AttrNavigation;
  s.ssHeight = obj.AttrHeight == null ? "" : obj.AttrHeight;
  s.ssItemsDesktop = obj.AttrItemsDesktop == null ? 1 : obj.AttrItemsDesktop.Value;
  s.ssItemsTablet = obj.AttrItemsTablet == null ? 1 : obj.AttrItemsTablet.Value;
  s.ssItemsPhone = obj.AttrItemsPhone == null ? 1 : obj.AttrItemsPhone.Value;
  s.ssAutoPlay = obj.AttrAutoPlay == null ? true : obj.AttrAutoPlay.Value;
  s.ssLoop = obj.AttrLoop == null ? true : obj.AttrLoop.Value;
  s.ssPadding = obj.AttrPadding == null ? "0" : obj.AttrPadding;
  s.ssStartingPosition = obj.AttrStartingPosition == null ? 0 : obj.AttrStartingPosition.Value;
  s.ssItemsGap = obj.AttrItemsGap == null ? "0" : obj.AttrItemsGap;
  }
  return s;
}

public static Func<ST_736a0a0e931f1e6cffc1de4b3ad94539Structure, ssOutSystemsUI.RestRecords.RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_736a0a0e931f1e6cffc1de4b3ad94539Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure FromStructure(ST_736a0a0e931f1e6cffc1de4b3ad94539Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure(s, config);
}

}


