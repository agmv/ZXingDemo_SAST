using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawingTools_Configs
public class RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure : AbstractRESTStructure<ST_61db11323cabca5a5fb3b6c7b9d63842Structure> {
[JsonProperty("Internal_to_provider_drawingTools_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure AttrInternal_to_provider_drawingTools_configs;

[JsonProperty("UniqueId")]
public string AttrUniqueId;

public RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure() { }

public RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure (ST_61db11323cabca5a5fb3b6c7b9d63842Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_drawingTools_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_drawingTools_configs, new ST_3f16cd459ccd861deffd4483bc1bbac3Structure(), ssOutSystemsMaps.RestRecords.RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_drawingTools_configs = ssOutSystemsMaps.RestRecords.RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure.FromStructure(s.ssInternal_to_provider_drawingTools_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static ST_61db11323cabca5a5fb3b6c7b9d63842Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure obj) { 
  ST_61db11323cabca5a5fb3b6c7b9d63842Structure s = new ST_61db11323cabca5a5fb3b6c7b9d63842Structure();
  if(obj != null) {
  s.ssInternal_to_provider_drawingTools_configs = ssOutSystemsMaps.RestRecords.RESTST_3f16cd459ccd861deffd4483bc1bbac3Structure.ToStructure(obj.AttrInternal_to_provider_drawingTools_configs);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_61db11323cabca5a5fb3b6c7b9d63842Structure, ssOutSystemsMaps.RestRecords.RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_61db11323cabca5a5fb3b6c7b9d63842Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure FromStructure(ST_61db11323cabca5a5fb3b6c7b9d63842Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_61db11323cabca5a5fb3b6c7b9d63842Structure(s, config);
}

}


