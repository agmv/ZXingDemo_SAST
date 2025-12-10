using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ColumnBreakRecord
public class RESTRC_b6adbbf4e08bad2975a6f8f796279b71 : AbstractRESTStructure<RC_b6adbbf4e08bad2975a6f8f796279b71> {
[JsonProperty("ColumnBreak")]
public ssOutSystemsUI.RestRecords.RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord AttrColumnBreak;

public RESTRC_b6adbbf4e08bad2975a6f8f796279b71() { }

public RESTRC_b6adbbf4e08bad2975a6f8f796279b71 (RC_b6adbbf4e08bad2975a6f8f796279b71 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColumnBreak = ConvertToRestWithoutDefaults(s.ssENColumnBreak, new EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord.FromStructureDelegate(config));
  } else {
AttrColumnBreak = ssOutSystemsUI.RestRecords.RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord.FromStructure(s.ssENColumnBreak, config);
  }
}

public static RC_b6adbbf4e08bad2975a6f8f796279b71 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_b6adbbf4e08bad2975a6f8f796279b71 obj) { 
  RC_b6adbbf4e08bad2975a6f8f796279b71 s = new RC_b6adbbf4e08bad2975a6f8f796279b71();
  if(obj != null) {
  s.ssENColumnBreak = ssOutSystemsUI.RestRecords.RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord.ToStructure(obj.AttrColumnBreak);
  }
  return s;
}

public static Func<RC_b6adbbf4e08bad2975a6f8f796279b71, ssOutSystemsUI.RestRecords.RESTRC_b6adbbf4e08bad2975a6f8f796279b71> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b6adbbf4e08bad2975a6f8f796279b71 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_b6adbbf4e08bad2975a6f8f796279b71 FromStructure(RC_b6adbbf4e08bad2975a6f8f796279b71 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_b6adbbf4e08bad2975a6f8f796279b71(s, config);
}

}


