using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TabsHeaderItem_InternalConfig
public class RESTST_4f70c42b393d853a53e093e196f4b683Structure : AbstractRESTStructure<ST_4f70c42b393d853a53e093e196f4b683Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_4f70c42b393d853a53e093e196f4b683Structure() { }

public RESTST_4f70c42b393d853a53e093e196f4b683Structure (ST_4f70c42b393d853a53e093e196f4b683Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_4f70c42b393d853a53e093e196f4b683Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_4f70c42b393d853a53e093e196f4b683Structure obj) { 
  ST_4f70c42b393d853a53e093e196f4b683Structure s = new ST_4f70c42b393d853a53e093e196f4b683Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_4f70c42b393d853a53e093e196f4b683Structure, ssOutSystemsUI.RestRecords.RESTST_4f70c42b393d853a53e093e196f4b683Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4f70c42b393d853a53e093e196f4b683Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_4f70c42b393d853a53e093e196f4b683Structure FromStructure(ST_4f70c42b393d853a53e093e196f4b683Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_4f70c42b393d853a53e093e196f4b683Structure(s, config);
}

}


