using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FlatpickrConfigsRecord
public class RESTRC_f3c2b7b3f72abb115f72c934f4368624 : AbstractRESTStructure<RC_f3c2b7b3f72abb115f72c934f4368624> {
[JsonProperty("FlatpickrConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_14b00646f6cd842655571448758d0a23Structure AttrFlatpickrConfigs;

public RESTRC_f3c2b7b3f72abb115f72c934f4368624() { }

public RESTRC_f3c2b7b3f72abb115f72c934f4368624 (RC_f3c2b7b3f72abb115f72c934f4368624 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFlatpickrConfigs = ConvertToRestWithoutDefaults(s.ssSTFlatpickrConfigs, new ST_14b00646f6cd842655571448758d0a23Structure(), ssOutSystemsUI.RestRecords.RESTST_14b00646f6cd842655571448758d0a23Structure.FromStructureDelegate(config));
  } else {
AttrFlatpickrConfigs = ssOutSystemsUI.RestRecords.RESTST_14b00646f6cd842655571448758d0a23Structure.FromStructure(s.ssSTFlatpickrConfigs, config);
  }
}

public static RC_f3c2b7b3f72abb115f72c934f4368624 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_f3c2b7b3f72abb115f72c934f4368624 obj) { 
  RC_f3c2b7b3f72abb115f72c934f4368624 s = new RC_f3c2b7b3f72abb115f72c934f4368624();
  if(obj != null) {
  s.ssSTFlatpickrConfigs = ssOutSystemsUI.RestRecords.RESTST_14b00646f6cd842655571448758d0a23Structure.ToStructure(obj.AttrFlatpickrConfigs);
  }
  return s;
}

public static Func<RC_f3c2b7b3f72abb115f72c934f4368624, ssOutSystemsUI.RestRecords.RESTRC_f3c2b7b3f72abb115f72c934f4368624> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f3c2b7b3f72abb115f72c934f4368624 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_f3c2b7b3f72abb115f72c934f4368624 FromStructure(RC_f3c2b7b3f72abb115f72c934f4368624 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_f3c2b7b3f72abb115f72c934f4368624(s, config);
}

}


