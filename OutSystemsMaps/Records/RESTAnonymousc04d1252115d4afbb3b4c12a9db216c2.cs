using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapErrorsRecord
public class RESTRC_3d151c63adf137bd3c85eaa462bbbe0c : AbstractRESTStructure<RC_3d151c63adf137bd3c85eaa462bbbe0c> {
[JsonProperty("MapErrors")]
public ssOutSystemsMaps.RestRecords.RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord AttrMapErrors;

public RESTRC_3d151c63adf137bd3c85eaa462bbbe0c() { }

public RESTRC_3d151c63adf137bd3c85eaa462bbbe0c (RC_3d151c63adf137bd3c85eaa462bbbe0c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMapErrors = ConvertToRestWithoutDefaults(s.ssENMapErrors, new EN_4d0e07d9538530f68924ab612d15f82bEntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord.FromStructureDelegate(config));
  } else {
AttrMapErrors = ssOutSystemsMaps.RestRecords.RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord.FromStructure(s.ssENMapErrors, config);
  }
}

public static RC_3d151c63adf137bd3c85eaa462bbbe0c ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_3d151c63adf137bd3c85eaa462bbbe0c obj) { 
  RC_3d151c63adf137bd3c85eaa462bbbe0c s = new RC_3d151c63adf137bd3c85eaa462bbbe0c();
  if(obj != null) {
  s.ssENMapErrors = ssOutSystemsMaps.RestRecords.RESTEN_4d0e07d9538530f68924ab612d15f82bEntityRecord.ToStructure(obj.AttrMapErrors);
  }
  return s;
}

public static Func<RC_3d151c63adf137bd3c85eaa462bbbe0c, ssOutSystemsMaps.RestRecords.RESTRC_3d151c63adf137bd3c85eaa462bbbe0c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3d151c63adf137bd3c85eaa462bbbe0c s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_3d151c63adf137bd3c85eaa462bbbe0c FromStructure(RC_3d151c63adf137bd3c85eaa462bbbe0c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_3d151c63adf137bd3c85eaa462bbbe0c(s, config);
}

}


