using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerEventRecord
public class JSONRC_2d18bab1b72b271dc15dda249e871290 : AbstractRESTStructure<RC_2d18bab1b72b271dc15dda249e871290> {
[JsonProperty("MarkerEvent")]
[JsonPropertyName("MarkerEvent")]
public ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord AttrMarkerEvent;

public JSONRC_2d18bab1b72b271dc15dda249e871290() { }

public JSONRC_2d18bab1b72b271dc15dda249e871290 (RC_2d18bab1b72b271dc15dda249e871290 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarkerEvent = ConvertToRestWithoutDefaults(s.ssENMarkerEvent, new EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord.FromStructureDelegate(config));
  } else {
AttrMarkerEvent = ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord.FromStructure(s.ssENMarkerEvent, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_2d18bab1b72b271dc15dda249e871290, RC_2d18bab1b72b271dc15dda249e871290> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_2d18bab1b72b271dc15dda249e871290 s) => ToStructure(s, config);
}
public static RC_2d18bab1b72b271dc15dda249e871290 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_2d18bab1b72b271dc15dda249e871290 obj, IBehaviorsConfiguration config) { 
  RC_2d18bab1b72b271dc15dda249e871290 s = new RC_2d18bab1b72b271dc15dda249e871290();
  if(obj != null) {
  s.ssENMarkerEvent = ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord.ToStructure(obj.AttrMarkerEvent, config);
  }
  return s;
}

public static Func<RC_2d18bab1b72b271dc15dda249e871290, ssOutSystemsMaps.RestRecords.JSONRC_2d18bab1b72b271dc15dda249e871290> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2d18bab1b72b271dc15dda249e871290 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_2d18bab1b72b271dc15dda249e871290 FromStructure(RC_2d18bab1b72b271dc15dda249e871290 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_2d18bab1b72b271dc15dda249e871290(s, config);
}

}


