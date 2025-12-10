using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_fileLayer_configs
public class JSONST_793e574f3ddb64f39831eacf8a4462b0Structure : AbstractRESTStructure<ST_793e574f3ddb64f39831eacf8a4462b0Structure> {
[JsonProperty("layerUrl")]
[JsonPropertyName("layerUrl")]
public string AttrlayerUrl;

[JsonProperty("suppressPopups")]
[JsonPropertyName("suppressPopups")]
public bool? AttrsuppressPopups;

[JsonProperty("preserveViewport")]
[JsonPropertyName("preserveViewport")]
public bool? AttrpreserveViewport;

public JSONST_793e574f3ddb64f39831eacf8a4462b0Structure() { }

public JSONST_793e574f3ddb64f39831eacf8a4462b0Structure (ST_793e574f3ddb64f39831eacf8a4462b0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrlayerUrl = ConvertToRestWithoutDefaults(s.sslayerUrl, "");
AttrsuppressPopups = ConvertToRestWithoutDefaults(s.sssuppressPopups, false);
AttrpreserveViewport = ConvertToRestWithoutDefaults(s.sspreserveViewport, false);
  } else {
AttrlayerUrl = s.sslayerUrl;
AttrsuppressPopups = (bool?) s.sssuppressPopups;
AttrpreserveViewport = (bool?) s.sspreserveViewport;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure, ST_793e574f3ddb64f39831eacf8a4462b0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure s) => ToStructure(s, config);
}
public static ST_793e574f3ddb64f39831eacf8a4462b0Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure obj, IBehaviorsConfiguration config) { 
  ST_793e574f3ddb64f39831eacf8a4462b0Structure s = new ST_793e574f3ddb64f39831eacf8a4462b0Structure();
  if(obj != null) {
  s.sslayerUrl = obj.AttrlayerUrl == null ? "" : obj.AttrlayerUrl;
  s.sssuppressPopups = obj.AttrsuppressPopups == null ? false : obj.AttrsuppressPopups.Value;
  s.sspreserveViewport = obj.AttrpreserveViewport == null ? false : obj.AttrpreserveViewport.Value;
  }
  return s;
}

public static Func<ST_793e574f3ddb64f39831eacf8a4462b0Structure, ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_793e574f3ddb64f39831eacf8a4462b0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure FromStructure(ST_793e574f3ddb64f39831eacf8a4462b0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_793e574f3ddb64f39831eacf8a4462b0Structure(s, config);
}

}


