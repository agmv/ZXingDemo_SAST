using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Accordion_InternalConfigsRecord
public class JSONRC_34326cf8cbe6cf38d907603fa07c4c09 : AbstractRESTStructure<RC_34326cf8cbe6cf38d907603fa07c4c09> {
[JsonProperty("Accordion_InternalConfigs")]
[JsonPropertyName("Accordion_InternalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure AttrAccordion_InternalConfigs;

public JSONRC_34326cf8cbe6cf38d907603fa07c4c09() { }

public JSONRC_34326cf8cbe6cf38d907603fa07c4c09 (RC_34326cf8cbe6cf38d907603fa07c4c09 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccordion_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTAccordion_InternalConfigs, new ST_0f0a5319963cb5bf3b0eab53b2781088Structure(), ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure.FromStructureDelegate(config));
  } else {
AttrAccordion_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure.FromStructure(s.ssSTAccordion_InternalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_34326cf8cbe6cf38d907603fa07c4c09, RC_34326cf8cbe6cf38d907603fa07c4c09> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_34326cf8cbe6cf38d907603fa07c4c09 s) => ToStructure(s, config);
}
public static RC_34326cf8cbe6cf38d907603fa07c4c09 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_34326cf8cbe6cf38d907603fa07c4c09 obj, IBehaviorsConfiguration config) { 
  RC_34326cf8cbe6cf38d907603fa07c4c09 s = new RC_34326cf8cbe6cf38d907603fa07c4c09();
  if(obj != null) {
  s.ssSTAccordion_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure.ToStructure(obj.AttrAccordion_InternalConfigs, config);
  }
  return s;
}

public static Func<RC_34326cf8cbe6cf38d907603fa07c4c09, ssOutSystemsUI.RestRecords.JSONRC_34326cf8cbe6cf38d907603fa07c4c09> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_34326cf8cbe6cf38d907603fa07c4c09 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_34326cf8cbe6cf38d907603fa07c4c09 FromStructure(RC_34326cf8cbe6cf38d907603fa07c4c09 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_34326cf8cbe6cf38d907603fa07c4c09(s, config);
}

}


