using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Coordinates
public class RESTST_0e474756a4be14d378c73cd05f602bcdStructure : AbstractRESTStructure<ST_0e474756a4be14d378c73cd05f602bcdStructure> {
[JsonProperty("Lat")]
public decimal? AttrLat;

[JsonProperty("Lng")]
public decimal? AttrLng;

public RESTST_0e474756a4be14d378c73cd05f602bcdStructure() { }

public RESTST_0e474756a4be14d378c73cd05f602bcdStructure (ST_0e474756a4be14d378c73cd05f602bcdStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLat = ConvertToRestWithoutDefaults(s.ssLat, 0.0M);
AttrLng = ConvertToRestWithoutDefaults(s.ssLng, 0.0M);
  } else {
AttrLat = (decimal?) s.ssLat;
AttrLng = (decimal?) s.ssLng;
  }
}

public static ST_0e474756a4be14d378c73cd05f602bcdStructure ToStructure(ssZXingLibDemo.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure obj) { 
  ST_0e474756a4be14d378c73cd05f602bcdStructure s = new ST_0e474756a4be14d378c73cd05f602bcdStructure();
  if(obj != null) {
  s.ssLat = obj.AttrLat == null ? 0.0M : obj.AttrLat.Value;
  s.ssLng = obj.AttrLng == null ? 0.0M : obj.AttrLng.Value;
  }
  return s;
}

public static Func<ST_0e474756a4be14d378c73cd05f602bcdStructure, ssZXingLibDemo.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0e474756a4be14d378c73cd05f602bcdStructure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure FromStructure(ST_0e474756a4be14d378c73cd05f602bcdStructure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure(s, config);
}

}


