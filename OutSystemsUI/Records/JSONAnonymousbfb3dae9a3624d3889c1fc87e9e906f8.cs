using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselProviderRecord
public class JSONRC_60ed22b1487b1e18edb2fceb277aa5d1 : AbstractRESTStructure<RC_60ed22b1487b1e18edb2fceb277aa5d1> {
[JsonProperty("CarouselProvider")]
[JsonPropertyName("CarouselProvider")]
public ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord AttrCarouselProvider;

public JSONRC_60ed22b1487b1e18edb2fceb277aa5d1() { }

public JSONRC_60ed22b1487b1e18edb2fceb277aa5d1 (RC_60ed22b1487b1e18edb2fceb277aa5d1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarouselProvider = ConvertToRestWithoutDefaults(s.ssENCarouselProvider, new EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord.FromStructureDelegate(config));
  } else {
AttrCarouselProvider = ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord.FromStructure(s.ssENCarouselProvider, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_60ed22b1487b1e18edb2fceb277aa5d1, RC_60ed22b1487b1e18edb2fceb277aa5d1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_60ed22b1487b1e18edb2fceb277aa5d1 s) => ToStructure(s, config);
}
public static RC_60ed22b1487b1e18edb2fceb277aa5d1 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_60ed22b1487b1e18edb2fceb277aa5d1 obj, IBehaviorsConfiguration config) { 
  RC_60ed22b1487b1e18edb2fceb277aa5d1 s = new RC_60ed22b1487b1e18edb2fceb277aa5d1();
  if(obj != null) {
  s.ssENCarouselProvider = ssOutSystemsUI.RestRecords.JSONEN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord.ToStructure(obj.AttrCarouselProvider, config);
  }
  return s;
}

public static Func<RC_60ed22b1487b1e18edb2fceb277aa5d1, ssOutSystemsUI.RestRecords.JSONRC_60ed22b1487b1e18edb2fceb277aa5d1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60ed22b1487b1e18edb2fceb277aa5d1 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_60ed22b1487b1e18edb2fceb277aa5d1 FromStructure(RC_60ed22b1487b1e18edb2fceb277aa5d1 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_60ed22b1487b1e18edb2fceb277aa5d1(s, config);
}

}


