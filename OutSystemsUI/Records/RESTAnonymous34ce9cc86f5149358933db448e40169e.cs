using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SectionIndex_InternalConfigRecord
public class RESTRC_0a10b180e32034e48747aceb3ee25eef : AbstractRESTStructure<RC_0a10b180e32034e48747aceb3ee25eef> {
[JsonProperty("SectionIndex_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure AttrSectionIndex_InternalConfig;

public RESTRC_0a10b180e32034e48747aceb3ee25eef() { }

public RESTRC_0a10b180e32034e48747aceb3ee25eef (RC_0a10b180e32034e48747aceb3ee25eef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSectionIndex_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTSectionIndex_InternalConfig, new ST_3b9304e9875ccc71ec31b003d76d44c7Structure(), ssOutSystemsUI.RestRecords.RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure.FromStructureDelegate(config));
  } else {
AttrSectionIndex_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure.FromStructure(s.ssSTSectionIndex_InternalConfig, config);
  }
}

public static RC_0a10b180e32034e48747aceb3ee25eef ToStructure(ssOutSystemsUI.RestRecords.RESTRC_0a10b180e32034e48747aceb3ee25eef obj) { 
  RC_0a10b180e32034e48747aceb3ee25eef s = new RC_0a10b180e32034e48747aceb3ee25eef();
  if(obj != null) {
  s.ssSTSectionIndex_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure.ToStructure(obj.AttrSectionIndex_InternalConfig);
  }
  return s;
}

public static Func<RC_0a10b180e32034e48747aceb3ee25eef, ssOutSystemsUI.RestRecords.RESTRC_0a10b180e32034e48747aceb3ee25eef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a10b180e32034e48747aceb3ee25eef s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_0a10b180e32034e48747aceb3ee25eef FromStructure(RC_0a10b180e32034e48747aceb3ee25eef s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_0a10b180e32034e48747aceb3ee25eef(s, config);
}

}


