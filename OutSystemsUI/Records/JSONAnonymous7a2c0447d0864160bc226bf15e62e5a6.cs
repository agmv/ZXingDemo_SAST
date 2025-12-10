using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FlatpickrConfigsRecord
public class JSONRC_f3c2b7b3f72abb115f72c934f4368624 : AbstractRESTStructure<RC_f3c2b7b3f72abb115f72c934f4368624> {
[JsonProperty("FlatpickrConfigs")]
[JsonPropertyName("FlatpickrConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_14b00646f6cd842655571448758d0a23Structure AttrFlatpickrConfigs;

public JSONRC_f3c2b7b3f72abb115f72c934f4368624() { }

public JSONRC_f3c2b7b3f72abb115f72c934f4368624 (RC_f3c2b7b3f72abb115f72c934f4368624 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFlatpickrConfigs = ConvertToRestWithoutDefaults(s.ssSTFlatpickrConfigs, new ST_14b00646f6cd842655571448758d0a23Structure(), ssOutSystemsUI.RestRecords.JSONST_14b00646f6cd842655571448758d0a23Structure.FromStructureDelegate(config));
  } else {
AttrFlatpickrConfigs = ssOutSystemsUI.RestRecords.JSONST_14b00646f6cd842655571448758d0a23Structure.FromStructure(s.ssSTFlatpickrConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_f3c2b7b3f72abb115f72c934f4368624, RC_f3c2b7b3f72abb115f72c934f4368624> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_f3c2b7b3f72abb115f72c934f4368624 s) => ToStructure(s, config);
}
public static RC_f3c2b7b3f72abb115f72c934f4368624 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_f3c2b7b3f72abb115f72c934f4368624 obj, IBehaviorsConfiguration config) { 
  RC_f3c2b7b3f72abb115f72c934f4368624 s = new RC_f3c2b7b3f72abb115f72c934f4368624();
  if(obj != null) {
  s.ssSTFlatpickrConfigs = ssOutSystemsUI.RestRecords.JSONST_14b00646f6cd842655571448758d0a23Structure.ToStructure(obj.AttrFlatpickrConfigs, config);
  }
  return s;
}

public static Func<RC_f3c2b7b3f72abb115f72c934f4368624, ssOutSystemsUI.RestRecords.JSONRC_f3c2b7b3f72abb115f72c934f4368624> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f3c2b7b3f72abb115f72c934f4368624 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_f3c2b7b3f72abb115f72c934f4368624 FromStructure(RC_f3c2b7b3f72abb115f72c934f4368624 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_f3c2b7b3f72abb115f72c934f4368624(s, config);
}

}


