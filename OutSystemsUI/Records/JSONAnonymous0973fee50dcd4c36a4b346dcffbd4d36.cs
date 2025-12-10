using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerProviderRecord
public class JSONRC_8d60218511e7c5a6826e7f1bde0eda29 : AbstractRESTStructure<RC_8d60218511e7c5a6826e7f1bde0eda29> {
[JsonProperty("DatePickerProvider")]
[JsonPropertyName("DatePickerProvider")]
public ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord AttrDatePickerProvider;

public JSONRC_8d60218511e7c5a6826e7f1bde0eda29() { }

public JSONRC_8d60218511e7c5a6826e7f1bde0eda29 (RC_8d60218511e7c5a6826e7f1bde0eda29 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerProvider = ConvertToRestWithoutDefaults(s.ssENDatePickerProvider, new EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord.FromStructureDelegate(config));
  } else {
AttrDatePickerProvider = ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord.FromStructure(s.ssENDatePickerProvider, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_8d60218511e7c5a6826e7f1bde0eda29, RC_8d60218511e7c5a6826e7f1bde0eda29> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_8d60218511e7c5a6826e7f1bde0eda29 s) => ToStructure(s, config);
}
public static RC_8d60218511e7c5a6826e7f1bde0eda29 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_8d60218511e7c5a6826e7f1bde0eda29 obj, IBehaviorsConfiguration config) { 
  RC_8d60218511e7c5a6826e7f1bde0eda29 s = new RC_8d60218511e7c5a6826e7f1bde0eda29();
  if(obj != null) {
  s.ssENDatePickerProvider = ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord.ToStructure(obj.AttrDatePickerProvider, config);
  }
  return s;
}

public static Func<RC_8d60218511e7c5a6826e7f1bde0eda29, ssOutSystemsUI.RestRecords.JSONRC_8d60218511e7c5a6826e7f1bde0eda29> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d60218511e7c5a6826e7f1bde0eda29 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_8d60218511e7c5a6826e7f1bde0eda29 FromStructure(RC_8d60218511e7c5a6826e7f1bde0eda29 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_8d60218511e7c5a6826e7f1bde0eda29(s, config);
}

}


