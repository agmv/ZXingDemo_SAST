using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ShapeRecord
public class RESTRC_0a89eeb60fa1f44b6316ca69b462007b : AbstractRESTStructure<RC_0a89eeb60fa1f44b6316ca69b462007b> {
[JsonProperty("Shape")]
public ssOutSystemsUI.RestRecords.RESTEN_d11562be18a7e40ca777aa336c946163EntityRecord AttrShape;

public RESTRC_0a89eeb60fa1f44b6316ca69b462007b() { }

public RESTRC_0a89eeb60fa1f44b6316ca69b462007b (RC_0a89eeb60fa1f44b6316ca69b462007b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShape = ConvertToRestWithoutDefaults(s.ssENShape, new EN_d11562be18a7e40ca777aa336c946163EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_d11562be18a7e40ca777aa336c946163EntityRecord.FromStructureDelegate(config));
  } else {
AttrShape = ssOutSystemsUI.RestRecords.RESTEN_d11562be18a7e40ca777aa336c946163EntityRecord.FromStructure(s.ssENShape, config);
  }
}

public static RC_0a89eeb60fa1f44b6316ca69b462007b ToStructure(ssOutSystemsUI.RestRecords.RESTRC_0a89eeb60fa1f44b6316ca69b462007b obj) { 
  RC_0a89eeb60fa1f44b6316ca69b462007b s = new RC_0a89eeb60fa1f44b6316ca69b462007b();
  if(obj != null) {
  s.ssENShape = ssOutSystemsUI.RestRecords.RESTEN_d11562be18a7e40ca777aa336c946163EntityRecord.ToStructure(obj.AttrShape);
  }
  return s;
}

public static Func<RC_0a89eeb60fa1f44b6316ca69b462007b, ssOutSystemsUI.RestRecords.RESTRC_0a89eeb60fa1f44b6316ca69b462007b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a89eeb60fa1f44b6316ca69b462007b s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_0a89eeb60fa1f44b6316ca69b462007b FromStructure(RC_0a89eeb60fa1f44b6316ca69b462007b s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_0a89eeb60fa1f44b6316ca69b462007b(s, config);
}

}


