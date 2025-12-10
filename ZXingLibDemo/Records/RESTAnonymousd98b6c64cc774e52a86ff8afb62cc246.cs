using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// CoordinatesRecord
public class RESTRC_e3355f6b7ba3051c4a4a9a00634d68d0 : AbstractRESTStructure<RC_e3355f6b7ba3051c4a4a9a00634d68d0> {
[JsonProperty("Coordinates")]
public ssZXingLibDemo.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure AttrCoordinates;

public RESTRC_e3355f6b7ba3051c4a4a9a00634d68d0() { }

public RESTRC_e3355f6b7ba3051c4a4a9a00634d68d0 (RC_e3355f6b7ba3051c4a4a9a00634d68d0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCoordinates = ConvertToRestWithoutDefaults(s.ssSTCoordinates, new ST_0e474756a4be14d378c73cd05f602bcdStructure(), ssZXingLibDemo.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructureDelegate(config));
  } else {
AttrCoordinates = ssZXingLibDemo.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructure(s.ssSTCoordinates, config);
  }
}

public static RC_e3355f6b7ba3051c4a4a9a00634d68d0 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_e3355f6b7ba3051c4a4a9a00634d68d0 obj) { 
  RC_e3355f6b7ba3051c4a4a9a00634d68d0 s = new RC_e3355f6b7ba3051c4a4a9a00634d68d0();
  if(obj != null) {
  s.ssSTCoordinates = ssZXingLibDemo.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.ToStructure(obj.AttrCoordinates);
  }
  return s;
}

public static Func<RC_e3355f6b7ba3051c4a4a9a00634d68d0, ssZXingLibDemo.RestRecords.RESTRC_e3355f6b7ba3051c4a4a9a00634d68d0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3355f6b7ba3051c4a4a9a00634d68d0 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_e3355f6b7ba3051c4a4a9a00634d68d0 FromStructure(RC_e3355f6b7ba3051c4a4a9a00634d68d0 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_e3355f6b7ba3051c4a4a9a00634d68d0(s, config);
}

}


