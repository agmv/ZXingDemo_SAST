using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AutoplayRecord
public class RESTRC_c6831d06e579de4edbcf59e128b60b13 : AbstractRESTStructure<RC_c6831d06e579de4edbcf59e128b60b13> {
[JsonProperty("Autoplay")]
public ssOutSystemsUI.RestRecords.RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord AttrAutoplay;

public RESTRC_c6831d06e579de4edbcf59e128b60b13() { }

public RESTRC_c6831d06e579de4edbcf59e128b60b13 (RC_c6831d06e579de4edbcf59e128b60b13 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAutoplay = ConvertToRestWithoutDefaults(s.ssENAutoplay, new EN_c3a2475ae6370a2f746040280495b4a2EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord.FromStructureDelegate(config));
  } else {
AttrAutoplay = ssOutSystemsUI.RestRecords.RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord.FromStructure(s.ssENAutoplay, config);
  }
}

public static RC_c6831d06e579de4edbcf59e128b60b13 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_c6831d06e579de4edbcf59e128b60b13 obj) { 
  RC_c6831d06e579de4edbcf59e128b60b13 s = new RC_c6831d06e579de4edbcf59e128b60b13();
  if(obj != null) {
  s.ssENAutoplay = ssOutSystemsUI.RestRecords.RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord.ToStructure(obj.AttrAutoplay);
  }
  return s;
}

public static Func<RC_c6831d06e579de4edbcf59e128b60b13, ssOutSystemsUI.RestRecords.RESTRC_c6831d06e579de4edbcf59e128b60b13> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c6831d06e579de4edbcf59e128b60b13 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_c6831d06e579de4edbcf59e128b60b13 FromStructure(RC_c6831d06e579de4edbcf59e128b60b13 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_c6831d06e579de4edbcf59e128b60b13(s, config);
}

}


