using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionOptionsRecord
public class JSONRC_8cdaa87184301dfa944cee1224e04604 : AbstractRESTStructure<RC_8cdaa87184301dfa944cee1224e04604> {
[JsonProperty("DirectionOptions")]
[JsonPropertyName("DirectionOptions")]
public ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure AttrDirectionOptions;

public JSONRC_8cdaa87184301dfa944cee1224e04604() { }

public JSONRC_8cdaa87184301dfa944cee1224e04604 (RC_8cdaa87184301dfa944cee1224e04604 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectionOptions = ConvertToRestWithoutDefaults(s.ssSTDirectionOptions, new ST_78b0cd1737b6725aac7ae45759769b93Structure(), ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure.FromStructureDelegate(config));
  } else {
AttrDirectionOptions = ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure.FromStructure(s.ssSTDirectionOptions, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_8cdaa87184301dfa944cee1224e04604, RC_8cdaa87184301dfa944cee1224e04604> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_8cdaa87184301dfa944cee1224e04604 s) => ToStructure(s, config);
}
public static RC_8cdaa87184301dfa944cee1224e04604 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_8cdaa87184301dfa944cee1224e04604 obj, IBehaviorsConfiguration config) { 
  RC_8cdaa87184301dfa944cee1224e04604 s = new RC_8cdaa87184301dfa944cee1224e04604();
  if(obj != null) {
  s.ssSTDirectionOptions = ssOutSystemsMaps.RestRecords.JSONST_78b0cd1737b6725aac7ae45759769b93Structure.ToStructure(obj.AttrDirectionOptions, config);
  }
  return s;
}

public static Func<RC_8cdaa87184301dfa944cee1224e04604, ssOutSystemsMaps.RestRecords.JSONRC_8cdaa87184301dfa944cee1224e04604> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8cdaa87184301dfa944cee1224e04604 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_8cdaa87184301dfa944cee1224e04604 FromStructure(RC_8cdaa87184301dfa944cee1224e04604 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_8cdaa87184301dfa944cee1224e04604(s, config);
}

}


