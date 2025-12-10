using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeTypeRecord
public class JSONRC_3201d1384957542debf3cb5808f51144 : AbstractRESTStructure<RC_3201d1384957542debf3cb5808f51144> {
[JsonProperty("ShapeType")]
[JsonPropertyName("ShapeType")]
public ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord AttrShapeType;

public JSONRC_3201d1384957542debf3cb5808f51144() { }

public JSONRC_3201d1384957542debf3cb5808f51144 (RC_3201d1384957542debf3cb5808f51144 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShapeType = ConvertToRestWithoutDefaults(s.ssENShapeType, new EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord.FromStructureDelegate(config));
  } else {
AttrShapeType = ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord.FromStructure(s.ssENShapeType, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_3201d1384957542debf3cb5808f51144, RC_3201d1384957542debf3cb5808f51144> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_3201d1384957542debf3cb5808f51144 s) => ToStructure(s, config);
}
public static RC_3201d1384957542debf3cb5808f51144 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_3201d1384957542debf3cb5808f51144 obj, IBehaviorsConfiguration config) { 
  RC_3201d1384957542debf3cb5808f51144 s = new RC_3201d1384957542debf3cb5808f51144();
  if(obj != null) {
  s.ssENShapeType = ssOutSystemsMaps.RestRecords.JSONEN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord.ToStructure(obj.AttrShapeType, config);
  }
  return s;
}

public static Func<RC_3201d1384957542debf3cb5808f51144, ssOutSystemsMaps.RestRecords.JSONRC_3201d1384957542debf3cb5808f51144> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3201d1384957542debf3cb5808f51144 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_3201d1384957542debf3cb5808f51144 FromStructure(RC_3201d1384957542debf3cb5808f51144 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_3201d1384957542debf3cb5808f51144(s, config);
}

}


