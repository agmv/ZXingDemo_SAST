using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsEventRecord
public class JSONRC_499414721b608cf3d3b8f99fae961f52 : AbstractRESTStructure<RC_499414721b608cf3d3b8f99fae961f52> {
[JsonProperty("DrawingToolsEvent")]
[JsonPropertyName("DrawingToolsEvent")]
public ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord AttrDrawingToolsEvent;

public JSONRC_499414721b608cf3d3b8f99fae961f52() { }

public JSONRC_499414721b608cf3d3b8f99fae961f52 (RC_499414721b608cf3d3b8f99fae961f52 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDrawingToolsEvent = ConvertToRestWithoutDefaults(s.ssENDrawingToolsEvent, new EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord.FromStructureDelegate(config));
  } else {
AttrDrawingToolsEvent = ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord.FromStructure(s.ssENDrawingToolsEvent, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_499414721b608cf3d3b8f99fae961f52, RC_499414721b608cf3d3b8f99fae961f52> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_499414721b608cf3d3b8f99fae961f52 s) => ToStructure(s, config);
}
public static RC_499414721b608cf3d3b8f99fae961f52 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_499414721b608cf3d3b8f99fae961f52 obj, IBehaviorsConfiguration config) { 
  RC_499414721b608cf3d3b8f99fae961f52 s = new RC_499414721b608cf3d3b8f99fae961f52();
  if(obj != null) {
  s.ssENDrawingToolsEvent = ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord.ToStructure(obj.AttrDrawingToolsEvent, config);
  }
  return s;
}

public static Func<RC_499414721b608cf3d3b8f99fae961f52, ssOutSystemsMaps.RestRecords.JSONRC_499414721b608cf3d3b8f99fae961f52> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_499414721b608cf3d3b8f99fae961f52 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_499414721b608cf3d3b8f99fae961f52 FromStructure(RC_499414721b608cf3d3b8f99fae961f52 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_499414721b608cf3d3b8f99fae961f52(s, config);
}

}


