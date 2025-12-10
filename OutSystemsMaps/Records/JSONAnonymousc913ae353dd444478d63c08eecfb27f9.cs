using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// AuthorRecord
public class JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a : AbstractRESTStructure<RC_6cdb4a5361f01d77ad1b8152ec45fc2a> {
[JsonProperty("Author")]
[JsonPropertyName("Author")]
public ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure AttrAuthor;

public JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a() { }

public JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a (RC_6cdb4a5361f01d77ad1b8152ec45fc2a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAuthor = ConvertToRestWithoutDefaults(s.ssSTAuthor, new ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure(), ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure.FromStructureDelegate(config));
  } else {
AttrAuthor = ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure.FromStructure(s.ssSTAuthor, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a, RC_6cdb4a5361f01d77ad1b8152ec45fc2a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a s) => ToStructure(s, config);
}
public static RC_6cdb4a5361f01d77ad1b8152ec45fc2a ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a obj, IBehaviorsConfiguration config) { 
  RC_6cdb4a5361f01d77ad1b8152ec45fc2a s = new RC_6cdb4a5361f01d77ad1b8152ec45fc2a();
  if(obj != null) {
  s.ssSTAuthor = ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure.ToStructure(obj.AttrAuthor, config);
  }
  return s;
}

public static Func<RC_6cdb4a5361f01d77ad1b8152ec45fc2a, ssOutSystemsMaps.RestRecords.JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6cdb4a5361f01d77ad1b8152ec45fc2a s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a FromStructure(RC_6cdb4a5361f01d77ad1b8152ec45fc2a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_6cdb4a5361f01d77ad1b8152ec45fc2a(s, config);
}

}


