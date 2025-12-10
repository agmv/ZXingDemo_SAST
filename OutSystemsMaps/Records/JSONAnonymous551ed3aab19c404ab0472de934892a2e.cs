using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// VerbosityRecord
public class JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39 : AbstractRESTStructure<RC_a9d171af5978fe3e4b7ef9f38c0c5a39> {
[JsonProperty("Verbosity")]
[JsonPropertyName("Verbosity")]
public ssOutSystemsMaps.RestRecords.JSONEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord AttrVerbosity;

public JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39() { }

public JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39 (RC_a9d171af5978fe3e4b7ef9f38c0c5a39 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVerbosity = ConvertToRestWithoutDefaults(s.ssENVerbosity, new EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord.FromStructureDelegate(config));
  } else {
AttrVerbosity = ssOutSystemsMaps.RestRecords.JSONEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord.FromStructure(s.ssENVerbosity, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39, RC_a9d171af5978fe3e4b7ef9f38c0c5a39> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39 s) => ToStructure(s, config);
}
public static RC_a9d171af5978fe3e4b7ef9f38c0c5a39 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39 obj, IBehaviorsConfiguration config) { 
  RC_a9d171af5978fe3e4b7ef9f38c0c5a39 s = new RC_a9d171af5978fe3e4b7ef9f38c0c5a39();
  if(obj != null) {
  s.ssENVerbosity = ssOutSystemsMaps.RestRecords.JSONEN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord.ToStructure(obj.AttrVerbosity, config);
  }
  return s;
}

public static Func<RC_a9d171af5978fe3e4b7ef9f38c0c5a39, ssOutSystemsMaps.RestRecords.JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a9d171af5978fe3e4b7ef9f38c0c5a39 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39 FromStructure(RC_a9d171af5978fe3e4b7ef9f38c0c5a39 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_a9d171af5978fe3e4b7ef9f38c0c5a39(s, config);
}

}


