using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// FillRecord
public class JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3 : AbstractRESTStructure<RC_1b25d6a078a2b54dc46acf86c7e61fc3> {
[JsonProperty("Fill")]
[JsonPropertyName("Fill")]
public ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure AttrFill;

public JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3() { }

public JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3 (RC_1b25d6a078a2b54dc46acf86c7e61fc3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFill = ConvertToRestWithoutDefaults(s.ssSTFill, new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure(), ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructureDelegate(config));
  } else {
AttrFill = ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructure(s.ssSTFill, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3, RC_1b25d6a078a2b54dc46acf86c7e61fc3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3 s) => ToStructure(s, config);
}
public static RC_1b25d6a078a2b54dc46acf86c7e61fc3 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3 obj, IBehaviorsConfiguration config) { 
  RC_1b25d6a078a2b54dc46acf86c7e61fc3 s = new RC_1b25d6a078a2b54dc46acf86c7e61fc3();
  if(obj != null) {
  s.ssSTFill = ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.ToStructure(obj.AttrFill, config);
  }
  return s;
}

public static Func<RC_1b25d6a078a2b54dc46acf86c7e61fc3, ssOutSystemsMaps.RestRecords.JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1b25d6a078a2b54dc46acf86c7e61fc3 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3 FromStructure(RC_1b25d6a078a2b54dc46acf86c7e61fc3 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_1b25d6a078a2b54dc46acf86c7e61fc3(s, config);
}

}


