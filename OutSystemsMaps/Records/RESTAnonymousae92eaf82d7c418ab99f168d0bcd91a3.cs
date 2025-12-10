using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_heatmapLayer_configsRecord
public class RESTRC_468bdef36a83c5e44a35aa87e6093ad0 : AbstractRESTStructure<RC_468bdef36a83c5e44a35aa87e6093ad0> {
[JsonProperty("Internal_to_provider_heatmapLayer_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure AttrInternal_to_provider_heatmapLayer_configs;

public RESTRC_468bdef36a83c5e44a35aa87e6093ad0() { }

public RESTRC_468bdef36a83c5e44a35aa87e6093ad0 (RC_468bdef36a83c5e44a35aa87e6093ad0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_heatmapLayer_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_heatmapLayer_configs, new ST_ca5fecbdf222b72d179909c1f030119cStructure(), ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_heatmapLayer_configs = ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure.FromStructure(s.ssSTInternal_to_provider_heatmapLayer_configs, config);
  }
}

public static RC_468bdef36a83c5e44a35aa87e6093ad0 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_468bdef36a83c5e44a35aa87e6093ad0 obj) { 
  RC_468bdef36a83c5e44a35aa87e6093ad0 s = new RC_468bdef36a83c5e44a35aa87e6093ad0();
  if(obj != null) {
  s.ssSTInternal_to_provider_heatmapLayer_configs = ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure.ToStructure(obj.AttrInternal_to_provider_heatmapLayer_configs);
  }
  return s;
}

public static Func<RC_468bdef36a83c5e44a35aa87e6093ad0, ssOutSystemsMaps.RestRecords.RESTRC_468bdef36a83c5e44a35aa87e6093ad0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_468bdef36a83c5e44a35aa87e6093ad0 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_468bdef36a83c5e44a35aa87e6093ad0 FromStructure(RC_468bdef36a83c5e44a35aa87e6093ad0 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_468bdef36a83c5e44a35aa87e6093ad0(s, config);
}

}


