using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ZoomRecord
public class JSONRC_80e81fddca0089d3f29f81106c0bee34 : AbstractRESTStructure<RC_80e81fddca0089d3f29f81106c0bee34> {
[JsonProperty("Zoom")]
[JsonPropertyName("Zoom")]
public ssOutSystemsMaps.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord AttrZoom;

public JSONRC_80e81fddca0089d3f29f81106c0bee34() { }

public JSONRC_80e81fddca0089d3f29f81106c0bee34 (RC_80e81fddca0089d3f29f81106c0bee34 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZoom = ConvertToRestWithoutDefaults(s.ssENZoom, new EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord.FromStructureDelegate(config));
  } else {
AttrZoom = ssOutSystemsMaps.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord.FromStructure(s.ssENZoom, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_80e81fddca0089d3f29f81106c0bee34, RC_80e81fddca0089d3f29f81106c0bee34> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_80e81fddca0089d3f29f81106c0bee34 s) => ToStructure(s, config);
}
public static RC_80e81fddca0089d3f29f81106c0bee34 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_80e81fddca0089d3f29f81106c0bee34 obj, IBehaviorsConfiguration config) { 
  RC_80e81fddca0089d3f29f81106c0bee34 s = new RC_80e81fddca0089d3f29f81106c0bee34();
  if(obj != null) {
  s.ssENZoom = ssOutSystemsMaps.RestRecords.JSONEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord.ToStructure(obj.AttrZoom, config);
  }
  return s;
}

public static Func<RC_80e81fddca0089d3f29f81106c0bee34, ssOutSystemsMaps.RestRecords.JSONRC_80e81fddca0089d3f29f81106c0bee34> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_80e81fddca0089d3f29f81106c0bee34 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_80e81fddca0089d3f29f81106c0bee34 FromStructure(RC_80e81fddca0089d3f29f81106c0bee34 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_80e81fddca0089d3f29f81106c0bee34(s, config);
}

}


