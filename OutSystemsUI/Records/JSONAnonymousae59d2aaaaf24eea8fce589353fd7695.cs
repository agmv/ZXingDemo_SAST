using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownProviderRecord
public class JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d : AbstractRESTStructure<RC_b31d17ba3ccc14eaadd4d2faf9371f2d> {
[JsonProperty("DropdownProvider")]
[JsonPropertyName("DropdownProvider")]
public ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord AttrDropdownProvider;

public JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d() { }

public JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d (RC_b31d17ba3ccc14eaadd4d2faf9371f2d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownProvider = ConvertToRestWithoutDefaults(s.ssENDropdownProvider, new EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord.FromStructureDelegate(config));
  } else {
AttrDropdownProvider = ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord.FromStructure(s.ssENDropdownProvider, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d, RC_b31d17ba3ccc14eaadd4d2faf9371f2d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d s) => ToStructure(s, config);
}
public static RC_b31d17ba3ccc14eaadd4d2faf9371f2d ToStructure(ssOutSystemsUI.RestRecords.JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d obj, IBehaviorsConfiguration config) { 
  RC_b31d17ba3ccc14eaadd4d2faf9371f2d s = new RC_b31d17ba3ccc14eaadd4d2faf9371f2d();
  if(obj != null) {
  s.ssENDropdownProvider = ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord.ToStructure(obj.AttrDropdownProvider, config);
  }
  return s;
}

public static Func<RC_b31d17ba3ccc14eaadd4d2faf9371f2d, ssOutSystemsUI.RestRecords.JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b31d17ba3ccc14eaadd4d2faf9371f2d s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d FromStructure(RC_b31d17ba3ccc14eaadd4d2faf9371f2d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_b31d17ba3ccc14eaadd4d2faf9371f2d(s, config);
}

}


