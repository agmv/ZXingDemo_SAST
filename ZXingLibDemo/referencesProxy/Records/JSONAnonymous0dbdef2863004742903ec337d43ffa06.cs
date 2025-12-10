using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// OrientationRecord
public class JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 : AbstractRESTStructure<RC_3ba1d238c8e0f0c3e875fb37f0381cc6> {
[JsonProperty("Orientation")]
[JsonPropertyName("Orientation")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord AttrOrientation;

public JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6() { }

public JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 (RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrientation = ConvertToRestWithoutDefaults(s.ssENOrientation, new EN_8d4f783227026ce93d50126c7f028443EntityRecord(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord.FromStructureDelegate(config));
  } else {
AttrOrientation = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord.FromStructure(s.ssENOrientation, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6, RC_3ba1d238c8e0f0c3e875fb37f0381cc6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 s) => ToStructure(s, config);
}
public static RC_3ba1d238c8e0f0c3e875fb37f0381cc6 ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 obj, IBehaviorsConfiguration config) { 
  RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s = new RC_3ba1d238c8e0f0c3e875fb37f0381cc6();
  if(obj != null) {
  s.ssENOrientation = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord.ToStructure(obj.AttrOrientation, config);
  }
  return s;
}

public static Func<RC_3ba1d238c8e0f0c3e875fb37f0381cc6, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6 FromStructure(RC_3ba1d238c8e0f0c3e875fb37f0381cc6 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_3ba1d238c8e0f0c3e875fb37f0381cc6(s, config);
}

}


