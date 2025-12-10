using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselProviderRecord
public class RESTRC_60ed22b1487b1e18edb2fceb277aa5d1 : AbstractRESTStructure<RC_60ed22b1487b1e18edb2fceb277aa5d1> {
[JsonProperty("CarouselProvider")]
public ssOutSystemsUI.RestRecords.RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord AttrCarouselProvider;

public RESTRC_60ed22b1487b1e18edb2fceb277aa5d1() { }

public RESTRC_60ed22b1487b1e18edb2fceb277aa5d1 (RC_60ed22b1487b1e18edb2fceb277aa5d1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarouselProvider = ConvertToRestWithoutDefaults(s.ssENCarouselProvider, new EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord.FromStructureDelegate(config));
  } else {
AttrCarouselProvider = ssOutSystemsUI.RestRecords.RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord.FromStructure(s.ssENCarouselProvider, config);
  }
}

public static RC_60ed22b1487b1e18edb2fceb277aa5d1 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_60ed22b1487b1e18edb2fceb277aa5d1 obj) { 
  RC_60ed22b1487b1e18edb2fceb277aa5d1 s = new RC_60ed22b1487b1e18edb2fceb277aa5d1();
  if(obj != null) {
  s.ssENCarouselProvider = ssOutSystemsUI.RestRecords.RESTEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord.ToStructure(obj.AttrCarouselProvider);
  }
  return s;
}

public static Func<RC_60ed22b1487b1e18edb2fceb277aa5d1, ssOutSystemsUI.RestRecords.RESTRC_60ed22b1487b1e18edb2fceb277aa5d1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60ed22b1487b1e18edb2fceb277aa5d1 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_60ed22b1487b1e18edb2fceb277aa5d1 FromStructure(RC_60ed22b1487b1e18edb2fceb277aa5d1 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_60ed22b1487b1e18edb2fceb277aa5d1(s, config);
}

}


