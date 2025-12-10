using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselNavigationRecord
public class RESTRC_373fec8a2329a8b1ecd55cf717893131 : AbstractRESTStructure<RC_373fec8a2329a8b1ecd55cf717893131> {
[JsonProperty("CarouselNavigation")]
public ssOutSystemsUI.RestRecords.RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord AttrCarouselNavigation;

public RESTRC_373fec8a2329a8b1ecd55cf717893131() { }

public RESTRC_373fec8a2329a8b1ecd55cf717893131 (RC_373fec8a2329a8b1ecd55cf717893131 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarouselNavigation = ConvertToRestWithoutDefaults(s.ssENCarouselNavigation, new EN_59aacee1cb91627a0f497366b24e4500EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord.FromStructureDelegate(config));
  } else {
AttrCarouselNavigation = ssOutSystemsUI.RestRecords.RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord.FromStructure(s.ssENCarouselNavigation, config);
  }
}

public static RC_373fec8a2329a8b1ecd55cf717893131 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_373fec8a2329a8b1ecd55cf717893131 obj) { 
  RC_373fec8a2329a8b1ecd55cf717893131 s = new RC_373fec8a2329a8b1ecd55cf717893131();
  if(obj != null) {
  s.ssENCarouselNavigation = ssOutSystemsUI.RestRecords.RESTEN_59aacee1cb91627a0f497366b24e4500EntityRecord.ToStructure(obj.AttrCarouselNavigation);
  }
  return s;
}

public static Func<RC_373fec8a2329a8b1ecd55cf717893131, ssOutSystemsUI.RestRecords.RESTRC_373fec8a2329a8b1ecd55cf717893131> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_373fec8a2329a8b1ecd55cf717893131 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_373fec8a2329a8b1ecd55cf717893131 FromStructure(RC_373fec8a2329a8b1ecd55cf717893131 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_373fec8a2329a8b1ecd55cf717893131(s, config);
}

}


