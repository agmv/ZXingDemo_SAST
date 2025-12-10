using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ButtonLoading_InternalConfig
public class JSONST_2b510eefd88959a00bf486cfc856fa96Structure : AbstractRESTStructure<ST_2b510eefd88959a00bf486cfc856fa96Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("IsLoading")]
[JsonPropertyName("IsLoading")]
public bool? AttrIsLoading;

[JsonProperty("ShowLoadingAndLabel")]
[JsonPropertyName("ShowLoadingAndLabel")]
public bool? AttrShowLoadingAndLabel;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_2b510eefd88959a00bf486cfc856fa96Structure() { }

public JSONST_2b510eefd88959a00bf486cfc856fa96Structure (ST_2b510eefd88959a00bf486cfc856fa96Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrIsLoading = ConvertToRestWithoutDefaults(s.ssIsLoading, false);
AttrShowLoadingAndLabel = ConvertToRestWithoutDefaults(s.ssShowLoadingAndLabel, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrIsLoading = (bool?) s.ssIsLoading;
AttrShowLoadingAndLabel = (bool?) s.ssShowLoadingAndLabel;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure, ST_2b510eefd88959a00bf486cfc856fa96Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure s) => ToStructure(s, config);
}
public static ST_2b510eefd88959a00bf486cfc856fa96Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure obj, IBehaviorsConfiguration config) { 
  ST_2b510eefd88959a00bf486cfc856fa96Structure s = new ST_2b510eefd88959a00bf486cfc856fa96Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssIsLoading = obj.AttrIsLoading == null ? false : obj.AttrIsLoading.Value;
  s.ssShowLoadingAndLabel = obj.AttrShowLoadingAndLabel == null ? false : obj.AttrShowLoadingAndLabel.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_2b510eefd88959a00bf486cfc856fa96Structure, ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2b510eefd88959a00bf486cfc856fa96Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure FromStructure(ST_2b510eefd88959a00bf486cfc856fa96Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure(s, config);
}

}


