using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Accordion_InternalConfigsRecord
public class RESTRC_34326cf8cbe6cf38d907603fa07c4c09 : AbstractRESTStructure<RC_34326cf8cbe6cf38d907603fa07c4c09> {
[JsonProperty("Accordion_InternalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure AttrAccordion_InternalConfigs;

public RESTRC_34326cf8cbe6cf38d907603fa07c4c09() { }

public RESTRC_34326cf8cbe6cf38d907603fa07c4c09 (RC_34326cf8cbe6cf38d907603fa07c4c09 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccordion_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTAccordion_InternalConfigs, new ST_0f0a5319963cb5bf3b0eab53b2781088Structure(), ssOutSystemsUI.RestRecords.RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure.FromStructureDelegate(config));
  } else {
AttrAccordion_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure.FromStructure(s.ssSTAccordion_InternalConfigs, config);
  }
}

public static RC_34326cf8cbe6cf38d907603fa07c4c09 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_34326cf8cbe6cf38d907603fa07c4c09 obj) { 
  RC_34326cf8cbe6cf38d907603fa07c4c09 s = new RC_34326cf8cbe6cf38d907603fa07c4c09();
  if(obj != null) {
  s.ssSTAccordion_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure.ToStructure(obj.AttrAccordion_InternalConfigs);
  }
  return s;
}

public static Func<RC_34326cf8cbe6cf38d907603fa07c4c09, ssOutSystemsUI.RestRecords.RESTRC_34326cf8cbe6cf38d907603fa07c4c09> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_34326cf8cbe6cf38d907603fa07c4c09 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_34326cf8cbe6cf38d907603fa07c4c09 FromStructure(RC_34326cf8cbe6cf38d907603fa07c4c09 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_34326cf8cbe6cf38d907603fa07c4c09(s, config);
}

}


