using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_drawMarker_configs
public class RESTST_f121435b3edb481ee03ab7ef58e5b805Structure : AbstractRESTStructure<ST_f121435b3edb481ee03ab7ef58e5b805Structure> {
[JsonProperty("allowDrag")]
public bool? AttrallowDrag;

[JsonProperty("iconUrl")]
public string AttriconUrl;

public RESTST_f121435b3edb481ee03ab7ef58e5b805Structure() { }

public RESTST_f121435b3edb481ee03ab7ef58e5b805Structure (ST_f121435b3edb481ee03ab7ef58e5b805Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrallowDrag = ConvertToRestWithoutDefaults(s.ssallowDrag, false);
AttriconUrl = ConvertToRestWithoutDefaults(s.ssiconUrl, "");
  } else {
AttrallowDrag = (bool?) s.ssallowDrag;
AttriconUrl = s.ssiconUrl;
  }
}

public static ST_f121435b3edb481ee03ab7ef58e5b805Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_f121435b3edb481ee03ab7ef58e5b805Structure obj) { 
  ST_f121435b3edb481ee03ab7ef58e5b805Structure s = new ST_f121435b3edb481ee03ab7ef58e5b805Structure();
  if(obj != null) {
  s.ssallowDrag = obj.AttrallowDrag == null ? false : obj.AttrallowDrag.Value;
  s.ssiconUrl = obj.AttriconUrl == null ? "" : obj.AttriconUrl;
  }
  return s;
}

public static Func<ST_f121435b3edb481ee03ab7ef58e5b805Structure, ssOutSystemsMaps.RestRecords.RESTST_f121435b3edb481ee03ab7ef58e5b805Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f121435b3edb481ee03ab7ef58e5b805Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_f121435b3edb481ee03ab7ef58e5b805Structure FromStructure(ST_f121435b3edb481ee03ab7ef58e5b805Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_f121435b3edb481ee03ab7ef58e5b805Structure(s, config);
}

}


