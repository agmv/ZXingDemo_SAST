using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SideMenuBehaviorRecord
public class RESTRC_e3607d6b92545e5793fbeb99fc16b7e7 : AbstractRESTStructure<RC_e3607d6b92545e5793fbeb99fc16b7e7> {
[JsonProperty("SideMenuBehavior")]
public ssOutSystemsUI.RestRecords.RESTEN_c1e622743b79c1510fd62a0adf89686bEntityRecord AttrSideMenuBehavior;

public RESTRC_e3607d6b92545e5793fbeb99fc16b7e7() { }

public RESTRC_e3607d6b92545e5793fbeb99fc16b7e7 (RC_e3607d6b92545e5793fbeb99fc16b7e7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSideMenuBehavior = ConvertToRestWithoutDefaults(s.ssENSideMenuBehavior, new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_c1e622743b79c1510fd62a0adf89686bEntityRecord.FromStructureDelegate(config));
  } else {
AttrSideMenuBehavior = ssOutSystemsUI.RestRecords.RESTEN_c1e622743b79c1510fd62a0adf89686bEntityRecord.FromStructure(s.ssENSideMenuBehavior, config);
  }
}

public static RC_e3607d6b92545e5793fbeb99fc16b7e7 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_e3607d6b92545e5793fbeb99fc16b7e7 obj) { 
  RC_e3607d6b92545e5793fbeb99fc16b7e7 s = new RC_e3607d6b92545e5793fbeb99fc16b7e7();
  if(obj != null) {
  s.ssENSideMenuBehavior = ssOutSystemsUI.RestRecords.RESTEN_c1e622743b79c1510fd62a0adf89686bEntityRecord.ToStructure(obj.AttrSideMenuBehavior);
  }
  return s;
}

public static Func<RC_e3607d6b92545e5793fbeb99fc16b7e7, ssOutSystemsUI.RestRecords.RESTRC_e3607d6b92545e5793fbeb99fc16b7e7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3607d6b92545e5793fbeb99fc16b7e7 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_e3607d6b92545e5793fbeb99fc16b7e7 FromStructure(RC_e3607d6b92545e5793fbeb99fc16b7e7 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_e3607d6b92545e5793fbeb99fc16b7e7(s, config);
}

}


