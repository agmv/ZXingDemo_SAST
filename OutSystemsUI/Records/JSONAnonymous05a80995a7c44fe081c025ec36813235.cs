using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// GradientRecord
public class JSONRC_3f6426aeecbfa4af19e279847df746cc : AbstractRESTStructure<RC_3f6426aeecbfa4af19e279847df746cc> {
[JsonProperty("Gradient")]
[JsonPropertyName("Gradient")]
public ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord AttrGradient;

public JSONRC_3f6426aeecbfa4af19e279847df746cc() { }

public JSONRC_3f6426aeecbfa4af19e279847df746cc (RC_3f6426aeecbfa4af19e279847df746cc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGradient = ConvertToRestWithoutDefaults(s.ssENGradient, new EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord.FromStructureDelegate(config));
  } else {
AttrGradient = ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord.FromStructure(s.ssENGradient, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_3f6426aeecbfa4af19e279847df746cc, RC_3f6426aeecbfa4af19e279847df746cc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_3f6426aeecbfa4af19e279847df746cc s) => ToStructure(s, config);
}
public static RC_3f6426aeecbfa4af19e279847df746cc ToStructure(ssOutSystemsUI.RestRecords.JSONRC_3f6426aeecbfa4af19e279847df746cc obj, IBehaviorsConfiguration config) { 
  RC_3f6426aeecbfa4af19e279847df746cc s = new RC_3f6426aeecbfa4af19e279847df746cc();
  if(obj != null) {
  s.ssENGradient = ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord.ToStructure(obj.AttrGradient, config);
  }
  return s;
}

public static Func<RC_3f6426aeecbfa4af19e279847df746cc, ssOutSystemsUI.RestRecords.JSONRC_3f6426aeecbfa4af19e279847df746cc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3f6426aeecbfa4af19e279847df746cc s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_3f6426aeecbfa4af19e279847df746cc FromStructure(RC_3f6426aeecbfa4af19e279847df746cc s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_3f6426aeecbfa4af19e279847df746cc(s, config);
}

}


