using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawCircle_ShapeRecord
public class JSONRC_0d7cc7bed68e0cd9bac246a9a398426e : AbstractRESTStructure<RC_0d7cc7bed68e0cd9bac246a9a398426e> {
[JsonProperty("Internal_DrawCircle_Shape")]
[JsonPropertyName("Internal_DrawCircle_Shape")]
public ssOutSystemsMaps.RestRecords.JSONST_b3f640c8758c66e2b436da510a8dfe3cStructure AttrInternal_DrawCircle_Shape;

public JSONRC_0d7cc7bed68e0cd9bac246a9a398426e() { }

public JSONRC_0d7cc7bed68e0cd9bac246a9a398426e (RC_0d7cc7bed68e0cd9bac246a9a398426e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawCircle_Shape = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawCircle_Shape, new ST_b3f640c8758c66e2b436da510a8dfe3cStructure(), ssOutSystemsMaps.RestRecords.JSONST_b3f640c8758c66e2b436da510a8dfe3cStructure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawCircle_Shape = ssOutSystemsMaps.RestRecords.JSONST_b3f640c8758c66e2b436da510a8dfe3cStructure.FromStructure(s.ssSTInternal_DrawCircle_Shape, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_0d7cc7bed68e0cd9bac246a9a398426e, RC_0d7cc7bed68e0cd9bac246a9a398426e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_0d7cc7bed68e0cd9bac246a9a398426e s) => ToStructure(s, config);
}
public static RC_0d7cc7bed68e0cd9bac246a9a398426e ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_0d7cc7bed68e0cd9bac246a9a398426e obj, IBehaviorsConfiguration config) { 
  RC_0d7cc7bed68e0cd9bac246a9a398426e s = new RC_0d7cc7bed68e0cd9bac246a9a398426e();
  if(obj != null) {
  s.ssSTInternal_DrawCircle_Shape = ssOutSystemsMaps.RestRecords.JSONST_b3f640c8758c66e2b436da510a8dfe3cStructure.ToStructure(obj.AttrInternal_DrawCircle_Shape, config);
  }
  return s;
}

public static Func<RC_0d7cc7bed68e0cd9bac246a9a398426e, ssOutSystemsMaps.RestRecords.JSONRC_0d7cc7bed68e0cd9bac246a9a398426e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0d7cc7bed68e0cd9bac246a9a398426e s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_0d7cc7bed68e0cd9bac246a9a398426e FromStructure(RC_0d7cc7bed68e0cd9bac246a9a398426e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_0d7cc7bed68e0cd9bac246a9a398426e(s, config);
}

}


