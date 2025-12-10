using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawingTools_ConfigsRecord
public class RESTRC_7d204fba4e0a277c99c007d6b7af7b72 : AbstractRESTStructure<RC_7d204fba4e0a277c99c007d6b7af7b72> {
[JsonProperty("Internal_DrawingTools_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure AttrInternal_DrawingTools_Configs;

public RESTRC_7d204fba4e0a277c99c007d6b7af7b72() { }

public RESTRC_7d204fba4e0a277c99c007d6b7af7b72 (RC_7d204fba4e0a277c99c007d6b7af7b72 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawingTools_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawingTools_Configs, new ST_61db11323cabca5a5fb3b6c7b9d63842Structure(), ssOutSystemsMaps.RestRecords.RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawingTools_Configs = ssOutSystemsMaps.RestRecords.RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure.FromStructure(s.ssSTInternal_DrawingTools_Configs, config);
  }
}

public static RC_7d204fba4e0a277c99c007d6b7af7b72 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_7d204fba4e0a277c99c007d6b7af7b72 obj) { 
  RC_7d204fba4e0a277c99c007d6b7af7b72 s = new RC_7d204fba4e0a277c99c007d6b7af7b72();
  if(obj != null) {
  s.ssSTInternal_DrawingTools_Configs = ssOutSystemsMaps.RestRecords.RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure.ToStructure(obj.AttrInternal_DrawingTools_Configs);
  }
  return s;
}

public static Func<RC_7d204fba4e0a277c99c007d6b7af7b72, ssOutSystemsMaps.RestRecords.RESTRC_7d204fba4e0a277c99c007d6b7af7b72> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7d204fba4e0a277c99c007d6b7af7b72 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_7d204fba4e0a277c99c007d6b7af7b72 FromStructure(RC_7d204fba4e0a277c99c007d6b7af7b72 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_7d204fba4e0a277c99c007d6b7af7b72(s, config);
}

}


