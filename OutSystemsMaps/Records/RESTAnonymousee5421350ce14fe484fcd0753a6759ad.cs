using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DirectionLegsRecord
public class RESTRC_ee9e4164abf6fbb75acecf37ce2b6aee : AbstractRESTStructure<RC_ee9e4164abf6fbb75acecf37ce2b6aee> {
[JsonProperty("DirectionLegs")]
public ssOutSystemsMaps.RestRecords.RESTST_2c6551904cfa95c93fa24da37b55d320Structure AttrDirectionLegs;

public RESTRC_ee9e4164abf6fbb75acecf37ce2b6aee() { }

public RESTRC_ee9e4164abf6fbb75acecf37ce2b6aee (RC_ee9e4164abf6fbb75acecf37ce2b6aee s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectionLegs = ConvertToRestWithoutDefaults(s.ssSTDirectionLegs, new ST_2c6551904cfa95c93fa24da37b55d320Structure(), ssOutSystemsMaps.RestRecords.RESTST_2c6551904cfa95c93fa24da37b55d320Structure.FromStructureDelegate(config));
  } else {
AttrDirectionLegs = ssOutSystemsMaps.RestRecords.RESTST_2c6551904cfa95c93fa24da37b55d320Structure.FromStructure(s.ssSTDirectionLegs, config);
  }
}

public static RC_ee9e4164abf6fbb75acecf37ce2b6aee ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_ee9e4164abf6fbb75acecf37ce2b6aee obj) { 
  RC_ee9e4164abf6fbb75acecf37ce2b6aee s = new RC_ee9e4164abf6fbb75acecf37ce2b6aee();
  if(obj != null) {
  s.ssSTDirectionLegs = ssOutSystemsMaps.RestRecords.RESTST_2c6551904cfa95c93fa24da37b55d320Structure.ToStructure(obj.AttrDirectionLegs);
  }
  return s;
}

public static Func<RC_ee9e4164abf6fbb75acecf37ce2b6aee, ssOutSystemsMaps.RestRecords.RESTRC_ee9e4164abf6fbb75acecf37ce2b6aee> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ee9e4164abf6fbb75acecf37ce2b6aee s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_ee9e4164abf6fbb75acecf37ce2b6aee FromStructure(RC_ee9e4164abf6fbb75acecf37ce2b6aee s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_ee9e4164abf6fbb75acecf37ce2b6aee(s, config);
}

}


