using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Gallery_InternalConfig
public class JSONST_546a3060996e070a522a708cd2d94c23Structure : AbstractRESTStructure<ST_546a3060996e070a522a708cd2d94c23Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("RowItemsPhone")]
[JsonPropertyName("RowItemsPhone")]
public string AttrRowItemsPhone;

[JsonProperty("RowItemsTablet")]
[JsonPropertyName("RowItemsTablet")]
public string AttrRowItemsTablet;

[JsonProperty("RowItemsDesktop")]
[JsonPropertyName("RowItemsDesktop")]
public string AttrRowItemsDesktop;

[JsonProperty("ItemsGap")]
[JsonPropertyName("ItemsGap")]
public string AttrItemsGap;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_546a3060996e070a522a708cd2d94c23Structure() { }

public JSONST_546a3060996e070a522a708cd2d94c23Structure (ST_546a3060996e070a522a708cd2d94c23Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrRowItemsPhone = ConvertToRestWithoutDefaults(s.ssRowItemsPhone, "");
AttrRowItemsTablet = ConvertToRestWithoutDefaults(s.ssRowItemsTablet, "");
AttrRowItemsDesktop = ConvertToRestWithoutDefaults(s.ssRowItemsDesktop, "");
AttrItemsGap = ConvertToRestWithoutDefaults(s.ssItemsGap, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrRowItemsPhone = s.ssRowItemsPhone;
AttrRowItemsTablet = s.ssRowItemsTablet;
AttrRowItemsDesktop = s.ssRowItemsDesktop;
AttrItemsGap = s.ssItemsGap;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure, ST_546a3060996e070a522a708cd2d94c23Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure s) => ToStructure(s, config);
}
public static ST_546a3060996e070a522a708cd2d94c23Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure obj, IBehaviorsConfiguration config) { 
  ST_546a3060996e070a522a708cd2d94c23Structure s = new ST_546a3060996e070a522a708cd2d94c23Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssRowItemsPhone = obj.AttrRowItemsPhone == null ? "" : obj.AttrRowItemsPhone;
  s.ssRowItemsTablet = obj.AttrRowItemsTablet == null ? "" : obj.AttrRowItemsTablet;
  s.ssRowItemsDesktop = obj.AttrRowItemsDesktop == null ? "" : obj.AttrRowItemsDesktop;
  s.ssItemsGap = obj.AttrItemsGap == null ? "" : obj.AttrItemsGap;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_546a3060996e070a522a708cd2d94c23Structure, ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_546a3060996e070a522a708cd2d94c23Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure FromStructure(ST_546a3060996e070a522a708cd2d94c23Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure(s, config);
}

}


