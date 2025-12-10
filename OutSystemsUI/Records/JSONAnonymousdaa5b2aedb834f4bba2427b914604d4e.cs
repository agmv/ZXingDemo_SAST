using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TabsHeaderItem_InternalConfigRecord
public class JSONRC_81cffcb474124022b5e4e9bef9a608da : AbstractRESTStructure<RC_81cffcb474124022b5e4e9bef9a608da> {
[JsonProperty("TabsHeaderItem_InternalConfig")]
[JsonPropertyName("TabsHeaderItem_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_4f70c42b393d853a53e093e196f4b683Structure AttrTabsHeaderItem_InternalConfig;

public JSONRC_81cffcb474124022b5e4e9bef9a608da() { }

public JSONRC_81cffcb474124022b5e4e9bef9a608da (RC_81cffcb474124022b5e4e9bef9a608da s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTabsHeaderItem_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTTabsHeaderItem_InternalConfig, new ST_4f70c42b393d853a53e093e196f4b683Structure(), ssOutSystemsUI.RestRecords.JSONST_4f70c42b393d853a53e093e196f4b683Structure.FromStructureDelegate(config));
  } else {
AttrTabsHeaderItem_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_4f70c42b393d853a53e093e196f4b683Structure.FromStructure(s.ssSTTabsHeaderItem_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_81cffcb474124022b5e4e9bef9a608da, RC_81cffcb474124022b5e4e9bef9a608da> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_81cffcb474124022b5e4e9bef9a608da s) => ToStructure(s, config);
}
public static RC_81cffcb474124022b5e4e9bef9a608da ToStructure(ssOutSystemsUI.RestRecords.JSONRC_81cffcb474124022b5e4e9bef9a608da obj, IBehaviorsConfiguration config) { 
  RC_81cffcb474124022b5e4e9bef9a608da s = new RC_81cffcb474124022b5e4e9bef9a608da();
  if(obj != null) {
  s.ssSTTabsHeaderItem_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_4f70c42b393d853a53e093e196f4b683Structure.ToStructure(obj.AttrTabsHeaderItem_InternalConfig, config);
  }
  return s;
}

public static Func<RC_81cffcb474124022b5e4e9bef9a608da, ssOutSystemsUI.RestRecords.JSONRC_81cffcb474124022b5e4e9bef9a608da> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_81cffcb474124022b5e4e9bef9a608da s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_81cffcb474124022b5e4e9bef9a608da FromStructure(RC_81cffcb474124022b5e4e9bef9a608da s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_81cffcb474124022b5e4e9bef9a608da(s, config);
}

}


