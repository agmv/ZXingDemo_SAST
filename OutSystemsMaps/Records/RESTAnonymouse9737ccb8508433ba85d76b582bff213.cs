using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// PointsRecord
public class RESTRC_f6c2f142af073709395973c555ac9ddc : AbstractRESTStructure<RC_f6c2f142af073709395973c555ac9ddc> {
[JsonProperty("Points")]
public ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure AttrPoints;

public RESTRC_f6c2f142af073709395973c555ac9ddc() { }

public RESTRC_f6c2f142af073709395973c555ac9ddc (RC_f6c2f142af073709395973c555ac9ddc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPoints = ConvertToRestWithoutDefaults(s.ssSTPoints, new ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure(), ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.FromStructureDelegate(config));
  } else {
AttrPoints = ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.FromStructure(s.ssSTPoints, config);
  }
}

public static RC_f6c2f142af073709395973c555ac9ddc ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_f6c2f142af073709395973c555ac9ddc obj) { 
  RC_f6c2f142af073709395973c555ac9ddc s = new RC_f6c2f142af073709395973c555ac9ddc();
  if(obj != null) {
  s.ssSTPoints = ssOutSystemsMaps.RestRecords.RESTST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.ToStructure(obj.AttrPoints);
  }
  return s;
}

public static Func<RC_f6c2f142af073709395973c555ac9ddc, ssOutSystemsMaps.RestRecords.RESTRC_f6c2f142af073709395973c555ac9ddc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f6c2f142af073709395973c555ac9ddc s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_f6c2f142af073709395973c555ac9ddc FromStructure(RC_f6c2f142af073709395973c555ac9ddc s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_f6c2f142af073709395973c555ac9ddc(s, config);
}

}


