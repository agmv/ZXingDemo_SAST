using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_configsRecord
public class RESTRC_3f581e27c2f72d4f78b5674dc475102b : AbstractRESTStructure<RC_3f581e27c2f72d4f78b5674dc475102b> {
[JsonProperty("Internal_to_provider_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure AttrInternal_to_provider_configs;

public RESTRC_3f581e27c2f72d4f78b5674dc475102b() { }

public RESTRC_3f581e27c2f72d4f78b5674dc475102b (RC_3f581e27c2f72d4f78b5674dc475102b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_configs, new ST_5baae74ed57e3bb61180aff1dadec4e1Structure(), ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_configs = ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure.FromStructure(s.ssSTInternal_to_provider_configs, config);
  }
}

public static RC_3f581e27c2f72d4f78b5674dc475102b ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_3f581e27c2f72d4f78b5674dc475102b obj) { 
  RC_3f581e27c2f72d4f78b5674dc475102b s = new RC_3f581e27c2f72d4f78b5674dc475102b();
  if(obj != null) {
  s.ssSTInternal_to_provider_configs = ssOutSystemsMaps.RestRecords.RESTST_5baae74ed57e3bb61180aff1dadec4e1Structure.ToStructure(obj.AttrInternal_to_provider_configs);
  }
  return s;
}

public static Func<RC_3f581e27c2f72d4f78b5674dc475102b, ssOutSystemsMaps.RestRecords.RESTRC_3f581e27c2f72d4f78b5674dc475102b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3f581e27c2f72d4f78b5674dc475102b s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_3f581e27c2f72d4f78b5674dc475102b FromStructure(RC_3f581e27c2f72d4f78b5674dc475102b s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_3f581e27c2f72d4f78b5674dc475102b(s, config);
}

}


