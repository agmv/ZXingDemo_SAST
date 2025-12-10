using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselItemsRecord
public class RESTRC_dac62773434cf92b52368fd089bbfc2a : AbstractRESTStructure<RC_dac62773434cf92b52368fd089bbfc2a> {
[JsonProperty("CarouselItems")]
public ssOutSystemsUI.RestRecords.RESTST_660adb7a9db48bff1b12c6e03515b415Structure AttrCarouselItems;

public RESTRC_dac62773434cf92b52368fd089bbfc2a() { }

public RESTRC_dac62773434cf92b52368fd089bbfc2a (RC_dac62773434cf92b52368fd089bbfc2a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCarouselItems = ConvertToRestWithoutDefaults(s.ssSTCarouselItems, new ST_660adb7a9db48bff1b12c6e03515b415Structure(), ssOutSystemsUI.RestRecords.RESTST_660adb7a9db48bff1b12c6e03515b415Structure.FromStructureDelegate(config));
  } else {
AttrCarouselItems = ssOutSystemsUI.RestRecords.RESTST_660adb7a9db48bff1b12c6e03515b415Structure.FromStructure(s.ssSTCarouselItems, config);
  }
}

public static RC_dac62773434cf92b52368fd089bbfc2a ToStructure(ssOutSystemsUI.RestRecords.RESTRC_dac62773434cf92b52368fd089bbfc2a obj) { 
  RC_dac62773434cf92b52368fd089bbfc2a s = new RC_dac62773434cf92b52368fd089bbfc2a();
  if(obj != null) {
  s.ssSTCarouselItems = ssOutSystemsUI.RestRecords.RESTST_660adb7a9db48bff1b12c6e03515b415Structure.ToStructure(obj.AttrCarouselItems);
  }
  return s;
}

public static Func<RC_dac62773434cf92b52368fd089bbfc2a, ssOutSystemsUI.RestRecords.RESTRC_dac62773434cf92b52368fd089bbfc2a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dac62773434cf92b52368fd089bbfc2a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_dac62773434cf92b52368fd089bbfc2a FromStructure(RC_dac62773434cf92b52368fd089bbfc2a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_dac62773434cf92b52368fd089bbfc2a(s, config);
}

}


