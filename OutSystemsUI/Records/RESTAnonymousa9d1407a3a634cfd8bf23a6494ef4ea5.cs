using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselDirectionRecord
public class RESTRC_fb5d22b1003cff234a588ab54b5367f0 : AbstractRESTStructure<RC_fb5d22b1003cff234a588ab54b5367f0> {
[JsonProperty("CarouselDirection")]
public ssOutSystemsUI.RestRecords.RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord AttrCarouselDirection;

public RESTRC_fb5d22b1003cff234a588ab54b5367f0() { }

public RESTRC_fb5d22b1003cff234a588ab54b5367f0 (RC_fb5d22b1003cff234a588ab54b5367f0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarouselDirection = ConvertToRestWithoutDefaults(s.ssENCarouselDirection, new EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord.FromStructureDelegate(config));
  } else {
AttrCarouselDirection = ssOutSystemsUI.RestRecords.RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord.FromStructure(s.ssENCarouselDirection, config);
  }
}

public static RC_fb5d22b1003cff234a588ab54b5367f0 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_fb5d22b1003cff234a588ab54b5367f0 obj) { 
  RC_fb5d22b1003cff234a588ab54b5367f0 s = new RC_fb5d22b1003cff234a588ab54b5367f0();
  if(obj != null) {
  s.ssENCarouselDirection = ssOutSystemsUI.RestRecords.RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord.ToStructure(obj.AttrCarouselDirection);
  }
  return s;
}

public static Func<RC_fb5d22b1003cff234a588ab54b5367f0, ssOutSystemsUI.RestRecords.RESTRC_fb5d22b1003cff234a588ab54b5367f0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fb5d22b1003cff234a588ab54b5367f0 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_fb5d22b1003cff234a588ab54b5367f0 FromStructure(RC_fb5d22b1003cff234a588ab54b5367f0 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_fb5d22b1003cff234a588ab54b5367f0(s, config);
}

}


