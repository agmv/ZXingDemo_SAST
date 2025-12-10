using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MenuActionRecord
public class JSONRC_954cd1231210e70f33f184017bf580ac : AbstractRESTStructure<RC_954cd1231210e70f33f184017bf580ac> {
[JsonProperty("MenuAction")]
[JsonPropertyName("MenuAction")]
public ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord AttrMenuAction;

public JSONRC_954cd1231210e70f33f184017bf580ac() { }

public JSONRC_954cd1231210e70f33f184017bf580ac (RC_954cd1231210e70f33f184017bf580ac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMenuAction = ConvertToRestWithoutDefaults(s.ssENMenuAction, new EN_f43f179caddf7f7b68b18272d67285d6EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord.FromStructureDelegate(config));
  } else {
AttrMenuAction = ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord.FromStructure(s.ssENMenuAction, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_954cd1231210e70f33f184017bf580ac, RC_954cd1231210e70f33f184017bf580ac> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_954cd1231210e70f33f184017bf580ac s) => ToStructure(s, config);
}
public static RC_954cd1231210e70f33f184017bf580ac ToStructure(ssOutSystemsUI.RestRecords.JSONRC_954cd1231210e70f33f184017bf580ac obj, IBehaviorsConfiguration config) { 
  RC_954cd1231210e70f33f184017bf580ac s = new RC_954cd1231210e70f33f184017bf580ac();
  if(obj != null) {
  s.ssENMenuAction = ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord.ToStructure(obj.AttrMenuAction, config);
  }
  return s;
}

public static Func<RC_954cd1231210e70f33f184017bf580ac, ssOutSystemsUI.RestRecords.JSONRC_954cd1231210e70f33f184017bf580ac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_954cd1231210e70f33f184017bf580ac s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_954cd1231210e70f33f184017bf580ac FromStructure(RC_954cd1231210e70f33f184017bf580ac s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_954cd1231210e70f33f184017bf580ac(s, config);
}

}


