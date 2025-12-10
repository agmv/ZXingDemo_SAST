using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DeviceConfigurationRecord
public class JSONRC_abb6a3eba8583e4ab0625de8f38fb719 : AbstractRESTStructure<RC_abb6a3eba8583e4ab0625de8f38fb719> {
[JsonProperty("DeviceConfiguration")]
[JsonPropertyName("DeviceConfiguration")]
public ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure AttrDeviceConfiguration;

public JSONRC_abb6a3eba8583e4ab0625de8f38fb719() { }

public JSONRC_abb6a3eba8583e4ab0625de8f38fb719 (RC_abb6a3eba8583e4ab0625de8f38fb719 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDeviceConfiguration = ConvertToRestWithoutDefaults(s.ssSTDeviceConfiguration, new ST_0262e6910ebecc922f633b08db78d688Structure(), ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure.FromStructureDelegate(config));
  } else {
AttrDeviceConfiguration = ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure.FromStructure(s.ssSTDeviceConfiguration, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_abb6a3eba8583e4ab0625de8f38fb719, RC_abb6a3eba8583e4ab0625de8f38fb719> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_abb6a3eba8583e4ab0625de8f38fb719 s) => ToStructure(s, config);
}
public static RC_abb6a3eba8583e4ab0625de8f38fb719 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_abb6a3eba8583e4ab0625de8f38fb719 obj, IBehaviorsConfiguration config) { 
  RC_abb6a3eba8583e4ab0625de8f38fb719 s = new RC_abb6a3eba8583e4ab0625de8f38fb719();
  if(obj != null) {
  s.ssSTDeviceConfiguration = ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure.ToStructure(obj.AttrDeviceConfiguration, config);
  }
  return s;
}

public static Func<RC_abb6a3eba8583e4ab0625de8f38fb719, ssOutSystemsUI.RestRecords.JSONRC_abb6a3eba8583e4ab0625de8f38fb719> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_abb6a3eba8583e4ab0625de8f38fb719 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_abb6a3eba8583e4ab0625de8f38fb719 FromStructure(RC_abb6a3eba8583e4ab0625de8f38fb719 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_abb6a3eba8583e4ab0625de8f38fb719(s, config);
}

}


