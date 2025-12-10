using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Carousel_InternalConfigRecord
public class RESTRC_098ae17f520233165dd0526529ff8852 : AbstractRESTStructure<RC_098ae17f520233165dd0526529ff8852> {
[JsonProperty("Carousel_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure AttrCarousel_InternalConfig;

public RESTRC_098ae17f520233165dd0526529ff8852() { }

public RESTRC_098ae17f520233165dd0526529ff8852 (RC_098ae17f520233165dd0526529ff8852 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarousel_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTCarousel_InternalConfig, new ST_736a0a0e931f1e6cffc1de4b3ad94539Structure(), ssOutSystemsUI.RestRecords.RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure.FromStructureDelegate(config));
  } else {
AttrCarousel_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure.FromStructure(s.ssSTCarousel_InternalConfig, config);
  }
}

public static RC_098ae17f520233165dd0526529ff8852 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_098ae17f520233165dd0526529ff8852 obj) { 
  RC_098ae17f520233165dd0526529ff8852 s = new RC_098ae17f520233165dd0526529ff8852();
  if(obj != null) {
  s.ssSTCarousel_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_736a0a0e931f1e6cffc1de4b3ad94539Structure.ToStructure(obj.AttrCarousel_InternalConfig);
  }
  return s;
}

public static Func<RC_098ae17f520233165dd0526529ff8852, ssOutSystemsUI.RestRecords.RESTRC_098ae17f520233165dd0526529ff8852> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_098ae17f520233165dd0526529ff8852 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_098ae17f520233165dd0526529ff8852 FromStructure(RC_098ae17f520233165dd0526529ff8852 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_098ae17f520233165dd0526529ff8852(s, config);
}

}


