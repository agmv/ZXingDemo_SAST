using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalMarkerConfigsRecord
public class JSONRC_c97612a27be85a5532e2b3b5ddfcfa27 : AbstractRESTStructure<RC_c97612a27be85a5532e2b3b5ddfcfa27> {
[JsonProperty("OptionalMarkerConfigs")]
[JsonPropertyName("OptionalMarkerConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_7f069279f39dd7c7d2e7b5637a5b25c9Structure AttrOptionalMarkerConfigs;

public JSONRC_c97612a27be85a5532e2b3b5ddfcfa27() { }

public JSONRC_c97612a27be85a5532e2b3b5ddfcfa27 (RC_c97612a27be85a5532e2b3b5ddfcfa27 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalMarkerConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalMarkerConfigs, new ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure(), ssOutSystemsMaps.RestRecords.JSONST_7f069279f39dd7c7d2e7b5637a5b25c9Structure.FromStructureDelegate(config));
  } else {
AttrOptionalMarkerConfigs = ssOutSystemsMaps.RestRecords.JSONST_7f069279f39dd7c7d2e7b5637a5b25c9Structure.FromStructure(s.ssSTOptionalMarkerConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_c97612a27be85a5532e2b3b5ddfcfa27, RC_c97612a27be85a5532e2b3b5ddfcfa27> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_c97612a27be85a5532e2b3b5ddfcfa27 s) => ToStructure(s, config);
}
public static RC_c97612a27be85a5532e2b3b5ddfcfa27 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_c97612a27be85a5532e2b3b5ddfcfa27 obj, IBehaviorsConfiguration config) { 
  RC_c97612a27be85a5532e2b3b5ddfcfa27 s = new RC_c97612a27be85a5532e2b3b5ddfcfa27();
  if(obj != null) {
  s.ssSTOptionalMarkerConfigs = ssOutSystemsMaps.RestRecords.JSONST_7f069279f39dd7c7d2e7b5637a5b25c9Structure.ToStructure(obj.AttrOptionalMarkerConfigs, config);
  }
  return s;
}

public static Func<RC_c97612a27be85a5532e2b3b5ddfcfa27, ssOutSystemsMaps.RestRecords.JSONRC_c97612a27be85a5532e2b3b5ddfcfa27> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c97612a27be85a5532e2b3b5ddfcfa27 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_c97612a27be85a5532e2b3b5ddfcfa27 FromStructure(RC_c97612a27be85a5532e2b3b5ddfcfa27 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_c97612a27be85a5532e2b3b5ddfcfa27(s, config);
}

}


