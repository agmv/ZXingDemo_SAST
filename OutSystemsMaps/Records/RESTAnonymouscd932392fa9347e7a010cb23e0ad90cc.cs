using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// PopupEventRecord
public class RESTRC_b426a0d7aa8f7cff1977eb04da864b0f : AbstractRESTStructure<RC_b426a0d7aa8f7cff1977eb04da864b0f> {
[JsonProperty("PopupEvent")]
public ssOutSystemsMaps.RestRecords.RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord AttrPopupEvent;

public RESTRC_b426a0d7aa8f7cff1977eb04da864b0f() { }

public RESTRC_b426a0d7aa8f7cff1977eb04da864b0f (RC_b426a0d7aa8f7cff1977eb04da864b0f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPopupEvent = ConvertToRestWithoutDefaults(s.ssENPopupEvent, new EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord.FromStructureDelegate(config));
  } else {
AttrPopupEvent = ssOutSystemsMaps.RestRecords.RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord.FromStructure(s.ssENPopupEvent, config);
  }
}

public static RC_b426a0d7aa8f7cff1977eb04da864b0f ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_b426a0d7aa8f7cff1977eb04da864b0f obj) { 
  RC_b426a0d7aa8f7cff1977eb04da864b0f s = new RC_b426a0d7aa8f7cff1977eb04da864b0f();
  if(obj != null) {
  s.ssENPopupEvent = ssOutSystemsMaps.RestRecords.RESTEN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord.ToStructure(obj.AttrPopupEvent);
  }
  return s;
}

public static Func<RC_b426a0d7aa8f7cff1977eb04da864b0f, ssOutSystemsMaps.RestRecords.RESTRC_b426a0d7aa8f7cff1977eb04da864b0f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b426a0d7aa8f7cff1977eb04da864b0f s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_b426a0d7aa8f7cff1977eb04da864b0f FromStructure(RC_b426a0d7aa8f7cff1977eb04da864b0f s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_b426a0d7aa8f7cff1977eb04da864b0f(s, config);
}

}


