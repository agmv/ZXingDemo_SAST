using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// TabsOptionalConfigsRecord
public class JSONRC_b7283e2c6e9c6bcb5286d1ae04959554 : AbstractRESTStructure<RC_b7283e2c6e9c6bcb5286d1ae04959554> {
[JsonProperty("TabsOptionalConfigs")]
[JsonPropertyName("TabsOptionalConfigs")]
public ssZXingLibDemo.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure AttrTabsOptionalConfigs;

public JSONRC_b7283e2c6e9c6bcb5286d1ae04959554() { }

public JSONRC_b7283e2c6e9c6bcb5286d1ae04959554 (RC_b7283e2c6e9c6bcb5286d1ae04959554 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTabsOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTTabsOptionalConfigs, new ST_e3f9af4171d5e4a41700770295d05c77Structure(), ssZXingLibDemo.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure.FromStructureDelegate(config));
  } else {
AttrTabsOptionalConfigs = ssZXingLibDemo.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure.FromStructure(s.ssSTTabsOptionalConfigs, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_b7283e2c6e9c6bcb5286d1ae04959554, RC_b7283e2c6e9c6bcb5286d1ae04959554> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_b7283e2c6e9c6bcb5286d1ae04959554 s) => ToStructure(s, config);
}
public static RC_b7283e2c6e9c6bcb5286d1ae04959554 ToStructure(ssZXingLibDemo.RestRecords.JSONRC_b7283e2c6e9c6bcb5286d1ae04959554 obj, IBehaviorsConfiguration config) { 
  RC_b7283e2c6e9c6bcb5286d1ae04959554 s = new RC_b7283e2c6e9c6bcb5286d1ae04959554();
  if(obj != null) {
  s.ssSTTabsOptionalConfigs = ssZXingLibDemo.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure.ToStructure(obj.AttrTabsOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_b7283e2c6e9c6bcb5286d1ae04959554, ssZXingLibDemo.RestRecords.JSONRC_b7283e2c6e9c6bcb5286d1ae04959554> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b7283e2c6e9c6bcb5286d1ae04959554 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_b7283e2c6e9c6bcb5286d1ae04959554 FromStructure(RC_b7283e2c6e9c6bcb5286d1ae04959554 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_b7283e2c6e9c6bcb5286d1ae04959554(s, config);
}

}


