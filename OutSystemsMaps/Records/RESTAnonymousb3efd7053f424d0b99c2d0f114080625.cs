using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// FileLayerEventRecord
public class RESTRC_dc7b093401bf134dc8399c003cfc6bc0 : AbstractRESTStructure<RC_dc7b093401bf134dc8399c003cfc6bc0> {
[JsonProperty("FileLayerEvent")]
public ssOutSystemsMaps.RestRecords.RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord AttrFileLayerEvent;

public RESTRC_dc7b093401bf134dc8399c003cfc6bc0() { }

public RESTRC_dc7b093401bf134dc8399c003cfc6bc0 (RC_dc7b093401bf134dc8399c003cfc6bc0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileLayerEvent = ConvertToRestWithoutDefaults(s.ssENFileLayerEvent, new EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord.FromStructureDelegate(config));
  } else {
AttrFileLayerEvent = ssOutSystemsMaps.RestRecords.RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord.FromStructure(s.ssENFileLayerEvent, config);
  }
}

public static RC_dc7b093401bf134dc8399c003cfc6bc0 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_dc7b093401bf134dc8399c003cfc6bc0 obj) { 
  RC_dc7b093401bf134dc8399c003cfc6bc0 s = new RC_dc7b093401bf134dc8399c003cfc6bc0();
  if(obj != null) {
  s.ssENFileLayerEvent = ssOutSystemsMaps.RestRecords.RESTEN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord.ToStructure(obj.AttrFileLayerEvent);
  }
  return s;
}

public static Func<RC_dc7b093401bf134dc8399c003cfc6bc0, ssOutSystemsMaps.RestRecords.RESTRC_dc7b093401bf134dc8399c003cfc6bc0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dc7b093401bf134dc8399c003cfc6bc0 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_dc7b093401bf134dc8399c003cfc6bc0 FromStructure(RC_dc7b093401bf134dc8399c003cfc6bc0 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_dc7b093401bf134dc8399c003cfc6bc0(s, config);
}

}


