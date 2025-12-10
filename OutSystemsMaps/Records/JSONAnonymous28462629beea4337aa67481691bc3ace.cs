using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawingTools_ConfigsRecord
public class JSONRC_7d204fba4e0a277c99c007d6b7af7b72 : AbstractRESTStructure<RC_7d204fba4e0a277c99c007d6b7af7b72> {
[JsonProperty("Internal_DrawingTools_Configs")]
[JsonPropertyName("Internal_DrawingTools_Configs")]
public ssOutSystemsMaps.RestRecords.JSONST_61db11323cabca5a5fb3b6c7b9d63842Structure AttrInternal_DrawingTools_Configs;

public JSONRC_7d204fba4e0a277c99c007d6b7af7b72() { }

public JSONRC_7d204fba4e0a277c99c007d6b7af7b72 (RC_7d204fba4e0a277c99c007d6b7af7b72 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawingTools_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawingTools_Configs, new ST_61db11323cabca5a5fb3b6c7b9d63842Structure(), ssOutSystemsMaps.RestRecords.JSONST_61db11323cabca5a5fb3b6c7b9d63842Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawingTools_Configs = ssOutSystemsMaps.RestRecords.JSONST_61db11323cabca5a5fb3b6c7b9d63842Structure.FromStructure(s.ssSTInternal_DrawingTools_Configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_7d204fba4e0a277c99c007d6b7af7b72, RC_7d204fba4e0a277c99c007d6b7af7b72> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_7d204fba4e0a277c99c007d6b7af7b72 s) => ToStructure(s, config);
}
public static RC_7d204fba4e0a277c99c007d6b7af7b72 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_7d204fba4e0a277c99c007d6b7af7b72 obj, IBehaviorsConfiguration config) { 
  RC_7d204fba4e0a277c99c007d6b7af7b72 s = new RC_7d204fba4e0a277c99c007d6b7af7b72();
  if(obj != null) {
  s.ssSTInternal_DrawingTools_Configs = ssOutSystemsMaps.RestRecords.JSONST_61db11323cabca5a5fb3b6c7b9d63842Structure.ToStructure(obj.AttrInternal_DrawingTools_Configs, config);
  }
  return s;
}

public static Func<RC_7d204fba4e0a277c99c007d6b7af7b72, ssOutSystemsMaps.RestRecords.JSONRC_7d204fba4e0a277c99c007d6b7af7b72> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7d204fba4e0a277c99c007d6b7af7b72 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_7d204fba4e0a277c99c007d6b7af7b72 FromStructure(RC_7d204fba4e0a277c99c007d6b7af7b72 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_7d204fba4e0a277c99c007d6b7af7b72(s, config);
}

}


