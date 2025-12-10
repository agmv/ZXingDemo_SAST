using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ProviderRecord
public class RESTRC_21369035d43ec8805ca548830e8c3c98 : AbstractRESTStructure<RC_21369035d43ec8805ca548830e8c3c98> {
[JsonProperty("Provider")]
public ssOutSystemsMaps.RestRecords.RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord AttrProvider;

public RESTRC_21369035d43ec8805ca548830e8c3c98() { }

public RESTRC_21369035d43ec8805ca548830e8c3c98 (RC_21369035d43ec8805ca548830e8c3c98 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProvider = ConvertToRestWithoutDefaults(s.ssENProvider, new EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord.FromStructureDelegate(config));
  } else {
AttrProvider = ssOutSystemsMaps.RestRecords.RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord.FromStructure(s.ssENProvider, config);
  }
}

public static RC_21369035d43ec8805ca548830e8c3c98 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_21369035d43ec8805ca548830e8c3c98 obj) { 
  RC_21369035d43ec8805ca548830e8c3c98 s = new RC_21369035d43ec8805ca548830e8c3c98();
  if(obj != null) {
  s.ssENProvider = ssOutSystemsMaps.RestRecords.RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord.ToStructure(obj.AttrProvider);
  }
  return s;
}

public static Func<RC_21369035d43ec8805ca548830e8c3c98, ssOutSystemsMaps.RestRecords.RESTRC_21369035d43ec8805ca548830e8c3c98> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_21369035d43ec8805ca548830e8c3c98 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_21369035d43ec8805ca548830e8c3c98 FromStructure(RC_21369035d43ec8805ca548830e8c3c98 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_21369035d43ec8805ca548830e8c3c98(s, config);
}

}


