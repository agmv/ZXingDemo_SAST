using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalPopupMarkerConfigs
public class JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure : AbstractRESTStructure<ST_bbc1ca6a16af45dbf463953c280f2bf7Structure> {
[JsonProperty("IconURL")]
[JsonPropertyName("IconURL")]
public string AttrIconURL;

[JsonProperty("IconSize")]
[JsonPropertyName("IconSize")]
public ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure AttrIconSize;

[JsonProperty("Title")]
[JsonPropertyName("Title")]
public string AttrTitle;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("AllowDrag")]
[JsonPropertyName("AllowDrag")]
public bool? AttrAllowDrag;

public JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure() { }

public JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure (ST_bbc1ca6a16af45dbf463953c280f2bf7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIconURL = ConvertToRestWithoutDefaults(s.ssIconURL, "");
AttrIconSize = ConvertToRestWithoutDefaults(s.ssIconSize, new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure(), ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.FromStructureDelegate(config));
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
AttrAllowDrag = ConvertToRestWithoutDefaults(s.ssAllowDrag, false);
  } else {
AttrIconURL = s.ssIconURL;
AttrIconSize = ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.FromStructure(s.ssIconSize, config);
AttrTitle = s.ssTitle;
AttrLabel = s.ssLabel;
AttrAllowDrag = (bool?) s.ssAllowDrag;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure, ST_bbc1ca6a16af45dbf463953c280f2bf7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure s) => ToStructure(s, config);
}
public static ST_bbc1ca6a16af45dbf463953c280f2bf7Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure obj, IBehaviorsConfiguration config) { 
  ST_bbc1ca6a16af45dbf463953c280f2bf7Structure s = new ST_bbc1ca6a16af45dbf463953c280f2bf7Structure();
  if(obj != null) {
  s.ssIconURL = obj.AttrIconURL == null ? "" : obj.AttrIconURL;
  s.ssIconSize = ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.ToStructure(obj.AttrIconSize, config);
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssAllowDrag = obj.AttrAllowDrag == null ? false : obj.AttrAllowDrag.Value;
  }
  return s;
}

public static Func<ST_bbc1ca6a16af45dbf463953c280f2bf7Structure, ssOutSystemsMaps.RestRecords.JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_bbc1ca6a16af45dbf463953c280f2bf7Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure FromStructure(ST_bbc1ca6a16af45dbf463953c280f2bf7Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_bbc1ca6a16af45dbf463953c280f2bf7Structure(s, config);
}

}


