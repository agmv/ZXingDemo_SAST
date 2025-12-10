using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Search_InternalConfigRecord
public class RESTRC_3dc2f7b3c292c64f7476a99f4086df98 : AbstractRESTStructure<RC_3dc2f7b3c292c64f7476a99f4086df98> {
[JsonProperty("Search_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure AttrSearch_InternalConfig;

public RESTRC_3dc2f7b3c292c64f7476a99f4086df98() { }

public RESTRC_3dc2f7b3c292c64f7476a99f4086df98 (RC_3dc2f7b3c292c64f7476a99f4086df98 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSearch_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTSearch_InternalConfig, new ST_8ccec918bf91fdb79e42a7e1e178b4beStructure(), ssOutSystemsUI.RestRecords.RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure.FromStructureDelegate(config));
  } else {
AttrSearch_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure.FromStructure(s.ssSTSearch_InternalConfig, config);
  }
}

public static RC_3dc2f7b3c292c64f7476a99f4086df98 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_3dc2f7b3c292c64f7476a99f4086df98 obj) { 
  RC_3dc2f7b3c292c64f7476a99f4086df98 s = new RC_3dc2f7b3c292c64f7476a99f4086df98();
  if(obj != null) {
  s.ssSTSearch_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure.ToStructure(obj.AttrSearch_InternalConfig);
  }
  return s;
}

public static Func<RC_3dc2f7b3c292c64f7476a99f4086df98, ssOutSystemsUI.RestRecords.RESTRC_3dc2f7b3c292c64f7476a99f4086df98> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3dc2f7b3c292c64f7476a99f4086df98 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_3dc2f7b3c292c64f7476a99f4086df98 FromStructure(RC_3dc2f7b3c292c64f7476a99f4086df98 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_3dc2f7b3c292c64f7476a99f4086df98(s, config);
}

}


