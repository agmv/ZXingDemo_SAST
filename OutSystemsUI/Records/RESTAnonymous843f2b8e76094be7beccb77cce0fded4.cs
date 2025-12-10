using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// NoUiSliderConfigs_RangeRecord
public class RESTRC_3fbb4babd0ba48852fecc04be37d3c0e : AbstractRESTStructure<RC_3fbb4babd0ba48852fecc04be37d3c0e> {
[JsonProperty("NoUiSliderConfigs_Range")]
public ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure AttrNoUiSliderConfigs_Range;

public RESTRC_3fbb4babd0ba48852fecc04be37d3c0e() { }

public RESTRC_3fbb4babd0ba48852fecc04be37d3c0e (RC_3fbb4babd0ba48852fecc04be37d3c0e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNoUiSliderConfigs_Range = ConvertToRestWithoutDefaults(s.ssSTNoUiSliderConfigs_Range, new ST_841c1f1485f51831db9f4b37a6d551d5Structure(), ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure.FromStructureDelegate(config));
  } else {
AttrNoUiSliderConfigs_Range = ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure.FromStructure(s.ssSTNoUiSliderConfigs_Range, config);
  }
}

public static RC_3fbb4babd0ba48852fecc04be37d3c0e ToStructure(ssOutSystemsUI.RestRecords.RESTRC_3fbb4babd0ba48852fecc04be37d3c0e obj) { 
  RC_3fbb4babd0ba48852fecc04be37d3c0e s = new RC_3fbb4babd0ba48852fecc04be37d3c0e();
  if(obj != null) {
  s.ssSTNoUiSliderConfigs_Range = ssOutSystemsUI.RestRecords.RESTST_841c1f1485f51831db9f4b37a6d551d5Structure.ToStructure(obj.AttrNoUiSliderConfigs_Range);
  }
  return s;
}

public static Func<RC_3fbb4babd0ba48852fecc04be37d3c0e, ssOutSystemsUI.RestRecords.RESTRC_3fbb4babd0ba48852fecc04be37d3c0e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3fbb4babd0ba48852fecc04be37d3c0e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_3fbb4babd0ba48852fecc04be37d3c0e FromStructure(RC_3fbb4babd0ba48852fecc04be37d3c0e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_3fbb4babd0ba48852fecc04be37d3c0e(s, config);
}

}


