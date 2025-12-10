using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownServerSideItem_InternalConfigsRecord
public class JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43 : AbstractRESTStructure<RC_30bb0fd6be769d5d6630c4c9fbd19c43> {
[JsonProperty("DropdownServerSideItem_InternalConfigs")]
[JsonPropertyName("DropdownServerSideItem_InternalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_6af81a2c1989c9b6ed62295dfa4c4e65Structure AttrDropdownServerSideItem_InternalConfigs;

public JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43() { }

public JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43 (RC_30bb0fd6be769d5d6630c4c9fbd19c43 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownServerSideItem_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownServerSideItem_InternalConfigs, new ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure(), ssOutSystemsUI.RestRecords.JSONST_6af81a2c1989c9b6ed62295dfa4c4e65Structure.FromStructureDelegate(config));
  } else {
AttrDropdownServerSideItem_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_6af81a2c1989c9b6ed62295dfa4c4e65Structure.FromStructure(s.ssSTDropdownServerSideItem_InternalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43, RC_30bb0fd6be769d5d6630c4c9fbd19c43> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43 s) => ToStructure(s, config);
}
public static RC_30bb0fd6be769d5d6630c4c9fbd19c43 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43 obj, IBehaviorsConfiguration config) { 
  RC_30bb0fd6be769d5d6630c4c9fbd19c43 s = new RC_30bb0fd6be769d5d6630c4c9fbd19c43();
  if(obj != null) {
  s.ssSTDropdownServerSideItem_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_6af81a2c1989c9b6ed62295dfa4c4e65Structure.ToStructure(obj.AttrDropdownServerSideItem_InternalConfigs, config);
  }
  return s;
}

public static Func<RC_30bb0fd6be769d5d6630c4c9fbd19c43, ssOutSystemsUI.RestRecords.JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_30bb0fd6be769d5d6630c4c9fbd19c43 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43 FromStructure(RC_30bb0fd6be769d5d6630c4c9fbd19c43 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_30bb0fd6be769d5d6630c4c9fbd19c43(s, config);
}

}


