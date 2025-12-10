using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Tooltip_InternalConfig
public class RESTST_9cac82fc47e32e1503b2dbc00140aa98Structure : AbstractRESTStructure<ST_9cac82fc47e32e1503b2dbc00140aa98Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("Position")]
public string AttrPosition;

[JsonProperty("StartVisible")]
public bool? AttrStartVisible;

[JsonProperty("IsHover")]
public bool? AttrIsHover;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_9cac82fc47e32e1503b2dbc00140aa98Structure() { }

public RESTST_9cac82fc47e32e1503b2dbc00140aa98Structure (ST_9cac82fc47e32e1503b2dbc00140aa98Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, "");
AttrStartVisible = ConvertToRestWithoutDefaults(s.ssStartVisible, false);
AttrIsHover = ConvertToRestWithoutDefaults(s.ssIsHover, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrPosition = s.ssPosition;
AttrStartVisible = (bool?) s.ssStartVisible;
AttrIsHover = (bool?) s.ssIsHover;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_9cac82fc47e32e1503b2dbc00140aa98Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_9cac82fc47e32e1503b2dbc00140aa98Structure obj) { 
  ST_9cac82fc47e32e1503b2dbc00140aa98Structure s = new ST_9cac82fc47e32e1503b2dbc00140aa98Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  s.ssStartVisible = obj.AttrStartVisible == null ? false : obj.AttrStartVisible.Value;
  s.ssIsHover = obj.AttrIsHover == null ? false : obj.AttrIsHover.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_9cac82fc47e32e1503b2dbc00140aa98Structure, ssOutSystemsUI.RestRecords.RESTST_9cac82fc47e32e1503b2dbc00140aa98Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9cac82fc47e32e1503b2dbc00140aa98Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_9cac82fc47e32e1503b2dbc00140aa98Structure FromStructure(ST_9cac82fc47e32e1503b2dbc00140aa98Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_9cac82fc47e32e1503b2dbc00140aa98Structure(s, config);
}

}


