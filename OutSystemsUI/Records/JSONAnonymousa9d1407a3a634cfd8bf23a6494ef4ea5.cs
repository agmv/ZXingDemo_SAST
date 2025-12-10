using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselDirectionRecord
public class JSONRC_fb5d22b1003cff234a588ab54b5367f0 : AbstractRESTStructure<RC_fb5d22b1003cff234a588ab54b5367f0> {
[JsonProperty("CarouselDirection")]
[JsonPropertyName("CarouselDirection")]
public ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord AttrCarouselDirection;

public JSONRC_fb5d22b1003cff234a588ab54b5367f0() { }

public JSONRC_fb5d22b1003cff234a588ab54b5367f0 (RC_fb5d22b1003cff234a588ab54b5367f0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarouselDirection = ConvertToRestWithoutDefaults(s.ssENCarouselDirection, new EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord.FromStructureDelegate(config));
  } else {
AttrCarouselDirection = ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord.FromStructure(s.ssENCarouselDirection, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_fb5d22b1003cff234a588ab54b5367f0, RC_fb5d22b1003cff234a588ab54b5367f0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_fb5d22b1003cff234a588ab54b5367f0 s) => ToStructure(s, config);
}
public static RC_fb5d22b1003cff234a588ab54b5367f0 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_fb5d22b1003cff234a588ab54b5367f0 obj, IBehaviorsConfiguration config) { 
  RC_fb5d22b1003cff234a588ab54b5367f0 s = new RC_fb5d22b1003cff234a588ab54b5367f0();
  if(obj != null) {
  s.ssENCarouselDirection = ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord.ToStructure(obj.AttrCarouselDirection, config);
  }
  return s;
}

public static Func<RC_fb5d22b1003cff234a588ab54b5367f0, ssOutSystemsUI.RestRecords.JSONRC_fb5d22b1003cff234a588ab54b5367f0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fb5d22b1003cff234a588ab54b5367f0 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_fb5d22b1003cff234a588ab54b5367f0 FromStructure(RC_fb5d22b1003cff234a588ab54b5367f0 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_fb5d22b1003cff234a588ab54b5367f0(s, config);
}

}


