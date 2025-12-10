using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AccordionIconTypeRecord
public class JSONRC_73fae6920f82113320dccc89ef073c01 : AbstractRESTStructure<RC_73fae6920f82113320dccc89ef073c01> {
[JsonProperty("AccordionIconType")]
[JsonPropertyName("AccordionIconType")]
public ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord AttrAccordionIconType;

public JSONRC_73fae6920f82113320dccc89ef073c01() { }

public JSONRC_73fae6920f82113320dccc89ef073c01 (RC_73fae6920f82113320dccc89ef073c01 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccordionIconType = ConvertToRestWithoutDefaults(s.ssENAccordionIconType, new EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord.FromStructureDelegate(config));
  } else {
AttrAccordionIconType = ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord.FromStructure(s.ssENAccordionIconType, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_73fae6920f82113320dccc89ef073c01, RC_73fae6920f82113320dccc89ef073c01> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_73fae6920f82113320dccc89ef073c01 s) => ToStructure(s, config);
}
public static RC_73fae6920f82113320dccc89ef073c01 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_73fae6920f82113320dccc89ef073c01 obj, IBehaviorsConfiguration config) { 
  RC_73fae6920f82113320dccc89ef073c01 s = new RC_73fae6920f82113320dccc89ef073c01();
  if(obj != null) {
  s.ssENAccordionIconType = ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord.ToStructure(obj.AttrAccordionIconType, config);
  }
  return s;
}

public static Func<RC_73fae6920f82113320dccc89ef073c01, ssOutSystemsUI.RestRecords.JSONRC_73fae6920f82113320dccc89ef073c01> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_73fae6920f82113320dccc89ef073c01 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_73fae6920f82113320dccc89ef073c01 FromStructure(RC_73fae6920f82113320dccc89ef073c01 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_73fae6920f82113320dccc89ef073c01(s, config);
}

}


