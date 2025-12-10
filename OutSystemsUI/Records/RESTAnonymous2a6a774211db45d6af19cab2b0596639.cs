using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Tabs_InternalConfigRecord
public class RESTRC_3e7155b32546681d96eaaf8aa39a4f6e : AbstractRESTStructure<RC_3e7155b32546681d96eaaf8aa39a4f6e> {
[JsonProperty("Tabs_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_235f8a24bba710c13f14db6b69a566bbStructure AttrTabs_InternalConfig;

public RESTRC_3e7155b32546681d96eaaf8aa39a4f6e() { }

public RESTRC_3e7155b32546681d96eaaf8aa39a4f6e (RC_3e7155b32546681d96eaaf8aa39a4f6e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTabs_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTTabs_InternalConfig, new ST_235f8a24bba710c13f14db6b69a566bbStructure(), ssOutSystemsUI.RestRecords.RESTST_235f8a24bba710c13f14db6b69a566bbStructure.FromStructureDelegate(config));
  } else {
AttrTabs_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_235f8a24bba710c13f14db6b69a566bbStructure.FromStructure(s.ssSTTabs_InternalConfig, config);
  }
}

public static RC_3e7155b32546681d96eaaf8aa39a4f6e ToStructure(ssOutSystemsUI.RestRecords.RESTRC_3e7155b32546681d96eaaf8aa39a4f6e obj) { 
  RC_3e7155b32546681d96eaaf8aa39a4f6e s = new RC_3e7155b32546681d96eaaf8aa39a4f6e();
  if(obj != null) {
  s.ssSTTabs_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_235f8a24bba710c13f14db6b69a566bbStructure.ToStructure(obj.AttrTabs_InternalConfig);
  }
  return s;
}

public static Func<RC_3e7155b32546681d96eaaf8aa39a4f6e, ssOutSystemsUI.RestRecords.RESTRC_3e7155b32546681d96eaaf8aa39a4f6e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3e7155b32546681d96eaaf8aa39a4f6e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_3e7155b32546681d96eaaf8aa39a4f6e FromStructure(RC_3e7155b32546681d96eaaf8aa39a4f6e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_3e7155b32546681d96eaaf8aa39a4f6e(s, config);
}

}


