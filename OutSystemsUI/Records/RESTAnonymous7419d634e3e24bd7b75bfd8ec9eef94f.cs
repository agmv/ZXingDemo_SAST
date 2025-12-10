using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownServerSideItem_InternalConfigsRecord
public class RESTRC_30bb0fd6be769d5d6630c4c9fbd19c43 : AbstractRESTStructure<RC_30bb0fd6be769d5d6630c4c9fbd19c43> {
[JsonProperty("DropdownServerSideItem_InternalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure AttrDropdownServerSideItem_InternalConfigs;

public RESTRC_30bb0fd6be769d5d6630c4c9fbd19c43() { }

public RESTRC_30bb0fd6be769d5d6630c4c9fbd19c43 (RC_30bb0fd6be769d5d6630c4c9fbd19c43 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownServerSideItem_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownServerSideItem_InternalConfigs, new ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure(), ssOutSystemsUI.RestRecords.RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure.FromStructureDelegate(config));
  } else {
AttrDropdownServerSideItem_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure.FromStructure(s.ssSTDropdownServerSideItem_InternalConfigs, config);
  }
}

public static RC_30bb0fd6be769d5d6630c4c9fbd19c43 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_30bb0fd6be769d5d6630c4c9fbd19c43 obj) { 
  RC_30bb0fd6be769d5d6630c4c9fbd19c43 s = new RC_30bb0fd6be769d5d6630c4c9fbd19c43();
  if(obj != null) {
  s.ssSTDropdownServerSideItem_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure.ToStructure(obj.AttrDropdownServerSideItem_InternalConfigs);
  }
  return s;
}

public static Func<RC_30bb0fd6be769d5d6630c4c9fbd19c43, ssOutSystemsUI.RestRecords.RESTRC_30bb0fd6be769d5d6630c4c9fbd19c43> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_30bb0fd6be769d5d6630c4c9fbd19c43 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_30bb0fd6be769d5d6630c4c9fbd19c43 FromStructure(RC_30bb0fd6be769d5d6630c4c9fbd19c43 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_30bb0fd6be769d5d6630c4c9fbd19c43(s, config);
}

}


