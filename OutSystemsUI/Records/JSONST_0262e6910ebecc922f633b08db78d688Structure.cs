using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DeviceConfiguration
public class JSONST_0262e6910ebecc922f633b08db78d688Structure : AbstractRESTStructure<ST_0262e6910ebecc922f633b08db78d688Structure> {
[JsonProperty("PhoneWidth")]
[JsonPropertyName("PhoneWidth")]
public int? AttrPhoneWidth;

[JsonProperty("TabletWidth")]
[JsonPropertyName("TabletWidth")]
public int? AttrTabletWidth;

public JSONST_0262e6910ebecc922f633b08db78d688Structure() { }

public JSONST_0262e6910ebecc922f633b08db78d688Structure (ST_0262e6910ebecc922f633b08db78d688Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPhoneWidth = ConvertToRestWithoutDefaults(s.ssPhoneWidth, 767);
AttrTabletWidth = ConvertToRestWithoutDefaults(s.ssTabletWidth, 1024);
  } else {
AttrPhoneWidth = (int?) s.ssPhoneWidth;
AttrTabletWidth = (int?) s.ssTabletWidth;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure, ST_0262e6910ebecc922f633b08db78d688Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure s) => ToStructure(s, config);
}
public static ST_0262e6910ebecc922f633b08db78d688Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure obj, IBehaviorsConfiguration config) { 
  ST_0262e6910ebecc922f633b08db78d688Structure s = new ST_0262e6910ebecc922f633b08db78d688Structure();
  if(obj != null) {
  s.ssPhoneWidth = obj.AttrPhoneWidth == null ? 767 : obj.AttrPhoneWidth.Value;
  s.ssTabletWidth = obj.AttrTabletWidth == null ? 1024 : obj.AttrTabletWidth.Value;
  }
  return s;
}

public static Func<ST_0262e6910ebecc922f633b08db78d688Structure, ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0262e6910ebecc922f633b08db78d688Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure FromStructure(ST_0262e6910ebecc922f633b08db78d688Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_0262e6910ebecc922f633b08db78d688Structure(s, config);
}

}


