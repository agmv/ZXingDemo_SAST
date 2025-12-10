using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// CoordinatesRecord
public class JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0 : AbstractRESTStructure<RC_e3355f6b7ba3051c4a4a9a00634d68d0> {
[JsonProperty("Coordinates")]
[JsonPropertyName("Coordinates")]
public ssZXingLibDemo.RestRecords.JSONST_0e474756a4be14d378c73cd05f602bcdStructure AttrCoordinates;

public JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0() { }

public JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0 (RC_e3355f6b7ba3051c4a4a9a00634d68d0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCoordinates = ConvertToRestWithoutDefaults(s.ssSTCoordinates, new ST_0e474756a4be14d378c73cd05f602bcdStructure(), ssZXingLibDemo.RestRecords.JSONST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructureDelegate(config));
  } else {
AttrCoordinates = ssZXingLibDemo.RestRecords.JSONST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructure(s.ssSTCoordinates, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0, RC_e3355f6b7ba3051c4a4a9a00634d68d0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0 s) => ToStructure(s, config);
}
public static RC_e3355f6b7ba3051c4a4a9a00634d68d0 ToStructure(ssZXingLibDemo.RestRecords.JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0 obj, IBehaviorsConfiguration config) { 
  RC_e3355f6b7ba3051c4a4a9a00634d68d0 s = new RC_e3355f6b7ba3051c4a4a9a00634d68d0();
  if(obj != null) {
  s.ssSTCoordinates = ssZXingLibDemo.RestRecords.JSONST_0e474756a4be14d378c73cd05f602bcdStructure.ToStructure(obj.AttrCoordinates, config);
  }
  return s;
}

public static Func<RC_e3355f6b7ba3051c4a4a9a00634d68d0, ssZXingLibDemo.RestRecords.JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3355f6b7ba3051c4a4a9a00634d68d0 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0 FromStructure(RC_e3355f6b7ba3051c4a4a9a00634d68d0 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_e3355f6b7ba3051c4a4a9a00634d68d0(s, config);
}

}


