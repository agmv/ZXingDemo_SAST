using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalStaticMapConfigs
public class RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure : AbstractRESTStructure<ST_b2c05afcf4810ad0d4384a01306bb0f3Structure> {
[JsonProperty("Zoom")]
public int? AttrZoom;

[JsonProperty("Type")]
public string AttrType;

[JsonProperty("Localization")]
public ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure AttrLocalization;

public RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure() { }

public RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure (ST_b2c05afcf4810ad0d4384a01306bb0f3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZoom = ConvertToRestWithoutDefaults(s.ssZoom, (ENZoomEntity.GetRecordByKey(ObjectKey.Parse("WLo5+5B9A0iAL7Ee_Ty8xQ"))).ssId);
AttrType = ConvertToRestWithoutDefaults(s.ssType, (ENTypeEntity.GetRecordByKey(ObjectKey.Parse("ovetaFeGuE6McBWDcnLLEg"))).ssMapType);
AttrLocalization = ConvertToRestWithoutDefaults(s.ssLocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
  } else {
AttrZoom = (int?) s.ssZoom;
AttrType = s.ssType;
AttrLocalization = ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.ssLocalization, config);
  }
}

public static ST_b2c05afcf4810ad0d4384a01306bb0f3Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure obj) { 
  ST_b2c05afcf4810ad0d4384a01306bb0f3Structure s = new ST_b2c05afcf4810ad0d4384a01306bb0f3Structure();
  if(obj != null) {
  s.ssZoom = obj.AttrZoom == null ? (ENZoomEntity.GetRecordByKey(ObjectKey.Parse("WLo5+5B9A0iAL7Ee_Ty8xQ"))).ssId : obj.AttrZoom.Value;
  s.ssType = obj.AttrType == null ? (ENTypeEntity.GetRecordByKey(ObjectKey.Parse("ovetaFeGuE6McBWDcnLLEg"))).ssMapType : obj.AttrType;
  s.ssLocalization = ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.AttrLocalization);
  }
  return s;
}

public static Func<ST_b2c05afcf4810ad0d4384a01306bb0f3Structure, ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b2c05afcf4810ad0d4384a01306bb0f3Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure FromStructure(ST_b2c05afcf4810ad0d4384a01306bb0f3Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure(s, config);
}

}


