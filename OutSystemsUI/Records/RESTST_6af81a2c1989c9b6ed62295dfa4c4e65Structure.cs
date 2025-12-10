using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownServerSideItem_InternalConfigs
public class RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure : AbstractRESTStructure<ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ItemId")]
public string AttrItemId;

[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure() { }

public RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure (ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrItemId = ConvertToRestWithoutDefaults(s.ssItemId, "");
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, Convert.ToString(1));
  } else {
AttrUniqueId = s.ssUniqueId;
AttrItemId = s.ssItemId;
AttrIsSelected = (bool?) s.ssIsSelected;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure obj) { 
  ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure s = new ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssItemId = obj.AttrItemId == null ? "" : obj.AttrItemId;
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? Convert.ToString(1) : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure, ssOutSystemsUI.RestRecords.RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure FromStructure(ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_6af81a2c1989c9b6ed62295dfa4c4e65Structure(s, config);
}

}


