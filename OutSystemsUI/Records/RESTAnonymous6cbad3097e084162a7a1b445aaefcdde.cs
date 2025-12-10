using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// BooleanTypesRecord
public class RESTRC_1ea63146d7f1d969afc206832e751192 : AbstractRESTStructure<RC_1ea63146d7f1d969afc206832e751192> {
[JsonProperty("BooleanTypes")]
public ssOutSystemsUI.RestRecords.RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord AttrBooleanTypes;

public RESTRC_1ea63146d7f1d969afc206832e751192() { }

public RESTRC_1ea63146d7f1d969afc206832e751192 (RC_1ea63146d7f1d969afc206832e751192 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBooleanTypes = ConvertToRestWithoutDefaults(s.ssENBooleanTypes, new EN_1e2af88601c0491260411e1369eb104cEntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord.FromStructureDelegate(config));
  } else {
AttrBooleanTypes = ssOutSystemsUI.RestRecords.RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord.FromStructure(s.ssENBooleanTypes, config);
  }
}

public static RC_1ea63146d7f1d969afc206832e751192 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_1ea63146d7f1d969afc206832e751192 obj) { 
  RC_1ea63146d7f1d969afc206832e751192 s = new RC_1ea63146d7f1d969afc206832e751192();
  if(obj != null) {
  s.ssENBooleanTypes = ssOutSystemsUI.RestRecords.RESTEN_1e2af88601c0491260411e1369eb104cEntityRecord.ToStructure(obj.AttrBooleanTypes);
  }
  return s;
}

public static Func<RC_1ea63146d7f1d969afc206832e751192, ssOutSystemsUI.RestRecords.RESTRC_1ea63146d7f1d969afc206832e751192> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1ea63146d7f1d969afc206832e751192 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_1ea63146d7f1d969afc206832e751192 FromStructure(RC_1ea63146d7f1d969afc206832e751192 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_1ea63146d7f1d969afc206832e751192(s, config);
}

}


