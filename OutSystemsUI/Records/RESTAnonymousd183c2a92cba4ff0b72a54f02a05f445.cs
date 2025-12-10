using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselOptionalConfigsRecord
public class RESTRC_4028c83435ff8f3fa19c27e5a3252dd5 : AbstractRESTStructure<RC_4028c83435ff8f3fa19c27e5a3252dd5> {
[JsonProperty("CarouselOptionalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_7d99fd1de65649f174aff6854b052539Structure AttrCarouselOptionalConfigs;

public RESTRC_4028c83435ff8f3fa19c27e5a3252dd5() { }

public RESTRC_4028c83435ff8f3fa19c27e5a3252dd5 (RC_4028c83435ff8f3fa19c27e5a3252dd5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarouselOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTCarouselOptionalConfigs, new ST_7d99fd1de65649f174aff6854b052539Structure(), ssOutSystemsUI.RestRecords.RESTST_7d99fd1de65649f174aff6854b052539Structure.FromStructureDelegate(config));
  } else {
AttrCarouselOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_7d99fd1de65649f174aff6854b052539Structure.FromStructure(s.ssSTCarouselOptionalConfigs, config);
  }
}

public static RC_4028c83435ff8f3fa19c27e5a3252dd5 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_4028c83435ff8f3fa19c27e5a3252dd5 obj) { 
  RC_4028c83435ff8f3fa19c27e5a3252dd5 s = new RC_4028c83435ff8f3fa19c27e5a3252dd5();
  if(obj != null) {
  s.ssSTCarouselOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_7d99fd1de65649f174aff6854b052539Structure.ToStructure(obj.AttrCarouselOptionalConfigs);
  }
  return s;
}

public static Func<RC_4028c83435ff8f3fa19c27e5a3252dd5, ssOutSystemsUI.RestRecords.RESTRC_4028c83435ff8f3fa19c27e5a3252dd5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4028c83435ff8f3fa19c27e5a3252dd5 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_4028c83435ff8f3fa19c27e5a3252dd5 FromStructure(RC_4028c83435ff8f3fa19c27e5a3252dd5 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_4028c83435ff8f3fa19c27e5a3252dd5(s, config);
}

}


