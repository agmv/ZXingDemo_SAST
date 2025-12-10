using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_FileLayer_ConfigsRecord
public class RESTRC_0cc9882276464f8a42abc2516db92c70 : AbstractRESTStructure<RC_0cc9882276464f8a42abc2516db92c70> {
[JsonProperty("Internal_FileLayer_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure AttrInternal_FileLayer_Configs;

public RESTRC_0cc9882276464f8a42abc2516db92c70() { }

public RESTRC_0cc9882276464f8a42abc2516db92c70 (RC_0cc9882276464f8a42abc2516db92c70 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_FileLayer_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_FileLayer_Configs, new ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure(), ssOutSystemsMaps.RestRecords.RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure.FromStructureDelegate(config));
  } else {
AttrInternal_FileLayer_Configs = ssOutSystemsMaps.RestRecords.RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure.FromStructure(s.ssSTInternal_FileLayer_Configs, config);
  }
}

public static RC_0cc9882276464f8a42abc2516db92c70 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_0cc9882276464f8a42abc2516db92c70 obj) { 
  RC_0cc9882276464f8a42abc2516db92c70 s = new RC_0cc9882276464f8a42abc2516db92c70();
  if(obj != null) {
  s.ssSTInternal_FileLayer_Configs = ssOutSystemsMaps.RestRecords.RESTST_1a3d048e7bc3b165cd3ddc45ef640b18Structure.ToStructure(obj.AttrInternal_FileLayer_Configs);
  }
  return s;
}

public static Func<RC_0cc9882276464f8a42abc2516db92c70, ssOutSystemsMaps.RestRecords.RESTRC_0cc9882276464f8a42abc2516db92c70> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0cc9882276464f8a42abc2516db92c70 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_0cc9882276464f8a42abc2516db92c70 FromStructure(RC_0cc9882276464f8a42abc2516db92c70 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_0cc9882276464f8a42abc2516db92c70(s, config);
}

}


