using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Video_InternalConfig
public class JSONST_87ed820dae13f311d79f7f394fc3790aStructure : AbstractRESTStructure<ST_87ed820dae13f311d79f7f394fc3790aStructure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("Autoplay")]
[JsonPropertyName("Autoplay")]
public bool? AttrAutoplay;

[JsonProperty("Captions")]
[JsonPropertyName("Captions")]
public string AttrCaptions;

[JsonProperty("Controls")]
[JsonPropertyName("Controls")]
public bool? AttrControls;

[JsonProperty("Height")]
[JsonPropertyName("Height")]
public string AttrHeight;

[JsonProperty("Loop")]
[JsonPropertyName("Loop")]
public bool? AttrLoop;

[JsonProperty("Muted")]
[JsonPropertyName("Muted")]
public bool? AttrMuted;

[JsonProperty("PosterURL")]
[JsonPropertyName("PosterURL")]
public string AttrPosterURL;

[JsonProperty("URL")]
[JsonPropertyName("URL")]
public string AttrURL;

[JsonProperty("Width")]
[JsonPropertyName("Width")]
public string AttrWidth;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_87ed820dae13f311d79f7f394fc3790aStructure() { }

public JSONST_87ed820dae13f311d79f7f394fc3790aStructure (ST_87ed820dae13f311d79f7f394fc3790aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrAutoplay = ConvertToRestWithoutDefaults(s.ssAutoplay, true);
AttrCaptions = ConvertToRestWithoutDefaults(s.ssCaptions, "");
AttrControls = ConvertToRestWithoutDefaults(s.ssControls, true);
AttrHeight = ConvertToRestWithoutDefaults(s.ssHeight, "");
AttrLoop = ConvertToRestWithoutDefaults(s.ssLoop, false);
AttrMuted = ConvertToRestWithoutDefaults(s.ssMuted, false);
AttrPosterURL = ConvertToRestWithoutDefaults(s.ssPosterURL, "");
AttrURL = ConvertToRestWithoutDefaults(s.ssURL, "");
AttrWidth = ConvertToRestWithoutDefaults(s.ssWidth, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrAutoplay = (bool?) s.ssAutoplay;
AttrCaptions = s.ssCaptions;
AttrControls = (bool?) s.ssControls;
AttrHeight = s.ssHeight;
AttrLoop = (bool?) s.ssLoop;
AttrMuted = (bool?) s.ssMuted;
AttrPosterURL = s.ssPosterURL;
AttrURL = s.ssURL;
AttrWidth = s.ssWidth;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_87ed820dae13f311d79f7f394fc3790aStructure, ST_87ed820dae13f311d79f7f394fc3790aStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_87ed820dae13f311d79f7f394fc3790aStructure s) => ToStructure(s, config);
}
public static ST_87ed820dae13f311d79f7f394fc3790aStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_87ed820dae13f311d79f7f394fc3790aStructure obj, IBehaviorsConfiguration config) { 
  ST_87ed820dae13f311d79f7f394fc3790aStructure s = new ST_87ed820dae13f311d79f7f394fc3790aStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssAutoplay = obj.AttrAutoplay == null ? true : obj.AttrAutoplay.Value;
  s.ssCaptions = obj.AttrCaptions == null ? "" : obj.AttrCaptions;
  s.ssControls = obj.AttrControls == null ? true : obj.AttrControls.Value;
  s.ssHeight = obj.AttrHeight == null ? "" : obj.AttrHeight;
  s.ssLoop = obj.AttrLoop == null ? false : obj.AttrLoop.Value;
  s.ssMuted = obj.AttrMuted == null ? false : obj.AttrMuted.Value;
  s.ssPosterURL = obj.AttrPosterURL == null ? "" : obj.AttrPosterURL;
  s.ssURL = obj.AttrURL == null ? "" : obj.AttrURL;
  s.ssWidth = obj.AttrWidth == null ? "" : obj.AttrWidth;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_87ed820dae13f311d79f7f394fc3790aStructure, ssOutSystemsUI.RestRecords.JSONST_87ed820dae13f311d79f7f394fc3790aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_87ed820dae13f311d79f7f394fc3790aStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_87ed820dae13f311d79f7f394fc3790aStructure FromStructure(ST_87ed820dae13f311d79f7f394fc3790aStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_87ed820dae13f311d79f7f394fc3790aStructure(s, config);
}

}


