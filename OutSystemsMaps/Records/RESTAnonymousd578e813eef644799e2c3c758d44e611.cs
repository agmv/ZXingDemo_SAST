using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_drawFilledShape_configsRecord
public class RESTRC_794e39fc977eff2817cb99ab6af38d57 : AbstractRESTStructure<RC_794e39fc977eff2817cb99ab6af38d57> {
[JsonProperty("Internal_to_provider_drawFilledShape_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure AttrInternal_to_provider_drawFilledShape_configs;

public RESTRC_794e39fc977eff2817cb99ab6af38d57() { }

public RESTRC_794e39fc977eff2817cb99ab6af38d57 (RC_794e39fc977eff2817cb99ab6af38d57 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_drawFilledShape_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_drawFilledShape_configs, new ST_d25262c67f1be04c1df274811b8c7ee4Structure(), ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_drawFilledShape_configs = ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure.FromStructure(s.ssSTInternal_to_provider_drawFilledShape_configs, config);
  }
}

public static RC_794e39fc977eff2817cb99ab6af38d57 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_794e39fc977eff2817cb99ab6af38d57 obj) { 
  RC_794e39fc977eff2817cb99ab6af38d57 s = new RC_794e39fc977eff2817cb99ab6af38d57();
  if(obj != null) {
  s.ssSTInternal_to_provider_drawFilledShape_configs = ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure.ToStructure(obj.AttrInternal_to_provider_drawFilledShape_configs);
  }
  return s;
}

public static Func<RC_794e39fc977eff2817cb99ab6af38d57, ssOutSystemsMaps.RestRecords.RESTRC_794e39fc977eff2817cb99ab6af38d57> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_794e39fc977eff2817cb99ab6af38d57 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_794e39fc977eff2817cb99ab6af38d57 FromStructure(RC_794e39fc977eff2817cb99ab6af38d57 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_794e39fc977eff2817cb99ab6af38d57(s, config);
}

}


