using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselOptionalConfigs
public class JSONST_7d99fd1de65649f174aff6854b052539Structure : AbstractRESTStructure<ST_7d99fd1de65649f174aff6854b052539Structure> {
[JsonProperty("AutoPlay")]
[JsonPropertyName("AutoPlay")]
public bool? AttrAutoPlay;

[JsonProperty("Loop")]
[JsonPropertyName("Loop")]
public bool? AttrLoop;

[JsonProperty("Padding")]
[JsonPropertyName("Padding")]
public string AttrPadding;

[JsonProperty("ItemsGap")]
[JsonPropertyName("ItemsGap")]
public string AttrItemsGap;

[JsonProperty("StartingPosition")]
[JsonPropertyName("StartingPosition")]
public int? AttrStartingPosition;

public JSONST_7d99fd1de65649f174aff6854b052539Structure() { }

public JSONST_7d99fd1de65649f174aff6854b052539Structure (ST_7d99fd1de65649f174aff6854b052539Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAutoPlay = ConvertToRestWithoutDefaults(s.ssAutoPlay, true);
AttrLoop = ConvertToRestWithoutDefaults(s.ssLoop, true);
AttrPadding = ConvertToRestWithoutDefaults(s.ssPadding, "");
AttrItemsGap = ConvertToRestWithoutDefaults(s.ssItemsGap, "");
AttrStartingPosition = ConvertToRestWithoutDefaults(s.ssStartingPosition, 0);
  } else {
AttrAutoPlay = (bool?) s.ssAutoPlay;
AttrLoop = (bool?) s.ssLoop;
AttrPadding = s.ssPadding;
AttrItemsGap = s.ssItemsGap;
AttrStartingPosition = (int?) s.ssStartingPosition;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure, ST_7d99fd1de65649f174aff6854b052539Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure s) => ToStructure(s, config);
}
public static ST_7d99fd1de65649f174aff6854b052539Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure obj, IBehaviorsConfiguration config) { 
  ST_7d99fd1de65649f174aff6854b052539Structure s = new ST_7d99fd1de65649f174aff6854b052539Structure();
  if(obj != null) {
  s.ssAutoPlay = obj.AttrAutoPlay == null ? true : obj.AttrAutoPlay.Value;
  s.ssLoop = obj.AttrLoop == null ? true : obj.AttrLoop.Value;
  s.ssPadding = obj.AttrPadding == null ? "" : obj.AttrPadding;
  s.ssItemsGap = obj.AttrItemsGap == null ? "" : obj.AttrItemsGap;
  s.ssStartingPosition = obj.AttrStartingPosition == null ? 0 : obj.AttrStartingPosition.Value;
  }
  return s;
}

public static Func<ST_7d99fd1de65649f174aff6854b052539Structure, ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7d99fd1de65649f174aff6854b052539Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure FromStructure(ST_7d99fd1de65649f174aff6854b052539Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure(s, config);
}

}


