using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// FeatureDataRecord
public class RESTRC_2fa6ec01db1a6b09e6b59fa237f21deb : AbstractRESTStructure<RC_2fa6ec01db1a6b09e6b59fa237f21deb> {
[JsonProperty("FeatureData")]
public ssOutSystemsMaps.RestRecords.RESTST_87d89cf32a40d309845674355a1bd4e1Structure AttrFeatureData;

public RESTRC_2fa6ec01db1a6b09e6b59fa237f21deb() { }

public RESTRC_2fa6ec01db1a6b09e6b59fa237f21deb (RC_2fa6ec01db1a6b09e6b59fa237f21deb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFeatureData = ConvertToRestWithoutDefaults(s.ssSTFeatureData, new ST_87d89cf32a40d309845674355a1bd4e1Structure(), ssOutSystemsMaps.RestRecords.RESTST_87d89cf32a40d309845674355a1bd4e1Structure.FromStructureDelegate(config));
  } else {
AttrFeatureData = ssOutSystemsMaps.RestRecords.RESTST_87d89cf32a40d309845674355a1bd4e1Structure.FromStructure(s.ssSTFeatureData, config);
  }
}

public static RC_2fa6ec01db1a6b09e6b59fa237f21deb ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_2fa6ec01db1a6b09e6b59fa237f21deb obj) { 
  RC_2fa6ec01db1a6b09e6b59fa237f21deb s = new RC_2fa6ec01db1a6b09e6b59fa237f21deb();
  if(obj != null) {
  s.ssSTFeatureData = ssOutSystemsMaps.RestRecords.RESTST_87d89cf32a40d309845674355a1bd4e1Structure.ToStructure(obj.AttrFeatureData);
  }
  return s;
}

public static Func<RC_2fa6ec01db1a6b09e6b59fa237f21deb, ssOutSystemsMaps.RestRecords.RESTRC_2fa6ec01db1a6b09e6b59fa237f21deb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2fa6ec01db1a6b09e6b59fa237f21deb s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_2fa6ec01db1a6b09e6b59fa237f21deb FromStructure(RC_2fa6ec01db1a6b09e6b59fa237f21deb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_2fa6ec01db1a6b09e6b59fa237f21deb(s, config);
}

}


