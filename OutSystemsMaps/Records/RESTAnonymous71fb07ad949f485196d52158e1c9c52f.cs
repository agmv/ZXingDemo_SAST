using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_ConfigsRecord
public class RESTRC_afeb3af87221b535eb5e95ea10936666 : AbstractRESTStructure<RC_afeb3af87221b535eb5e95ea10936666> {
[JsonProperty("Internal_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure AttrInternal_Configs;

public RESTRC_afeb3af87221b535eb5e95ea10936666() { }

public RESTRC_afeb3af87221b535eb5e95ea10936666 (RC_afeb3af87221b535eb5e95ea10936666 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_Configs, new ST_78d3133d124713193d703c2644ecd39bStructure(), ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure.FromStructureDelegate(config));
  } else {
AttrInternal_Configs = ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure.FromStructure(s.ssSTInternal_Configs, config);
  }
}

public static RC_afeb3af87221b535eb5e95ea10936666 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_afeb3af87221b535eb5e95ea10936666 obj) { 
  RC_afeb3af87221b535eb5e95ea10936666 s = new RC_afeb3af87221b535eb5e95ea10936666();
  if(obj != null) {
  s.ssSTInternal_Configs = ssOutSystemsMaps.RestRecords.RESTST_78d3133d124713193d703c2644ecd39bStructure.ToStructure(obj.AttrInternal_Configs);
  }
  return s;
}

public static Func<RC_afeb3af87221b535eb5e95ea10936666, ssOutSystemsMaps.RestRecords.RESTRC_afeb3af87221b535eb5e95ea10936666> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_afeb3af87221b535eb5e95ea10936666 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_afeb3af87221b535eb5e95ea10936666 FromStructure(RC_afeb3af87221b535eb5e95ea10936666 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_afeb3af87221b535eb5e95ea10936666(s, config);
}

}


