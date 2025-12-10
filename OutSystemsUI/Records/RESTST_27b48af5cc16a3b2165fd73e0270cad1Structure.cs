using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// GradientColor
public class RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure : AbstractRESTStructure<ST_27b48af5cc16a3b2165fd73e0270cad1Structure> {
[JsonProperty("Color")]
public string AttrColor;

[JsonProperty("Percentage")]
public decimal? AttrPercentage;

public RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure() { }

public RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure (ST_27b48af5cc16a3b2165fd73e0270cad1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = ConvertToRestWithoutDefaults(s.ssColor, "");
AttrPercentage = ConvertToRestWithoutDefaults(s.ssPercentage, (((decimal)(-1))));
  } else {
AttrColor = s.ssColor;
AttrPercentage = (decimal?) s.ssPercentage;
  }
}

public static ST_27b48af5cc16a3b2165fd73e0270cad1Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure obj) { 
  ST_27b48af5cc16a3b2165fd73e0270cad1Structure s = new ST_27b48af5cc16a3b2165fd73e0270cad1Structure();
  if(obj != null) {
  s.ssColor = obj.AttrColor == null ? "" : obj.AttrColor;
  s.ssPercentage = obj.AttrPercentage == null ? (((decimal)(-1))) : obj.AttrPercentage.Value;
  }
  return s;
}

public static Func<ST_27b48af5cc16a3b2165fd73e0270cad1Structure, ssOutSystemsUI.RestRecords.RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_27b48af5cc16a3b2165fd73e0270cad1Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure FromStructure(ST_27b48af5cc16a3b2165fd73e0270cad1Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_27b48af5cc16a3b2165fd73e0270cad1Structure(s, config);
}

}


