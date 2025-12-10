using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionLegsRecord
public class JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee : AbstractRESTStructure<RC_ee9e4164abf6fbb75acecf37ce2b6aee> {
[JsonProperty("DirectionLegs")]
[JsonPropertyName("DirectionLegs")]
public ssOutSystemsMaps.RestRecords.JSONST_2c6551904cfa95c93fa24da37b55d320Structure AttrDirectionLegs;

public JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee() { }

public JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee (RC_ee9e4164abf6fbb75acecf37ce2b6aee s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectionLegs = ConvertToRestWithoutDefaults(s.ssSTDirectionLegs, new ST_2c6551904cfa95c93fa24da37b55d320Structure(), ssOutSystemsMaps.RestRecords.JSONST_2c6551904cfa95c93fa24da37b55d320Structure.FromStructureDelegate(config));
  } else {
AttrDirectionLegs = ssOutSystemsMaps.RestRecords.JSONST_2c6551904cfa95c93fa24da37b55d320Structure.FromStructure(s.ssSTDirectionLegs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee, RC_ee9e4164abf6fbb75acecf37ce2b6aee> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee s) => ToStructure(s, config);
}
public static RC_ee9e4164abf6fbb75acecf37ce2b6aee ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee obj, IBehaviorsConfiguration config) { 
  RC_ee9e4164abf6fbb75acecf37ce2b6aee s = new RC_ee9e4164abf6fbb75acecf37ce2b6aee();
  if(obj != null) {
  s.ssSTDirectionLegs = ssOutSystemsMaps.RestRecords.JSONST_2c6551904cfa95c93fa24da37b55d320Structure.ToStructure(obj.AttrDirectionLegs, config);
  }
  return s;
}

public static Func<RC_ee9e4164abf6fbb75acecf37ce2b6aee, ssOutSystemsMaps.RestRecords.JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ee9e4164abf6fbb75acecf37ce2b6aee s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee FromStructure(RC_ee9e4164abf6fbb75acecf37ce2b6aee s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_ee9e4164abf6fbb75acecf37ce2b6aee(s, config);
}

}


