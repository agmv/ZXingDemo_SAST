using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// GradientColorRecord
public class RESTRC_486a35159c95750661e012cbe99a555f : AbstractRESTStructure<RC_486a35159c95750661e012cbe99a555f> {
[JsonProperty("GradientColor")]
public ssOutSystemsUI.RestRecords.RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure AttrGradientColor;

public RESTRC_486a35159c95750661e012cbe99a555f() { }

public RESTRC_486a35159c95750661e012cbe99a555f (RC_486a35159c95750661e012cbe99a555f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGradientColor = ConvertToRestWithoutDefaults(s.ssSTGradientColor, new ST_27b48af5cc16a3b2165fd73e0270cad1Structure(), ssOutSystemsUI.RestRecords.RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure.FromStructureDelegate(config));
  } else {
AttrGradientColor = ssOutSystemsUI.RestRecords.RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure.FromStructure(s.ssSTGradientColor, config);
  }
}

public static RC_486a35159c95750661e012cbe99a555f ToStructure(ssOutSystemsUI.RestRecords.RESTRC_486a35159c95750661e012cbe99a555f obj) { 
  RC_486a35159c95750661e012cbe99a555f s = new RC_486a35159c95750661e012cbe99a555f();
  if(obj != null) {
  s.ssSTGradientColor = ssOutSystemsUI.RestRecords.RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure.ToStructure(obj.AttrGradientColor);
  }
  return s;
}

public static Func<RC_486a35159c95750661e012cbe99a555f, ssOutSystemsUI.RestRecords.RESTRC_486a35159c95750661e012cbe99a555f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_486a35159c95750661e012cbe99a555f s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_486a35159c95750661e012cbe99a555f FromStructure(RC_486a35159c95750661e012cbe99a555f s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_486a35159c95750661e012cbe99a555f(s, config);
}

}


