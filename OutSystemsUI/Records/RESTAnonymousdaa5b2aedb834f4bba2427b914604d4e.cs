using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TabsHeaderItem_InternalConfigRecord
public class RESTRC_81cffcb474124022b5e4e9bef9a608da : AbstractRESTStructure<RC_81cffcb474124022b5e4e9bef9a608da> {
[JsonProperty("TabsHeaderItem_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_4f70c42b393d853a53e093e196f4b683Structure AttrTabsHeaderItem_InternalConfig;

public RESTRC_81cffcb474124022b5e4e9bef9a608da() { }

public RESTRC_81cffcb474124022b5e4e9bef9a608da (RC_81cffcb474124022b5e4e9bef9a608da s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTabsHeaderItem_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTTabsHeaderItem_InternalConfig, new ST_4f70c42b393d853a53e093e196f4b683Structure(), ssOutSystemsUI.RestRecords.RESTST_4f70c42b393d853a53e093e196f4b683Structure.FromStructureDelegate(config));
  } else {
AttrTabsHeaderItem_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_4f70c42b393d853a53e093e196f4b683Structure.FromStructure(s.ssSTTabsHeaderItem_InternalConfig, config);
  }
}

public static RC_81cffcb474124022b5e4e9bef9a608da ToStructure(ssOutSystemsUI.RestRecords.RESTRC_81cffcb474124022b5e4e9bef9a608da obj) { 
  RC_81cffcb474124022b5e4e9bef9a608da s = new RC_81cffcb474124022b5e4e9bef9a608da();
  if(obj != null) {
  s.ssSTTabsHeaderItem_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_4f70c42b393d853a53e093e196f4b683Structure.ToStructure(obj.AttrTabsHeaderItem_InternalConfig);
  }
  return s;
}

public static Func<RC_81cffcb474124022b5e4e9bef9a608da, ssOutSystemsUI.RestRecords.RESTRC_81cffcb474124022b5e4e9bef9a608da> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_81cffcb474124022b5e4e9bef9a608da s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_81cffcb474124022b5e4e9bef9a608da FromStructure(RC_81cffcb474124022b5e4e9bef9a608da s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_81cffcb474124022b5e4e9bef9a608da(s, config);
}

}


