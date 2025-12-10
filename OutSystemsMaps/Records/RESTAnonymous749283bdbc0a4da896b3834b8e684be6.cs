using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// FillRecord
public class RESTRC_1b25d6a078a2b54dc46acf86c7e61fc3 : AbstractRESTStructure<RC_1b25d6a078a2b54dc46acf86c7e61fc3> {
[JsonProperty("Fill")]
public ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure AttrFill;

public RESTRC_1b25d6a078a2b54dc46acf86c7e61fc3() { }

public RESTRC_1b25d6a078a2b54dc46acf86c7e61fc3 (RC_1b25d6a078a2b54dc46acf86c7e61fc3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFill = ConvertToRestWithoutDefaults(s.ssSTFill, new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure(), ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructureDelegate(config));
  } else {
AttrFill = ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructure(s.ssSTFill, config);
  }
}

public static RC_1b25d6a078a2b54dc46acf86c7e61fc3 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_1b25d6a078a2b54dc46acf86c7e61fc3 obj) { 
  RC_1b25d6a078a2b54dc46acf86c7e61fc3 s = new RC_1b25d6a078a2b54dc46acf86c7e61fc3();
  if(obj != null) {
  s.ssSTFill = ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.ToStructure(obj.AttrFill);
  }
  return s;
}

public static Func<RC_1b25d6a078a2b54dc46acf86c7e61fc3, ssOutSystemsMaps.RestRecords.RESTRC_1b25d6a078a2b54dc46acf86c7e61fc3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1b25d6a078a2b54dc46acf86c7e61fc3 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_1b25d6a078a2b54dc46acf86c7e61fc3 FromStructure(RC_1b25d6a078a2b54dc46acf86c7e61fc3 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_1b25d6a078a2b54dc46acf86c7e61fc3(s, config);
}

}


