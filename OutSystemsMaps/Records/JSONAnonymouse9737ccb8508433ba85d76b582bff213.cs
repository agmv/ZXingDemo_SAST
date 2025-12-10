using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// PointsRecord
public class JSONRC_f6c2f142af073709395973c555ac9ddc : AbstractRESTStructure<RC_f6c2f142af073709395973c555ac9ddc> {
[JsonProperty("Points")]
[JsonPropertyName("Points")]
public ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure AttrPoints;

public JSONRC_f6c2f142af073709395973c555ac9ddc() { }

public JSONRC_f6c2f142af073709395973c555ac9ddc (RC_f6c2f142af073709395973c555ac9ddc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPoints = ConvertToRestWithoutDefaults(s.ssSTPoints, new ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure(), ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.FromStructureDelegate(config));
  } else {
AttrPoints = ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.FromStructure(s.ssSTPoints, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_f6c2f142af073709395973c555ac9ddc, RC_f6c2f142af073709395973c555ac9ddc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_f6c2f142af073709395973c555ac9ddc s) => ToStructure(s, config);
}
public static RC_f6c2f142af073709395973c555ac9ddc ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_f6c2f142af073709395973c555ac9ddc obj, IBehaviorsConfiguration config) { 
  RC_f6c2f142af073709395973c555ac9ddc s = new RC_f6c2f142af073709395973c555ac9ddc();
  if(obj != null) {
  s.ssSTPoints = ssOutSystemsMaps.RestRecords.JSONST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.ToStructure(obj.AttrPoints, config);
  }
  return s;
}

public static Func<RC_f6c2f142af073709395973c555ac9ddc, ssOutSystemsMaps.RestRecords.JSONRC_f6c2f142af073709395973c555ac9ddc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f6c2f142af073709395973c555ac9ddc s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_f6c2f142af073709395973c555ac9ddc FromStructure(RC_f6c2f142af073709395973c555ac9ddc s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_f6c2f142af073709395973c555ac9ddc(s, config);
}

}


