using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DeviceResponsiveRecord
public class RESTRC_1583be5d90a94b6a73170ffa868eecc5 : AbstractRESTStructure<RC_1583be5d90a94b6a73170ffa868eecc5> {
[JsonProperty("DeviceResponsive")]
public ssOutSystemsUI.RestRecords.RESTEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord AttrDeviceResponsive;

public RESTRC_1583be5d90a94b6a73170ffa868eecc5() { }

public RESTRC_1583be5d90a94b6a73170ffa868eecc5 (RC_1583be5d90a94b6a73170ffa868eecc5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDeviceResponsive = ConvertToRestWithoutDefaults(s.ssENDeviceResponsive, new EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord.FromStructureDelegate(config));
  } else {
AttrDeviceResponsive = ssOutSystemsUI.RestRecords.RESTEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord.FromStructure(s.ssENDeviceResponsive, config);
  }
}

public static RC_1583be5d90a94b6a73170ffa868eecc5 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_1583be5d90a94b6a73170ffa868eecc5 obj) { 
  RC_1583be5d90a94b6a73170ffa868eecc5 s = new RC_1583be5d90a94b6a73170ffa868eecc5();
  if(obj != null) {
  s.ssENDeviceResponsive = ssOutSystemsUI.RestRecords.RESTEN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord.ToStructure(obj.AttrDeviceResponsive);
  }
  return s;
}

public static Func<RC_1583be5d90a94b6a73170ffa868eecc5, ssOutSystemsUI.RestRecords.RESTRC_1583be5d90a94b6a73170ffa868eecc5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1583be5d90a94b6a73170ffa868eecc5 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_1583be5d90a94b6a73170ffa868eecc5 FromStructure(RC_1583be5d90a94b6a73170ffa868eecc5 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_1583be5d90a94b6a73170ffa868eecc5(s, config);
}

}


