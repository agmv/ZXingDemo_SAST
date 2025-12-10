using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TabsContentItem_InternalConfigRecord
public class RESTRC_b5f68720e8ed79c9aa70970bcdd12b24 : AbstractRESTStructure<RC_b5f68720e8ed79c9aa70970bcdd12b24> {
[JsonProperty("TabsContentItem_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure AttrTabsContentItem_InternalConfig;

public RESTRC_b5f68720e8ed79c9aa70970bcdd12b24() { }

public RESTRC_b5f68720e8ed79c9aa70970bcdd12b24 (RC_b5f68720e8ed79c9aa70970bcdd12b24 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTabsContentItem_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTTabsContentItem_InternalConfig, new ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure(), ssOutSystemsUI.RestRecords.RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure.FromStructureDelegate(config));
  } else {
AttrTabsContentItem_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure.FromStructure(s.ssSTTabsContentItem_InternalConfig, config);
  }
}

public static RC_b5f68720e8ed79c9aa70970bcdd12b24 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_b5f68720e8ed79c9aa70970bcdd12b24 obj) { 
  RC_b5f68720e8ed79c9aa70970bcdd12b24 s = new RC_b5f68720e8ed79c9aa70970bcdd12b24();
  if(obj != null) {
  s.ssSTTabsContentItem_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure.ToStructure(obj.AttrTabsContentItem_InternalConfig);
  }
  return s;
}

public static Func<RC_b5f68720e8ed79c9aa70970bcdd12b24, ssOutSystemsUI.RestRecords.RESTRC_b5f68720e8ed79c9aa70970bcdd12b24> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b5f68720e8ed79c9aa70970bcdd12b24 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_b5f68720e8ed79c9aa70970bcdd12b24 FromStructure(RC_b5f68720e8ed79c9aa70970bcdd12b24 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_b5f68720e8ed79c9aa70970bcdd12b24(s, config);
}

}


