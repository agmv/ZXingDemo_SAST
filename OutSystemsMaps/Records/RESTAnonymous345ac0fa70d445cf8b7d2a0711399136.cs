using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ExcludeCriteriaRecord
public class RESTRC_c81197f1ff862582a2342ed17a50f086 : AbstractRESTStructure<RC_c81197f1ff862582a2342ed17a50f086> {
[JsonProperty("ExcludeCriteria")]
public ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure AttrExcludeCriteria;

public RESTRC_c81197f1ff862582a2342ed17a50f086() { }

public RESTRC_c81197f1ff862582a2342ed17a50f086 (RC_c81197f1ff862582a2342ed17a50f086 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcludeCriteria = ConvertToRestWithoutDefaults(s.ssSTExcludeCriteria, new ST_78fd8c130caeaf241d821392d1010014Structure(), ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure.FromStructureDelegate(config));
  } else {
AttrExcludeCriteria = ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure.FromStructure(s.ssSTExcludeCriteria, config);
  }
}

public static RC_c81197f1ff862582a2342ed17a50f086 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_c81197f1ff862582a2342ed17a50f086 obj) { 
  RC_c81197f1ff862582a2342ed17a50f086 s = new RC_c81197f1ff862582a2342ed17a50f086();
  if(obj != null) {
  s.ssSTExcludeCriteria = ssOutSystemsMaps.RestRecords.RESTST_78fd8c130caeaf241d821392d1010014Structure.ToStructure(obj.AttrExcludeCriteria);
  }
  return s;
}

public static Func<RC_c81197f1ff862582a2342ed17a50f086, ssOutSystemsMaps.RestRecords.RESTRC_c81197f1ff862582a2342ed17a50f086> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c81197f1ff862582a2342ed17a50f086 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_c81197f1ff862582a2342ed17a50f086 FromStructure(RC_c81197f1ff862582a2342ed17a50f086 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_c81197f1ff862582a2342ed17a50f086(s, config);
}

}


