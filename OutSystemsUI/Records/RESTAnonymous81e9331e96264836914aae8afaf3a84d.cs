using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownOptionalConfigsRecord
public class RESTRC_2ac88c51f2d9ed908454e6a06ffe188e : AbstractRESTStructure<RC_2ac88c51f2d9ed908454e6a06ffe188e> {
[JsonProperty("DropdownOptionalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure AttrDropdownOptionalConfigs;

public RESTRC_2ac88c51f2d9ed908454e6a06ffe188e() { }

public RESTRC_2ac88c51f2d9ed908454e6a06ffe188e (RC_2ac88c51f2d9ed908454e6a06ffe188e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownOptionalConfigs, new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure(), ssOutSystemsUI.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure.FromStructureDelegate(config));
  } else {
AttrDropdownOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure.FromStructure(s.ssSTDropdownOptionalConfigs, config);
  }
}

public static RC_2ac88c51f2d9ed908454e6a06ffe188e ToStructure(ssOutSystemsUI.RestRecords.RESTRC_2ac88c51f2d9ed908454e6a06ffe188e obj) { 
  RC_2ac88c51f2d9ed908454e6a06ffe188e s = new RC_2ac88c51f2d9ed908454e6a06ffe188e();
  if(obj != null) {
  s.ssSTDropdownOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure.ToStructure(obj.AttrDropdownOptionalConfigs);
  }
  return s;
}

public static Func<RC_2ac88c51f2d9ed908454e6a06ffe188e, ssOutSystemsUI.RestRecords.RESTRC_2ac88c51f2d9ed908454e6a06ffe188e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2ac88c51f2d9ed908454e6a06ffe188e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_2ac88c51f2d9ed908454e6a06ffe188e FromStructure(RC_2ac88c51f2d9ed908454e6a06ffe188e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_2ac88c51f2d9ed908454e6a06ffe188e(s, config);
}

}


