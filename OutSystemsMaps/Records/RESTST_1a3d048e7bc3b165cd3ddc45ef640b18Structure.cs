using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_FileLayer_Configs
public class RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure : AbstractRESTStructure<ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure> {
[JsonProperty("Internal_to_provider_fileLayer_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_793e574f3ddb64f39831eacf8a4462b0Structure AttrInternal_to_provider_fileLayer_configs;

[JsonProperty("UniqueId")]
public string AttrUniqueId;

public RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure() { }

public RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure (ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_fileLayer_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_fileLayer_configs, new ST_793e574f3ddb64f39831eacf8a4462b0Structure(), ssOutSystemsMaps.RestRecords.RESTST_793e574f3ddb64f39831eacf8a4462b0Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_fileLayer_configs = ssOutSystemsMaps.RestRecords.RESTST_793e574f3ddb64f39831eacf8a4462b0Structure.FromStructure(s.ssInternal_to_provider_fileLayer_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure obj) { 
  ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure s = new ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure();
  if(obj != null) {
  s.ssInternal_to_provider_fileLayer_configs = ssOutSystemsMaps.RestRecords.RESTST_793e574f3ddb64f39831eacf8a4462b0Structure.ToStructure(obj.AttrInternal_to_provider_fileLayer_configs);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure, ssOutSystemsMaps.RestRecords.RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure FromStructure(ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure(s, config);
}

}


