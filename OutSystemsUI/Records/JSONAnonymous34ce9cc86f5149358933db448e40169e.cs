using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SectionIndex_InternalConfigRecord
public class JSONRC_0a10b180e32034e48747aceb3ee25eef : AbstractRESTStructure<RC_0a10b180e32034e48747aceb3ee25eef> {
[JsonProperty("SectionIndex_InternalConfig")]
[JsonPropertyName("SectionIndex_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure AttrSectionIndex_InternalConfig;

public JSONRC_0a10b180e32034e48747aceb3ee25eef() { }

public JSONRC_0a10b180e32034e48747aceb3ee25eef (RC_0a10b180e32034e48747aceb3ee25eef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSectionIndex_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTSectionIndex_InternalConfig, new ST_3b9304e9875ccc71ec31b003d76d44c7Structure(), ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure.FromStructureDelegate(config));
  } else {
AttrSectionIndex_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure.FromStructure(s.ssSTSectionIndex_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_0a10b180e32034e48747aceb3ee25eef, RC_0a10b180e32034e48747aceb3ee25eef> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_0a10b180e32034e48747aceb3ee25eef s) => ToStructure(s, config);
}
public static RC_0a10b180e32034e48747aceb3ee25eef ToStructure(ssOutSystemsUI.RestRecords.JSONRC_0a10b180e32034e48747aceb3ee25eef obj, IBehaviorsConfiguration config) { 
  RC_0a10b180e32034e48747aceb3ee25eef s = new RC_0a10b180e32034e48747aceb3ee25eef();
  if(obj != null) {
  s.ssSTSectionIndex_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure.ToStructure(obj.AttrSectionIndex_InternalConfig, config);
  }
  return s;
}

public static Func<RC_0a10b180e32034e48747aceb3ee25eef, ssOutSystemsUI.RestRecords.JSONRC_0a10b180e32034e48747aceb3ee25eef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a10b180e32034e48747aceb3ee25eef s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_0a10b180e32034e48747aceb3ee25eef FromStructure(RC_0a10b180e32034e48747aceb3ee25eef s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_0a10b180e32034e48747aceb3ee25eef(s, config);
}

}


