using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Carousel_InternalConfigRecord
public class JSONRC_098ae17f520233165dd0526529ff8852 : AbstractRESTStructure<RC_098ae17f520233165dd0526529ff8852> {
[JsonProperty("Carousel_InternalConfig")]
[JsonPropertyName("Carousel_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_736a0a0e931f1e6cffc1de4b3ad94539Structure AttrCarousel_InternalConfig;

public JSONRC_098ae17f520233165dd0526529ff8852() { }

public JSONRC_098ae17f520233165dd0526529ff8852 (RC_098ae17f520233165dd0526529ff8852 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarousel_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTCarousel_InternalConfig, new ST_736a0a0e931f1e6cffc1de4b3ad94539Structure(), ssOutSystemsUI.RestRecords.JSONST_736a0a0e931f1e6cffc1de4b3ad94539Structure.FromStructureDelegate(config));
  } else {
AttrCarousel_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_736a0a0e931f1e6cffc1de4b3ad94539Structure.FromStructure(s.ssSTCarousel_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_098ae17f520233165dd0526529ff8852, RC_098ae17f520233165dd0526529ff8852> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_098ae17f520233165dd0526529ff8852 s) => ToStructure(s, config);
}
public static RC_098ae17f520233165dd0526529ff8852 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_098ae17f520233165dd0526529ff8852 obj, IBehaviorsConfiguration config) { 
  RC_098ae17f520233165dd0526529ff8852 s = new RC_098ae17f520233165dd0526529ff8852();
  if(obj != null) {
  s.ssSTCarousel_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_736a0a0e931f1e6cffc1de4b3ad94539Structure.ToStructure(obj.AttrCarousel_InternalConfig, config);
  }
  return s;
}

public static Func<RC_098ae17f520233165dd0526529ff8852, ssOutSystemsUI.RestRecords.JSONRC_098ae17f520233165dd0526529ff8852> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_098ae17f520233165dd0526529ff8852 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_098ae17f520233165dd0526529ff8852 FromStructure(RC_098ae17f520233165dd0526529ff8852 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_098ae17f520233165dd0526529ff8852(s, config);
}

}


