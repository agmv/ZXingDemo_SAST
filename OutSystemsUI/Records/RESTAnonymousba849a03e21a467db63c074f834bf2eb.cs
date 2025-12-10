using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AnimationTypeRecord
public class RESTRC_78b6d6ed7d52800a8a68e7d796ec6850 : AbstractRESTStructure<RC_78b6d6ed7d52800a8a68e7d796ec6850> {
[JsonProperty("AnimationType")]
public ssOutSystemsUI.RestRecords.RESTEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord AttrAnimationType;

public RESTRC_78b6d6ed7d52800a8a68e7d796ec6850() { }

public RESTRC_78b6d6ed7d52800a8a68e7d796ec6850 (RC_78b6d6ed7d52800a8a68e7d796ec6850 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAnimationType = ConvertToRestWithoutDefaults(s.ssENAnimationType, new EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord.FromStructureDelegate(config));
  } else {
AttrAnimationType = ssOutSystemsUI.RestRecords.RESTEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord.FromStructure(s.ssENAnimationType, config);
  }
}

public static RC_78b6d6ed7d52800a8a68e7d796ec6850 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_78b6d6ed7d52800a8a68e7d796ec6850 obj) { 
  RC_78b6d6ed7d52800a8a68e7d796ec6850 s = new RC_78b6d6ed7d52800a8a68e7d796ec6850();
  if(obj != null) {
  s.ssENAnimationType = ssOutSystemsUI.RestRecords.RESTEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord.ToStructure(obj.AttrAnimationType);
  }
  return s;
}

public static Func<RC_78b6d6ed7d52800a8a68e7d796ec6850, ssOutSystemsUI.RestRecords.RESTRC_78b6d6ed7d52800a8a68e7d796ec6850> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78b6d6ed7d52800a8a68e7d796ec6850 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_78b6d6ed7d52800a8a68e7d796ec6850 FromStructure(RC_78b6d6ed7d52800a8a68e7d796ec6850 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_78b6d6ed7d52800a8a68e7d796ec6850(s, config);
}

}


