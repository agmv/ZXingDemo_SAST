using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AnimatedLabel_InternalConfig
public class RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure : AbstractRESTStructure<ST_52888c3e6f33b11b7d6288dd268a26dcStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure() { }

public RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure (ST_52888c3e6f33b11b7d6288dd268a26dcStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_52888c3e6f33b11b7d6288dd268a26dcStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure obj) { 
  ST_52888c3e6f33b11b7d6288dd268a26dcStructure s = new ST_52888c3e6f33b11b7d6288dd268a26dcStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_52888c3e6f33b11b7d6288dd268a26dcStructure, ssOutSystemsUI.RestRecords.RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_52888c3e6f33b11b7d6288dd268a26dcStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure FromStructure(ST_52888c3e6f33b11b7d6288dd268a26dcStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure(s, config);
}

}


