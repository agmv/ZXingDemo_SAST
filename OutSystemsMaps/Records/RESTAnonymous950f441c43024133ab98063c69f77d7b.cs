using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerEventRecord
public class RESTRC_2d18bab1b72b271dc15dda249e871290 : AbstractRESTStructure<RC_2d18bab1b72b271dc15dda249e871290> {
[JsonProperty("MarkerEvent")]
public ssOutSystemsMaps.RestRecords.RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord AttrMarkerEvent;

public RESTRC_2d18bab1b72b271dc15dda249e871290() { }

public RESTRC_2d18bab1b72b271dc15dda249e871290 (RC_2d18bab1b72b271dc15dda249e871290 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarkerEvent = ConvertToRestWithoutDefaults(s.ssENMarkerEvent, new EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord.FromStructureDelegate(config));
  } else {
AttrMarkerEvent = ssOutSystemsMaps.RestRecords.RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord.FromStructure(s.ssENMarkerEvent, config);
  }
}

public static RC_2d18bab1b72b271dc15dda249e871290 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_2d18bab1b72b271dc15dda249e871290 obj) { 
  RC_2d18bab1b72b271dc15dda249e871290 s = new RC_2d18bab1b72b271dc15dda249e871290();
  if(obj != null) {
  s.ssENMarkerEvent = ssOutSystemsMaps.RestRecords.RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord.ToStructure(obj.AttrMarkerEvent);
  }
  return s;
}

public static Func<RC_2d18bab1b72b271dc15dda249e871290, ssOutSystemsMaps.RestRecords.RESTRC_2d18bab1b72b271dc15dda249e871290> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2d18bab1b72b271dc15dda249e871290 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_2d18bab1b72b271dc15dda249e871290 FromStructure(RC_2d18bab1b72b271dc15dda249e871290 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_2d18bab1b72b271dc15dda249e871290(s, config);
}

}


