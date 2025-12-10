using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// PopupEventRecord
public class JSONRC_b426a0d7aa8f7cff1977eb04da864b0f : AbstractRESTStructure<RC_b426a0d7aa8f7cff1977eb04da864b0f> {
[JsonProperty("PopupEvent")]
[JsonPropertyName("PopupEvent")]
public ssOutSystemsMaps.RestRecords.JSONEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord AttrPopupEvent;

public JSONRC_b426a0d7aa8f7cff1977eb04da864b0f() { }

public JSONRC_b426a0d7aa8f7cff1977eb04da864b0f (RC_b426a0d7aa8f7cff1977eb04da864b0f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPopupEvent = ConvertToRestWithoutDefaults(s.ssENPopupEvent, new EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord.FromStructureDelegate(config));
  } else {
AttrPopupEvent = ssOutSystemsMaps.RestRecords.JSONEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord.FromStructure(s.ssENPopupEvent, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_b426a0d7aa8f7cff1977eb04da864b0f, RC_b426a0d7aa8f7cff1977eb04da864b0f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_b426a0d7aa8f7cff1977eb04da864b0f s) => ToStructure(s, config);
}
public static RC_b426a0d7aa8f7cff1977eb04da864b0f ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_b426a0d7aa8f7cff1977eb04da864b0f obj, IBehaviorsConfiguration config) { 
  RC_b426a0d7aa8f7cff1977eb04da864b0f s = new RC_b426a0d7aa8f7cff1977eb04da864b0f();
  if(obj != null) {
  s.ssENPopupEvent = ssOutSystemsMaps.RestRecords.JSONEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord.ToStructure(obj.AttrPopupEvent, config);
  }
  return s;
}

public static Func<RC_b426a0d7aa8f7cff1977eb04da864b0f, ssOutSystemsMaps.RestRecords.JSONRC_b426a0d7aa8f7cff1977eb04da864b0f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b426a0d7aa8f7cff1977eb04da864b0f s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_b426a0d7aa8f7cff1977eb04da864b0f FromStructure(RC_b426a0d7aa8f7cff1977eb04da864b0f s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_b426a0d7aa8f7cff1977eb04da864b0f(s, config);
}

}


