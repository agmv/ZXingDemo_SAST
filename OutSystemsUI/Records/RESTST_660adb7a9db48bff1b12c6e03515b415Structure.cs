using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselItems
public class RESTST_660adb7a9db48bff1b12c6e03515b415Structure : AbstractRESTStructure<ST_660adb7a9db48bff1b12c6e03515b415Structure> {
[JsonProperty("Desktop")]
public int? AttrDesktop;

[JsonProperty("Tablet")]
public int? AttrTablet;

[JsonProperty("Phone")]
public int? AttrPhone;

public RESTST_660adb7a9db48bff1b12c6e03515b415Structure() { }

public RESTST_660adb7a9db48bff1b12c6e03515b415Structure (ST_660adb7a9db48bff1b12c6e03515b415Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDesktop = ConvertToRestWithoutDefaults(s.ssDesktop, 1);
AttrTablet = ConvertToRestWithoutDefaults(s.ssTablet, 1);
AttrPhone = ConvertToRestWithoutDefaults(s.ssPhone, 1);
  } else {
AttrDesktop = (int?) s.ssDesktop;
AttrTablet = (int?) s.ssTablet;
AttrPhone = (int?) s.ssPhone;
  }
}

public static ST_660adb7a9db48bff1b12c6e03515b415Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_660adb7a9db48bff1b12c6e03515b415Structure obj) { 
  ST_660adb7a9db48bff1b12c6e03515b415Structure s = new ST_660adb7a9db48bff1b12c6e03515b415Structure();
  if(obj != null) {
  s.ssDesktop = obj.AttrDesktop == null ? 1 : obj.AttrDesktop.Value;
  s.ssTablet = obj.AttrTablet == null ? 1 : obj.AttrTablet.Value;
  s.ssPhone = obj.AttrPhone == null ? 1 : obj.AttrPhone.Value;
  }
  return s;
}

public static Func<ST_660adb7a9db48bff1b12c6e03515b415Structure, ssOutSystemsUI.RestRecords.RESTST_660adb7a9db48bff1b12c6e03515b415Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_660adb7a9db48bff1b12c6e03515b415Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_660adb7a9db48bff1b12c6e03515b415Structure FromStructure(ST_660adb7a9db48bff1b12c6e03515b415Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_660adb7a9db48bff1b12c6e03515b415Structure(s, config);
}

}


