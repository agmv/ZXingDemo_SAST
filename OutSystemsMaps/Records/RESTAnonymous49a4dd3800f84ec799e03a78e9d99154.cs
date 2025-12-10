using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Private_MarkerClustererRecord
public class RESTRC_7848ef17b87824c24f6e707b82dac222 : AbstractRESTStructure<RC_7848ef17b87824c24f6e707b82dac222> {
[JsonProperty("Private_MarkerClusterer")]
public ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure AttrPrivate_MarkerClusterer;

public RESTRC_7848ef17b87824c24f6e707b82dac222() { }

public RESTRC_7848ef17b87824c24f6e707b82dac222 (RC_7848ef17b87824c24f6e707b82dac222 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPrivate_MarkerClusterer = ConvertToRestWithoutDefaults(s.ssSTPrivate_MarkerClusterer, new ST_9f8ac95fe4e47e327de12de1b56bed45Structure(), ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure.FromStructureDelegate(config));
  } else {
AttrPrivate_MarkerClusterer = ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure.FromStructure(s.ssSTPrivate_MarkerClusterer, config);
  }
}

public static RC_7848ef17b87824c24f6e707b82dac222 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_7848ef17b87824c24f6e707b82dac222 obj) { 
  RC_7848ef17b87824c24f6e707b82dac222 s = new RC_7848ef17b87824c24f6e707b82dac222();
  if(obj != null) {
  s.ssSTPrivate_MarkerClusterer = ssOutSystemsMaps.RestRecords.RESTST_9f8ac95fe4e47e327de12de1b56bed45Structure.ToStructure(obj.AttrPrivate_MarkerClusterer);
  }
  return s;
}

public static Func<RC_7848ef17b87824c24f6e707b82dac222, ssOutSystemsMaps.RestRecords.RESTRC_7848ef17b87824c24f6e707b82dac222> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7848ef17b87824c24f6e707b82dac222 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_7848ef17b87824c24f6e707b82dac222 FromStructure(RC_7848ef17b87824c24f6e707b82dac222 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_7848ef17b87824c24f6e707b82dac222(s, config);
}

}


