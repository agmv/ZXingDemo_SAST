using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// GradientColor
public class JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure : AbstractRESTStructure<ST_27b48af5cc16a3b2165fd73e0270cad1Structure> {
[JsonProperty("Color")]
[JsonPropertyName("Color")]
public string AttrColor;

[JsonProperty("Percentage")]
[JsonPropertyName("Percentage")]
public decimal? AttrPercentage;

public JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure() { }

public JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure (ST_27b48af5cc16a3b2165fd73e0270cad1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = ConvertToRestWithoutDefaults(s.ssColor, "");
AttrPercentage = ConvertToRestWithoutDefaults(s.ssPercentage, (((decimal)(-1))));
  } else {
AttrColor = s.ssColor;
AttrPercentage = (decimal?) s.ssPercentage;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure, ST_27b48af5cc16a3b2165fd73e0270cad1Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure s) => ToStructure(s, config);
}
public static ST_27b48af5cc16a3b2165fd73e0270cad1Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure obj, IBehaviorsConfiguration config) { 
  ST_27b48af5cc16a3b2165fd73e0270cad1Structure s = new ST_27b48af5cc16a3b2165fd73e0270cad1Structure();
  if(obj != null) {
  s.ssColor = obj.AttrColor == null ? "" : obj.AttrColor;
  s.ssPercentage = obj.AttrPercentage == null ? (((decimal)(-1))) : obj.AttrPercentage.Value;
  }
  return s;
}

public static Func<ST_27b48af5cc16a3b2165fd73e0270cad1Structure, ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_27b48af5cc16a3b2165fd73e0270cad1Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure FromStructure(ST_27b48af5cc16a3b2165fd73e0270cad1Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_27b48af5cc16a3b2165fd73e0270cad1Structure(s, config);
}

}


