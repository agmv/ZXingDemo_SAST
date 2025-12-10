using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// IconSize
public class JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure : AbstractRESTStructure<ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure> {
[JsonProperty("Width")]
[JsonPropertyName("Width")]
public int? AttrWidth;

[JsonProperty("Height")]
[JsonPropertyName("Height")]
public int? AttrHeight;

public JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure() { }

public JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWidth = ConvertToRestWithoutDefaults(s.ssWidth, 0);
AttrHeight = ConvertToRestWithoutDefaults(s.ssHeight, 0);
  } else {
AttrWidth = (int?) s.ssWidth;
AttrHeight = (int?) s.ssHeight;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure, ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure s) => ToStructure(s, config);
}
public static ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure obj, IBehaviorsConfiguration config) { 
  ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure s = new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure();
  if(obj != null) {
  s.ssWidth = obj.AttrWidth == null ? 0 : obj.AttrWidth.Value;
  s.ssHeight = obj.AttrHeight == null ? 0 : obj.AttrHeight.Value;
  }
  return s;
}

public static Func<ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure, ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure FromStructure(ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure(s, config);
}

}


