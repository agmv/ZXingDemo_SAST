using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AccordionIconPositionRecord
public class RESTRC_ab72f035aa34ddb5ec313dc02adb1f18 : AbstractRESTStructure<RC_ab72f035aa34ddb5ec313dc02adb1f18> {
[JsonProperty("AccordionIconPosition")]
public ssOutSystemsUI.RestRecords.RESTEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord AttrAccordionIconPosition;

public RESTRC_ab72f035aa34ddb5ec313dc02adb1f18() { }

public RESTRC_ab72f035aa34ddb5ec313dc02adb1f18 (RC_ab72f035aa34ddb5ec313dc02adb1f18 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccordionIconPosition = ConvertToRestWithoutDefaults(s.ssENAccordionIconPosition, new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.FromStructureDelegate(config));
  } else {
AttrAccordionIconPosition = ssOutSystemsUI.RestRecords.RESTEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.FromStructure(s.ssENAccordionIconPosition, config);
  }
}

public static RC_ab72f035aa34ddb5ec313dc02adb1f18 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_ab72f035aa34ddb5ec313dc02adb1f18 obj) { 
  RC_ab72f035aa34ddb5ec313dc02adb1f18 s = new RC_ab72f035aa34ddb5ec313dc02adb1f18();
  if(obj != null) {
  s.ssENAccordionIconPosition = ssOutSystemsUI.RestRecords.RESTEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.ToStructure(obj.AttrAccordionIconPosition);
  }
  return s;
}

public static Func<RC_ab72f035aa34ddb5ec313dc02adb1f18, ssOutSystemsUI.RestRecords.RESTRC_ab72f035aa34ddb5ec313dc02adb1f18> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ab72f035aa34ddb5ec313dc02adb1f18 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_ab72f035aa34ddb5ec313dc02adb1f18 FromStructure(RC_ab72f035aa34ddb5ec313dc02adb1f18 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_ab72f035aa34ddb5ec313dc02adb1f18(s, config);
}

}


