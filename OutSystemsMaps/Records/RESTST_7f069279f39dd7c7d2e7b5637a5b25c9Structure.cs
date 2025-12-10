using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalMarkerConfigs
public class RESTST_7f069279f39dd7c7d2e7b5637a5b25c9Structure : AbstractRESTStructure<ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure> {
[JsonProperty("IconURL")]
public string AttrIconURL;

[JsonProperty("IconSize")]
public ssOutSystemsMaps.RestRecords.RESTST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure AttrIconSize;

[JsonProperty("Title")]
public string AttrTitle;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("AllowDrag")]
public bool? AttrAllowDrag;

public RESTST_7f069279f39dd7c7d2e7b5637a5b25c9Structure() { }

public RESTST_7f069279f39dd7c7d2e7b5637a5b25c9Structure (ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIconURL = ConvertToRestWithoutDefaults(s.ssIconURL, "");
AttrIconSize = ConvertToRestWithoutDefaults(s.ssIconSize, new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure(), ssOutSystemsMaps.RestRecords.RESTST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.FromStructureDelegate(config));
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
AttrAllowDrag = ConvertToRestWithoutDefaults(s.ssAllowDrag, false);
  } else {
AttrIconURL = s.ssIconURL;
AttrIconSize = ssOutSystemsMaps.RestRecords.RESTST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.FromStructure(s.ssIconSize, config);
AttrTitle = s.ssTitle;
AttrLabel = s.ssLabel;
AttrAllowDrag = (bool?) s.ssAllowDrag;
  }
}

public static ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_7f069279f39dd7c7d2e7b5637a5b25c9Structure obj) { 
  ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure s = new ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure();
  if(obj != null) {
  s.ssIconURL = obj.AttrIconURL == null ? "" : obj.AttrIconURL;
  s.ssIconSize = ssOutSystemsMaps.RestRecords.RESTST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.ToStructure(obj.AttrIconSize);
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssAllowDrag = obj.AttrAllowDrag == null ? false : obj.AttrAllowDrag.Value;
  }
  return s;
}

public static Func<ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure, ssOutSystemsMaps.RestRecords.RESTST_7f069279f39dd7c7d2e7b5637a5b25c9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_7f069279f39dd7c7d2e7b5637a5b25c9Structure FromStructure(ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_7f069279f39dd7c7d2e7b5637a5b25c9Structure(s, config);
}

}


