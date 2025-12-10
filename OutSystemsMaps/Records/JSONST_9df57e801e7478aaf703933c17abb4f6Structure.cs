using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawRectangle_Configs
public class JSONST_9df57e801e7478aaf703933c17abb4f6Structure : AbstractRESTStructure<ST_9df57e801e7478aaf703933c17abb4f6Structure> {
[JsonProperty("Internal_to_provider_tools_configs")]
[JsonPropertyName("Internal_to_provider_tools_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_d25262c67f1be04c1df274811b8c7ee4Structure AttrInternal_to_provider_tools_configs;

[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

public JSONST_9df57e801e7478aaf703933c17abb4f6Structure() { }

public JSONST_9df57e801e7478aaf703933c17abb4f6Structure (ST_9df57e801e7478aaf703933c17abb4f6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_tools_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_tools_configs, new ST_d25262c67f1be04c1df274811b8c7ee4Structure(), ssOutSystemsMaps.RestRecords.JSONST_d25262c67f1be04c1df274811b8c7ee4Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.JSONST_d25262c67f1be04c1df274811b8c7ee4Structure.FromStructure(s.ssInternal_to_provider_tools_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_9df57e801e7478aaf703933c17abb4f6Structure, ST_9df57e801e7478aaf703933c17abb4f6Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_9df57e801e7478aaf703933c17abb4f6Structure s) => ToStructure(s, config);
}
public static ST_9df57e801e7478aaf703933c17abb4f6Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_9df57e801e7478aaf703933c17abb4f6Structure obj, IBehaviorsConfiguration config) { 
  ST_9df57e801e7478aaf703933c17abb4f6Structure s = new ST_9df57e801e7478aaf703933c17abb4f6Structure();
  if(obj != null) {
  s.ssInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.JSONST_d25262c67f1be04c1df274811b8c7ee4Structure.ToStructure(obj.AttrInternal_to_provider_tools_configs, config);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_9df57e801e7478aaf703933c17abb4f6Structure, ssOutSystemsMaps.RestRecords.JSONST_9df57e801e7478aaf703933c17abb4f6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9df57e801e7478aaf703933c17abb4f6Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_9df57e801e7478aaf703933c17abb4f6Structure FromStructure(ST_9df57e801e7478aaf703933c17abb4f6Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_9df57e801e7478aaf703933c17abb4f6Structure(s, config);
}

}


