using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalShapeConfigsRecord
public class RESTRC_f413938d99b2f109b9b51d646a4937af : AbstractRESTStructure<RC_f413938d99b2f109b9b51d646a4937af> {
[JsonProperty("OptionalShapeConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_f021741499f997a32540fab3dfcdbbfaStructure AttrOptionalShapeConfigs;

public RESTRC_f413938d99b2f109b9b51d646a4937af() { }

public RESTRC_f413938d99b2f109b9b51d646a4937af (RC_f413938d99b2f109b9b51d646a4937af s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalShapeConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalShapeConfigs, new ST_f021741499f997a32540fab3dfcdbbfaStructure(), ssOutSystemsMaps.RestRecords.RESTST_f021741499f997a32540fab3dfcdbbfaStructure.FromStructureDelegate(config));
  } else {
AttrOptionalShapeConfigs = ssOutSystemsMaps.RestRecords.RESTST_f021741499f997a32540fab3dfcdbbfaStructure.FromStructure(s.ssSTOptionalShapeConfigs, config);
  }
}

public static RC_f413938d99b2f109b9b51d646a4937af ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_f413938d99b2f109b9b51d646a4937af obj) { 
  RC_f413938d99b2f109b9b51d646a4937af s = new RC_f413938d99b2f109b9b51d646a4937af();
  if(obj != null) {
  s.ssSTOptionalShapeConfigs = ssOutSystemsMaps.RestRecords.RESTST_f021741499f997a32540fab3dfcdbbfaStructure.ToStructure(obj.AttrOptionalShapeConfigs);
  }
  return s;
}

public static Func<RC_f413938d99b2f109b9b51d646a4937af, ssOutSystemsMaps.RestRecords.RESTRC_f413938d99b2f109b9b51d646a4937af> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f413938d99b2f109b9b51d646a4937af s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_f413938d99b2f109b9b51d646a4937af FromStructure(RC_f413938d99b2f109b9b51d646a4937af s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_f413938d99b2f109b9b51d646a4937af(s, config);
}

}


