using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_marker_configs
public class JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure : AbstractRESTStructure<ST_51ef6a78944132edc56aa7bf7c4ea240Structure> {
[JsonProperty("location")]
[JsonPropertyName("location")]
public string Attrlocation;

[JsonProperty("iconUrl")]
[JsonPropertyName("iconUrl")]
public string AttriconUrl;

[JsonProperty("title")]
[JsonPropertyName("title")]
public string Attrtitle;

[JsonProperty("label")]
[JsonPropertyName("label")]
public string Attrlabel;

[JsonProperty("allowDrag")]
[JsonPropertyName("allowDrag")]
public bool? AttrallowDrag;

[JsonProperty("iconWidth")]
[JsonPropertyName("iconWidth")]
public string AttriconWidth;

[JsonProperty("iconHeight")]
[JsonPropertyName("iconHeight")]
public string AttriconHeight;

public JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure() { }

public JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure (ST_51ef6a78944132edc56aa7bf7c4ea240Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrlocation = ConvertToRestWithoutDefaults(s.sslocation, "");
AttriconUrl = s.ssiconUrl;
Attrtitle = s.sstitle;
Attrlabel = s.sslabel;
AttrallowDrag = (bool?) s.ssallowDrag;
AttriconWidth = s.ssiconWidth;
AttriconHeight = s.ssiconHeight;
  } else {
Attrlocation = s.sslocation;
AttriconUrl = s.ssiconUrl;
Attrtitle = s.sstitle;
Attrlabel = s.sslabel;
AttrallowDrag = (bool?) s.ssallowDrag;
AttriconWidth = s.ssiconWidth;
AttriconHeight = s.ssiconHeight;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure, ST_51ef6a78944132edc56aa7bf7c4ea240Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure s) => ToStructure(s, config);
}
public static ST_51ef6a78944132edc56aa7bf7c4ea240Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure obj, IBehaviorsConfiguration config) { 
  ST_51ef6a78944132edc56aa7bf7c4ea240Structure s = new ST_51ef6a78944132edc56aa7bf7c4ea240Structure();
  if(obj != null) {
  s.sslocation = obj.Attrlocation == null ? "" : obj.Attrlocation;
  s.ssiconUrl = obj.AttriconUrl == null ? "" : obj.AttriconUrl;
  s.sstitle = obj.Attrtitle == null ? "" : obj.Attrtitle;
  s.sslabel = obj.Attrlabel == null ? "" : obj.Attrlabel;
  s.ssallowDrag = obj.AttrallowDrag == null ? false : obj.AttrallowDrag.Value;
  s.ssiconWidth = obj.AttriconWidth == null ? "" : obj.AttriconWidth;
  s.ssiconHeight = obj.AttriconHeight == null ? "" : obj.AttriconHeight;
  }
  return s;
}

public static Func<ST_51ef6a78944132edc56aa7bf7c4ea240Structure, ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_51ef6a78944132edc56aa7bf7c4ea240Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure FromStructure(ST_51ef6a78944132edc56aa7bf7c4ea240Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure(s, config);
}

}


