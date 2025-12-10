using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Video_InternalConfig
public class RESTST_87ed820dae13f311d79f7f394fc3790aStructure : AbstractRESTStructure<ST_87ed820dae13f311d79f7f394fc3790aStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("Autoplay")]
public bool? AttrAutoplay;

[JsonProperty("Captions")]
public string AttrCaptions;

[JsonProperty("Controls")]
public bool? AttrControls;

[JsonProperty("Height")]
public string AttrHeight;

[JsonProperty("Loop")]
public bool? AttrLoop;

[JsonProperty("Muted")]
public bool? AttrMuted;

[JsonProperty("PosterURL")]
public string AttrPosterURL;

[JsonProperty("URL")]
public string AttrURL;

[JsonProperty("Width")]
public string AttrWidth;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_87ed820dae13f311d79f7f394fc3790aStructure() { }

public RESTST_87ed820dae13f311d79f7f394fc3790aStructure (ST_87ed820dae13f311d79f7f394fc3790aStructure s, IBehaviorsConfiguration config) {
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

public static ST_87ed820dae13f311d79f7f394fc3790aStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_87ed820dae13f311d79f7f394fc3790aStructure obj) { 
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

public static Func<ST_87ed820dae13f311d79f7f394fc3790aStructure, ssOutSystemsUI.RestRecords.RESTST_87ed820dae13f311d79f7f394fc3790aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_87ed820dae13f311d79f7f394fc3790aStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_87ed820dae13f311d79f7f394fc3790aStructure FromStructure(ST_87ed820dae13f311d79f7f394fc3790aStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_87ed820dae13f311d79f7f394fc3790aStructure(s, config);
}

}


