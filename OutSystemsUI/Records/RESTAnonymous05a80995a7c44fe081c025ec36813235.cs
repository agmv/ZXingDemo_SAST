using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// GradientRecord
public class RESTRC_3f6426aeecbfa4af19e279847df746cc : AbstractRESTStructure<RC_3f6426aeecbfa4af19e279847df746cc> {
[JsonProperty("Gradient")]
public ssOutSystemsUI.RestRecords.RESTEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord AttrGradient;

public RESTRC_3f6426aeecbfa4af19e279847df746cc() { }

public RESTRC_3f6426aeecbfa4af19e279847df746cc (RC_3f6426aeecbfa4af19e279847df746cc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGradient = ConvertToRestWithoutDefaults(s.ssENGradient, new EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord.FromStructureDelegate(config));
  } else {
AttrGradient = ssOutSystemsUI.RestRecords.RESTEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord.FromStructure(s.ssENGradient, config);
  }
}

public static RC_3f6426aeecbfa4af19e279847df746cc ToStructure(ssOutSystemsUI.RestRecords.RESTRC_3f6426aeecbfa4af19e279847df746cc obj) { 
  RC_3f6426aeecbfa4af19e279847df746cc s = new RC_3f6426aeecbfa4af19e279847df746cc();
  if(obj != null) {
  s.ssENGradient = ssOutSystemsUI.RestRecords.RESTEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord.ToStructure(obj.AttrGradient);
  }
  return s;
}

public static Func<RC_3f6426aeecbfa4af19e279847df746cc, ssOutSystemsUI.RestRecords.RESTRC_3f6426aeecbfa4af19e279847df746cc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3f6426aeecbfa4af19e279847df746cc s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_3f6426aeecbfa4af19e279847df746cc FromStructure(RC_3f6426aeecbfa4af19e279847df746cc s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_3f6426aeecbfa4af19e279847df746cc(s, config);
}

}


