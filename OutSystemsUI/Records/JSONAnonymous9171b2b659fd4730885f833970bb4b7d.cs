using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AccordionIconPositionRecord
public class JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 : AbstractRESTStructure<RC_ab72f035aa34ddb5ec313dc02adb1f18> {
[JsonProperty("AccordionIconPosition")]
[JsonPropertyName("AccordionIconPosition")]
public ssOutSystemsUI.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord AttrAccordionIconPosition;

public JSONRC_ab72f035aa34ddb5ec313dc02adb1f18() { }

public JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 (RC_ab72f035aa34ddb5ec313dc02adb1f18 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccordionIconPosition = ConvertToRestWithoutDefaults(s.ssENAccordionIconPosition, new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.FromStructureDelegate(config));
  } else {
AttrAccordionIconPosition = ssOutSystemsUI.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.FromStructure(s.ssENAccordionIconPosition, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18, RC_ab72f035aa34ddb5ec313dc02adb1f18> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 s) => ToStructure(s, config);
}
public static RC_ab72f035aa34ddb5ec313dc02adb1f18 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 obj, IBehaviorsConfiguration config) { 
  RC_ab72f035aa34ddb5ec313dc02adb1f18 s = new RC_ab72f035aa34ddb5ec313dc02adb1f18();
  if(obj != null) {
  s.ssENAccordionIconPosition = ssOutSystemsUI.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.ToStructure(obj.AttrAccordionIconPosition, config);
  }
  return s;
}

public static Func<RC_ab72f035aa34ddb5ec313dc02adb1f18, ssOutSystemsUI.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ab72f035aa34ddb5ec313dc02adb1f18 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 FromStructure(RC_ab72f035aa34ddb5ec313dc02adb1f18 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18(s, config);
}

}


