using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Tabs_InternalConfigRecord
public class JSONRC_3e7155b32546681d96eaaf8aa39a4f6e : AbstractRESTStructure<RC_3e7155b32546681d96eaaf8aa39a4f6e> {
[JsonProperty("Tabs_InternalConfig")]
[JsonPropertyName("Tabs_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_235f8a24bba710c13f14db6b69a566bbStructure AttrTabs_InternalConfig;

public JSONRC_3e7155b32546681d96eaaf8aa39a4f6e() { }

public JSONRC_3e7155b32546681d96eaaf8aa39a4f6e (RC_3e7155b32546681d96eaaf8aa39a4f6e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTabs_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTTabs_InternalConfig, new ST_235f8a24bba710c13f14db6b69a566bbStructure(), ssOutSystemsUI.RestRecords.JSONST_235f8a24bba710c13f14db6b69a566bbStructure.FromStructureDelegate(config));
  } else {
AttrTabs_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_235f8a24bba710c13f14db6b69a566bbStructure.FromStructure(s.ssSTTabs_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_3e7155b32546681d96eaaf8aa39a4f6e, RC_3e7155b32546681d96eaaf8aa39a4f6e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_3e7155b32546681d96eaaf8aa39a4f6e s) => ToStructure(s, config);
}
public static RC_3e7155b32546681d96eaaf8aa39a4f6e ToStructure(ssOutSystemsUI.RestRecords.JSONRC_3e7155b32546681d96eaaf8aa39a4f6e obj, IBehaviorsConfiguration config) { 
  RC_3e7155b32546681d96eaaf8aa39a4f6e s = new RC_3e7155b32546681d96eaaf8aa39a4f6e();
  if(obj != null) {
  s.ssSTTabs_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_235f8a24bba710c13f14db6b69a566bbStructure.ToStructure(obj.AttrTabs_InternalConfig, config);
  }
  return s;
}

public static Func<RC_3e7155b32546681d96eaaf8aa39a4f6e, ssOutSystemsUI.RestRecords.JSONRC_3e7155b32546681d96eaaf8aa39a4f6e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3e7155b32546681d96eaaf8aa39a4f6e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_3e7155b32546681d96eaaf8aa39a4f6e FromStructure(RC_3e7155b32546681d96eaaf8aa39a4f6e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_3e7155b32546681d96eaaf8aa39a4f6e(s, config);
}

}


