using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownProviderRecord
public class RESTRC_b31d17ba3ccc14eaadd4d2faf9371f2d : AbstractRESTStructure<RC_b31d17ba3ccc14eaadd4d2faf9371f2d> {
[JsonProperty("DropdownProvider")]
public ssOutSystemsUI.RestRecords.RESTEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord AttrDropdownProvider;

public RESTRC_b31d17ba3ccc14eaadd4d2faf9371f2d() { }

public RESTRC_b31d17ba3ccc14eaadd4d2faf9371f2d (RC_b31d17ba3ccc14eaadd4d2faf9371f2d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownProvider = ConvertToRestWithoutDefaults(s.ssENDropdownProvider, new EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord.FromStructureDelegate(config));
  } else {
AttrDropdownProvider = ssOutSystemsUI.RestRecords.RESTEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord.FromStructure(s.ssENDropdownProvider, config);
  }
}

public static RC_b31d17ba3ccc14eaadd4d2faf9371f2d ToStructure(ssOutSystemsUI.RestRecords.RESTRC_b31d17ba3ccc14eaadd4d2faf9371f2d obj) { 
  RC_b31d17ba3ccc14eaadd4d2faf9371f2d s = new RC_b31d17ba3ccc14eaadd4d2faf9371f2d();
  if(obj != null) {
  s.ssENDropdownProvider = ssOutSystemsUI.RestRecords.RESTEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord.ToStructure(obj.AttrDropdownProvider);
  }
  return s;
}

public static Func<RC_b31d17ba3ccc14eaadd4d2faf9371f2d, ssOutSystemsUI.RestRecords.RESTRC_b31d17ba3ccc14eaadd4d2faf9371f2d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b31d17ba3ccc14eaadd4d2faf9371f2d s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_b31d17ba3ccc14eaadd4d2faf9371f2d FromStructure(RC_b31d17ba3ccc14eaadd4d2faf9371f2d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_b31d17ba3ccc14eaadd4d2faf9371f2d(s, config);
}

}


