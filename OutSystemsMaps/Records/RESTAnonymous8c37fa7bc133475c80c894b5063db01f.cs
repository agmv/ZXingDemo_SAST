using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_drawNotFilledShape_configsRecord
public class RESTRC_7c2c1d82e3a31f1ec5d5faa260c033b7 : AbstractRESTStructure<RC_7c2c1d82e3a31f1ec5d5faa260c033b7> {
[JsonProperty("Internal_to_provider_drawNotFilledShape_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure AttrInternal_to_provider_drawNotFilledShape_configs;

public RESTRC_7c2c1d82e3a31f1ec5d5faa260c033b7() { }

public RESTRC_7c2c1d82e3a31f1ec5d5faa260c033b7 (RC_7c2c1d82e3a31f1ec5d5faa260c033b7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_drawNotFilledShape_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_drawNotFilledShape_configs, new ST_86d2610e9625abf0ecb7241e6d8099fbStructure(), ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_drawNotFilledShape_configs = ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure.FromStructure(s.ssSTInternal_to_provider_drawNotFilledShape_configs, config);
  }
}

public static RC_7c2c1d82e3a31f1ec5d5faa260c033b7 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_7c2c1d82e3a31f1ec5d5faa260c033b7 obj) { 
  RC_7c2c1d82e3a31f1ec5d5faa260c033b7 s = new RC_7c2c1d82e3a31f1ec5d5faa260c033b7();
  if(obj != null) {
  s.ssSTInternal_to_provider_drawNotFilledShape_configs = ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure.ToStructure(obj.AttrInternal_to_provider_drawNotFilledShape_configs);
  }
  return s;
}

public static Func<RC_7c2c1d82e3a31f1ec5d5faa260c033b7, ssOutSystemsMaps.RestRecords.RESTRC_7c2c1d82e3a31f1ec5d5faa260c033b7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7c2c1d82e3a31f1ec5d5faa260c033b7 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_7c2c1d82e3a31f1ec5d5faa260c033b7 FromStructure(RC_7c2c1d82e3a31f1ec5d5faa260c033b7 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_7c2c1d82e3a31f1ec5d5faa260c033b7(s, config);
}

}


