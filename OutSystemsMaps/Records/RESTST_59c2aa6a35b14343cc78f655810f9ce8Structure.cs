using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Localization
public class RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure : AbstractRESTStructure<ST_59c2aa6a35b14343cc78f655810f9ce8Structure> {
[JsonProperty("Language")]
public string AttrLanguage;

[JsonProperty("Region")]
public string AttrRegion;

public RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure() { }

public RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure (ST_59c2aa6a35b14343cc78f655810f9ce8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLanguage = ConvertToRestWithoutDefaults(s.ssLanguage, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
  } else {
AttrLanguage = s.ssLanguage;
AttrRegion = s.ssRegion;
  }
}

public static ST_59c2aa6a35b14343cc78f655810f9ce8Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure obj) { 
  ST_59c2aa6a35b14343cc78f655810f9ce8Structure s = new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
  if(obj != null) {
  s.ssLanguage = obj.AttrLanguage == null ? "" : obj.AttrLanguage;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  }
  return s;
}

public static Func<ST_59c2aa6a35b14343cc78f655810f9ce8Structure, ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_59c2aa6a35b14343cc78f655810f9ce8Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure FromStructure(ST_59c2aa6a35b14343cc78f655810f9ce8Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure(s, config);
}

}


