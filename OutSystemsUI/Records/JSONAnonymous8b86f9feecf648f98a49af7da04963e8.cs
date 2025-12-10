using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SectionIndexItem_InternalConfigRecord
public class JSONRC_5eb5daa2af512be51806b390378b7c9a : AbstractRESTStructure<RC_5eb5daa2af512be51806b390378b7c9a> {
[JsonProperty("SectionIndexItem_InternalConfig")]
[JsonPropertyName("SectionIndexItem_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_a783e375273068e4b8f9c122c1661a6aStructure AttrSectionIndexItem_InternalConfig;

public JSONRC_5eb5daa2af512be51806b390378b7c9a() { }

public JSONRC_5eb5daa2af512be51806b390378b7c9a (RC_5eb5daa2af512be51806b390378b7c9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSectionIndexItem_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTSectionIndexItem_InternalConfig, new ST_a783e375273068e4b8f9c122c1661a6aStructure(), ssOutSystemsUI.RestRecords.JSONST_a783e375273068e4b8f9c122c1661a6aStructure.FromStructureDelegate(config));
  } else {
AttrSectionIndexItem_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_a783e375273068e4b8f9c122c1661a6aStructure.FromStructure(s.ssSTSectionIndexItem_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_5eb5daa2af512be51806b390378b7c9a, RC_5eb5daa2af512be51806b390378b7c9a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_5eb5daa2af512be51806b390378b7c9a s) => ToStructure(s, config);
}
public static RC_5eb5daa2af512be51806b390378b7c9a ToStructure(ssOutSystemsUI.RestRecords.JSONRC_5eb5daa2af512be51806b390378b7c9a obj, IBehaviorsConfiguration config) { 
  RC_5eb5daa2af512be51806b390378b7c9a s = new RC_5eb5daa2af512be51806b390378b7c9a();
  if(obj != null) {
  s.ssSTSectionIndexItem_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_a783e375273068e4b8f9c122c1661a6aStructure.ToStructure(obj.AttrSectionIndexItem_InternalConfig, config);
  }
  return s;
}

public static Func<RC_5eb5daa2af512be51806b390378b7c9a, ssOutSystemsUI.RestRecords.JSONRC_5eb5daa2af512be51806b390378b7c9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5eb5daa2af512be51806b390378b7c9a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_5eb5daa2af512be51806b390378b7c9a FromStructure(RC_5eb5daa2af512be51806b390378b7c9a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_5eb5daa2af512be51806b390378b7c9a(s, config);
}

}


