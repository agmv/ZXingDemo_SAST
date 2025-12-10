using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselOptionalConfigsRecord
public class JSONRC_4028c83435ff8f3fa19c27e5a3252dd5 : AbstractRESTStructure<RC_4028c83435ff8f3fa19c27e5a3252dd5> {
[JsonProperty("CarouselOptionalConfigs")]
[JsonPropertyName("CarouselOptionalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure AttrCarouselOptionalConfigs;

public JSONRC_4028c83435ff8f3fa19c27e5a3252dd5() { }

public JSONRC_4028c83435ff8f3fa19c27e5a3252dd5 (RC_4028c83435ff8f3fa19c27e5a3252dd5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarouselOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTCarouselOptionalConfigs, new ST_7d99fd1de65649f174aff6854b052539Structure(), ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure.FromStructureDelegate(config));
  } else {
AttrCarouselOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure.FromStructure(s.ssSTCarouselOptionalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_4028c83435ff8f3fa19c27e5a3252dd5, RC_4028c83435ff8f3fa19c27e5a3252dd5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_4028c83435ff8f3fa19c27e5a3252dd5 s) => ToStructure(s, config);
}
public static RC_4028c83435ff8f3fa19c27e5a3252dd5 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_4028c83435ff8f3fa19c27e5a3252dd5 obj, IBehaviorsConfiguration config) { 
  RC_4028c83435ff8f3fa19c27e5a3252dd5 s = new RC_4028c83435ff8f3fa19c27e5a3252dd5();
  if(obj != null) {
  s.ssSTCarouselOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_7d99fd1de65649f174aff6854b052539Structure.ToStructure(obj.AttrCarouselOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_4028c83435ff8f3fa19c27e5a3252dd5, ssOutSystemsUI.RestRecords.JSONRC_4028c83435ff8f3fa19c27e5a3252dd5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4028c83435ff8f3fa19c27e5a3252dd5 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_4028c83435ff8f3fa19c27e5a3252dd5 FromStructure(RC_4028c83435ff8f3fa19c27e5a3252dd5 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_4028c83435ff8f3fa19c27e5a3252dd5(s, config);
}

}


