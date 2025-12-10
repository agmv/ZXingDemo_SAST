using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AccordionItem_InternalConfigsRecord
public class JSONRC_28eb7999f57ca2adfa805d40364c85b5 : AbstractRESTStructure<RC_28eb7999f57ca2adfa805d40364c85b5> {
[JsonProperty("AccordionItem_InternalConfigs")]
[JsonPropertyName("AccordionItem_InternalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure AttrAccordionItem_InternalConfigs;

public JSONRC_28eb7999f57ca2adfa805d40364c85b5() { }

public JSONRC_28eb7999f57ca2adfa805d40364c85b5 (RC_28eb7999f57ca2adfa805d40364c85b5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccordionItem_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTAccordionItem_InternalConfigs, new ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure(), ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure.FromStructureDelegate(config));
  } else {
AttrAccordionItem_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure.FromStructure(s.ssSTAccordionItem_InternalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_28eb7999f57ca2adfa805d40364c85b5, RC_28eb7999f57ca2adfa805d40364c85b5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_28eb7999f57ca2adfa805d40364c85b5 s) => ToStructure(s, config);
}
public static RC_28eb7999f57ca2adfa805d40364c85b5 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_28eb7999f57ca2adfa805d40364c85b5 obj, IBehaviorsConfiguration config) { 
  RC_28eb7999f57ca2adfa805d40364c85b5 s = new RC_28eb7999f57ca2adfa805d40364c85b5();
  if(obj != null) {
  s.ssSTAccordionItem_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure.ToStructure(obj.AttrAccordionItem_InternalConfigs, config);
  }
  return s;
}

public static Func<RC_28eb7999f57ca2adfa805d40364c85b5, ssOutSystemsUI.RestRecords.JSONRC_28eb7999f57ca2adfa805d40364c85b5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_28eb7999f57ca2adfa805d40364c85b5 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_28eb7999f57ca2adfa805d40364c85b5 FromStructure(RC_28eb7999f57ca2adfa805d40364c85b5 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_28eb7999f57ca2adfa805d40364c85b5(s, config);
}

}


