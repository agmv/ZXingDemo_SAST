using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionOptionsRecord
public class RESTRC_8cdaa87184301dfa944cee1224e04604 : AbstractRESTStructure<RC_8cdaa87184301dfa944cee1224e04604> {
[JsonProperty("DirectionOptions")]
public ssOutSystemsMaps.RestRecords.RESTST_78b0cd1737b6725aac7ae45759769b93Structure AttrDirectionOptions;

public RESTRC_8cdaa87184301dfa944cee1224e04604() { }

public RESTRC_8cdaa87184301dfa944cee1224e04604 (RC_8cdaa87184301dfa944cee1224e04604 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectionOptions = ConvertToRestWithoutDefaults(s.ssSTDirectionOptions, new ST_78b0cd1737b6725aac7ae45759769b93Structure(), ssOutSystemsMaps.RestRecords.RESTST_78b0cd1737b6725aac7ae45759769b93Structure.FromStructureDelegate(config));
  } else {
AttrDirectionOptions = ssOutSystemsMaps.RestRecords.RESTST_78b0cd1737b6725aac7ae45759769b93Structure.FromStructure(s.ssSTDirectionOptions, config);
  }
}

public static RC_8cdaa87184301dfa944cee1224e04604 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_8cdaa87184301dfa944cee1224e04604 obj) { 
  RC_8cdaa87184301dfa944cee1224e04604 s = new RC_8cdaa87184301dfa944cee1224e04604();
  if(obj != null) {
  s.ssSTDirectionOptions = ssOutSystemsMaps.RestRecords.RESTST_78b0cd1737b6725aac7ae45759769b93Structure.ToStructure(obj.AttrDirectionOptions);
  }
  return s;
}

public static Func<RC_8cdaa87184301dfa944cee1224e04604, ssOutSystemsMaps.RestRecords.RESTRC_8cdaa87184301dfa944cee1224e04604> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8cdaa87184301dfa944cee1224e04604 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_8cdaa87184301dfa944cee1224e04604 FromStructure(RC_8cdaa87184301dfa944cee1224e04604 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_8cdaa87184301dfa944cee1224e04604(s, config);
}

}


