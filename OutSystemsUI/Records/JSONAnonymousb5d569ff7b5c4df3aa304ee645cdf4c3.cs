using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// GradientColorRecord
public class JSONRC_486a35159c95750661e012cbe99a555f : AbstractRESTStructure<RC_486a35159c95750661e012cbe99a555f> {
[JsonProperty("GradientColor")]
[JsonPropertyName("GradientColor")]
public ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure AttrGradientColor;

public JSONRC_486a35159c95750661e012cbe99a555f() { }

public JSONRC_486a35159c95750661e012cbe99a555f (RC_486a35159c95750661e012cbe99a555f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGradientColor = ConvertToRestWithoutDefaults(s.ssSTGradientColor, new ST_27b48af5cc16a3b2165fd73e0270cad1Structure(), ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure.FromStructureDelegate(config));
  } else {
AttrGradientColor = ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure.FromStructure(s.ssSTGradientColor, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_486a35159c95750661e012cbe99a555f, RC_486a35159c95750661e012cbe99a555f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_486a35159c95750661e012cbe99a555f s) => ToStructure(s, config);
}
public static RC_486a35159c95750661e012cbe99a555f ToStructure(ssOutSystemsUI.RestRecords.JSONRC_486a35159c95750661e012cbe99a555f obj, IBehaviorsConfiguration config) { 
  RC_486a35159c95750661e012cbe99a555f s = new RC_486a35159c95750661e012cbe99a555f();
  if(obj != null) {
  s.ssSTGradientColor = ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure.ToStructure(obj.AttrGradientColor, config);
  }
  return s;
}

public static Func<RC_486a35159c95750661e012cbe99a555f, ssOutSystemsUI.RestRecords.JSONRC_486a35159c95750661e012cbe99a555f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_486a35159c95750661e012cbe99a555f s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_486a35159c95750661e012cbe99a555f FromStructure(RC_486a35159c95750661e012cbe99a555f s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_486a35159c95750661e012cbe99a555f(s, config);
}

}


