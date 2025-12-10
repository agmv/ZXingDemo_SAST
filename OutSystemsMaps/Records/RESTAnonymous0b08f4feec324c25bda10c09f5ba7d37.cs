using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// BoundsRecord
public class RESTRC_fdf568550fb18a6ec270df7466fa0d20 : AbstractRESTStructure<RC_fdf568550fb18a6ec270df7466fa0d20> {
[JsonProperty("Bounds")]
public ssOutSystemsMaps.RestRecords.RESTST_5fb6f64676b0133fcb572480a766fc9cStructure AttrBounds;

public RESTRC_fdf568550fb18a6ec270df7466fa0d20() { }

public RESTRC_fdf568550fb18a6ec270df7466fa0d20 (RC_fdf568550fb18a6ec270df7466fa0d20 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBounds = ConvertToRestWithoutDefaults(s.ssSTBounds, new ST_5fb6f64676b0133fcb572480a766fc9cStructure(), ssOutSystemsMaps.RestRecords.RESTST_5fb6f64676b0133fcb572480a766fc9cStructure.FromStructureDelegate(config));
  } else {
AttrBounds = ssOutSystemsMaps.RestRecords.RESTST_5fb6f64676b0133fcb572480a766fc9cStructure.FromStructure(s.ssSTBounds, config);
  }
}

public static RC_fdf568550fb18a6ec270df7466fa0d20 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_fdf568550fb18a6ec270df7466fa0d20 obj) { 
  RC_fdf568550fb18a6ec270df7466fa0d20 s = new RC_fdf568550fb18a6ec270df7466fa0d20();
  if(obj != null) {
  s.ssSTBounds = ssOutSystemsMaps.RestRecords.RESTST_5fb6f64676b0133fcb572480a766fc9cStructure.ToStructure(obj.AttrBounds);
  }
  return s;
}

public static Func<RC_fdf568550fb18a6ec270df7466fa0d20, ssOutSystemsMaps.RestRecords.RESTRC_fdf568550fb18a6ec270df7466fa0d20> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fdf568550fb18a6ec270df7466fa0d20 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_fdf568550fb18a6ec270df7466fa0d20 FromStructure(RC_fdf568550fb18a6ec270df7466fa0d20 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_fdf568550fb18a6ec270df7466fa0d20(s, config);
}

}


