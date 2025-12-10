using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DeviceConfiguration
public class RESTST_0262e6910ebecc922f633b08db78d688Structure : AbstractRESTStructure<ST_0262e6910ebecc922f633b08db78d688Structure> {
[JsonProperty("PhoneWidth")]
public int? AttrPhoneWidth;

[JsonProperty("TabletWidth")]
public int? AttrTabletWidth;

public RESTST_0262e6910ebecc922f633b08db78d688Structure() { }

public RESTST_0262e6910ebecc922f633b08db78d688Structure (ST_0262e6910ebecc922f633b08db78d688Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPhoneWidth = ConvertToRestWithoutDefaults(s.ssPhoneWidth, 767);
AttrTabletWidth = ConvertToRestWithoutDefaults(s.ssTabletWidth, 1024);
  } else {
AttrPhoneWidth = (int?) s.ssPhoneWidth;
AttrTabletWidth = (int?) s.ssTabletWidth;
  }
}

public static ST_0262e6910ebecc922f633b08db78d688Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_0262e6910ebecc922f633b08db78d688Structure obj) { 
  ST_0262e6910ebecc922f633b08db78d688Structure s = new ST_0262e6910ebecc922f633b08db78d688Structure();
  if(obj != null) {
  s.ssPhoneWidth = obj.AttrPhoneWidth == null ? 767 : obj.AttrPhoneWidth.Value;
  s.ssTabletWidth = obj.AttrTabletWidth == null ? 1024 : obj.AttrTabletWidth.Value;
  }
  return s;
}

public static Func<ST_0262e6910ebecc922f633b08db78d688Structure, ssOutSystemsUI.RestRecords.RESTST_0262e6910ebecc922f633b08db78d688Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0262e6910ebecc922f633b08db78d688Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_0262e6910ebecc922f633b08db78d688Structure FromStructure(ST_0262e6910ebecc922f633b08db78d688Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_0262e6910ebecc922f633b08db78d688Structure(s, config);
}

}


