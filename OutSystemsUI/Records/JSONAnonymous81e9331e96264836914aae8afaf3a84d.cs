using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownOptionalConfigsRecord
public class JSONRC_2ac88c51f2d9ed908454e6a06ffe188e : AbstractRESTStructure<RC_2ac88c51f2d9ed908454e6a06ffe188e> {
[JsonProperty("DropdownOptionalConfigs")]
[JsonPropertyName("DropdownOptionalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure AttrDropdownOptionalConfigs;

public JSONRC_2ac88c51f2d9ed908454e6a06ffe188e() { }

public JSONRC_2ac88c51f2d9ed908454e6a06ffe188e (RC_2ac88c51f2d9ed908454e6a06ffe188e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownOptionalConfigs, new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure(), ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure.FromStructureDelegate(config));
  } else {
AttrDropdownOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure.FromStructure(s.ssSTDropdownOptionalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_2ac88c51f2d9ed908454e6a06ffe188e, RC_2ac88c51f2d9ed908454e6a06ffe188e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_2ac88c51f2d9ed908454e6a06ffe188e s) => ToStructure(s, config);
}
public static RC_2ac88c51f2d9ed908454e6a06ffe188e ToStructure(ssOutSystemsUI.RestRecords.JSONRC_2ac88c51f2d9ed908454e6a06ffe188e obj, IBehaviorsConfiguration config) { 
  RC_2ac88c51f2d9ed908454e6a06ffe188e s = new RC_2ac88c51f2d9ed908454e6a06ffe188e();
  if(obj != null) {
  s.ssSTDropdownOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure.ToStructure(obj.AttrDropdownOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_2ac88c51f2d9ed908454e6a06ffe188e, ssOutSystemsUI.RestRecords.JSONRC_2ac88c51f2d9ed908454e6a06ffe188e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2ac88c51f2d9ed908454e6a06ffe188e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_2ac88c51f2d9ed908454e6a06ffe188e FromStructure(RC_2ac88c51f2d9ed908454e6a06ffe188e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_2ac88c51f2d9ed908454e6a06ffe188e(s, config);
}

}


