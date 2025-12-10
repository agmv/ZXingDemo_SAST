using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// IconSizeRecord
public class JSONRC_96c340f5ac620f54674641c63eb91876 : AbstractRESTStructure<RC_96c340f5ac620f54674641c63eb91876> {
[JsonProperty("IconSize")]
[JsonPropertyName("IconSize")]
public ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure AttrIconSize;

public JSONRC_96c340f5ac620f54674641c63eb91876() { }

public JSONRC_96c340f5ac620f54674641c63eb91876 (RC_96c340f5ac620f54674641c63eb91876 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIconSize = ConvertToRestWithoutDefaults(s.ssSTIconSize, new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure(), ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.FromStructureDelegate(config));
  } else {
AttrIconSize = ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.FromStructure(s.ssSTIconSize, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_96c340f5ac620f54674641c63eb91876, RC_96c340f5ac620f54674641c63eb91876> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_96c340f5ac620f54674641c63eb91876 s) => ToStructure(s, config);
}
public static RC_96c340f5ac620f54674641c63eb91876 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_96c340f5ac620f54674641c63eb91876 obj, IBehaviorsConfiguration config) { 
  RC_96c340f5ac620f54674641c63eb91876 s = new RC_96c340f5ac620f54674641c63eb91876();
  if(obj != null) {
  s.ssSTIconSize = ssOutSystemsMaps.RestRecords.JSONST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.ToStructure(obj.AttrIconSize, config);
  }
  return s;
}

public static Func<RC_96c340f5ac620f54674641c63eb91876, ssOutSystemsMaps.RestRecords.JSONRC_96c340f5ac620f54674641c63eb91876> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_96c340f5ac620f54674641c63eb91876 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_96c340f5ac620f54674641c63eb91876 FromStructure(RC_96c340f5ac620f54674641c63eb91876 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_96c340f5ac620f54674641c63eb91876(s, config);
}

}


