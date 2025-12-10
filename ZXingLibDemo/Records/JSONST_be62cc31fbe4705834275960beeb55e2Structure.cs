using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Offset
public class JSONST_be62cc31fbe4705834275960beeb55e2Structure : AbstractRESTStructure<ST_be62cc31fbe4705834275960beeb55e2Structure> {
[JsonProperty("offsetX")]
[JsonPropertyName("offsetX")]
public int? AttrOffsetX;

[JsonProperty("offsetY")]
[JsonPropertyName("offsetY")]
public int? AttrOffsetY;

public JSONST_be62cc31fbe4705834275960beeb55e2Structure() { }

public JSONST_be62cc31fbe4705834275960beeb55e2Structure (ST_be62cc31fbe4705834275960beeb55e2Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOffsetX = ConvertToRestWithoutDefaults(s.ssOffsetX, 0);
AttrOffsetY = ConvertToRestWithoutDefaults(s.ssOffsetY, 0);
  } else {
AttrOffsetX = (int?) s.ssOffsetX;
AttrOffsetY = (int?) s.ssOffsetY;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure, ST_be62cc31fbe4705834275960beeb55e2Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure s) => ToStructure(s, config);
}
public static ST_be62cc31fbe4705834275960beeb55e2Structure ToStructure(ssZXingLibDemo.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure obj, IBehaviorsConfiguration config) { 
  ST_be62cc31fbe4705834275960beeb55e2Structure s = new ST_be62cc31fbe4705834275960beeb55e2Structure();
  if(obj != null) {
  s.ssOffsetX = obj.AttrOffsetX == null ? 0 : obj.AttrOffsetX.Value;
  s.ssOffsetY = obj.AttrOffsetY == null ? 0 : obj.AttrOffsetY.Value;
  }
  return s;
}

public static Func<ST_be62cc31fbe4705834275960beeb55e2Structure, ssZXingLibDemo.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_be62cc31fbe4705834275960beeb55e2Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure FromStructure(ST_be62cc31fbe4705834275960beeb55e2Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure(s, config);
}

}


