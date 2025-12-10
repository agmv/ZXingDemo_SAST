using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SpaceRecord
public class JSONRC_9589ecc0629788c2aca6b47bcbae782c : AbstractRESTStructure<RC_9589ecc0629788c2aca6b47bcbae782c> {
[JsonProperty("Space")]
[JsonPropertyName("Space")]
public ssOutSystemsUI.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord AttrSpace;

public JSONRC_9589ecc0629788c2aca6b47bcbae782c() { }

public JSONRC_9589ecc0629788c2aca6b47bcbae782c (RC_9589ecc0629788c2aca6b47bcbae782c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpace = ConvertToRestWithoutDefaults(s.ssENSpace, new EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.FromStructureDelegate(config));
  } else {
AttrSpace = ssOutSystemsUI.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.FromStructure(s.ssENSpace, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c, RC_9589ecc0629788c2aca6b47bcbae782c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c s) => ToStructure(s, config);
}
public static RC_9589ecc0629788c2aca6b47bcbae782c ToStructure(ssOutSystemsUI.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c obj, IBehaviorsConfiguration config) { 
  RC_9589ecc0629788c2aca6b47bcbae782c s = new RC_9589ecc0629788c2aca6b47bcbae782c();
  if(obj != null) {
  s.ssENSpace = ssOutSystemsUI.RestRecords.JSONEN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord.ToStructure(obj.AttrSpace, config);
  }
  return s;
}

public static Func<RC_9589ecc0629788c2aca6b47bcbae782c, ssOutSystemsUI.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9589ecc0629788c2aca6b47bcbae782c s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c FromStructure(RC_9589ecc0629788c2aca6b47bcbae782c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_9589ecc0629788c2aca6b47bcbae782c(s, config);
}

}


