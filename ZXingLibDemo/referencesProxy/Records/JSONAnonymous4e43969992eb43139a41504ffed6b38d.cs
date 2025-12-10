using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// DatePickerOptionalConfigsRecord
public class JSONRC_327e36bc408edd046ca40df8a4e734bb : AbstractRESTStructure<RC_327e36bc408edd046ca40df8a4e734bb> {
[JsonProperty("DatePickerOptionalConfigs")]
[JsonPropertyName("DatePickerOptionalConfigs")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_bc4abb4233d9ce894e855c520a20c76fStructure AttrDatePickerOptionalConfigs;

public JSONRC_327e36bc408edd046ca40df8a4e734bb() { }

public JSONRC_327e36bc408edd046ca40df8a4e734bb (RC_327e36bc408edd046ca40df8a4e734bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDatePickerOptionalConfigs, new ST_bc4abb4233d9ce894e855c520a20c76fStructure(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_bc4abb4233d9ce894e855c520a20c76fStructure.FromStructureDelegate(config));
  } else {
AttrDatePickerOptionalConfigs = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_bc4abb4233d9ce894e855c520a20c76fStructure.FromStructure(s.ssSTDatePickerOptionalConfigs, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_327e36bc408edd046ca40df8a4e734bb, RC_327e36bc408edd046ca40df8a4e734bb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_327e36bc408edd046ca40df8a4e734bb s) => ToStructure(s, config);
}
public static RC_327e36bc408edd046ca40df8a4e734bb ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_327e36bc408edd046ca40df8a4e734bb obj, IBehaviorsConfiguration config) { 
  RC_327e36bc408edd046ca40df8a4e734bb s = new RC_327e36bc408edd046ca40df8a4e734bb();
  if(obj != null) {
  s.ssSTDatePickerOptionalConfigs = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_bc4abb4233d9ce894e855c520a20c76fStructure.ToStructure(obj.AttrDatePickerOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_327e36bc408edd046ca40df8a4e734bb, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_327e36bc408edd046ca40df8a4e734bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_327e36bc408edd046ca40df8a4e734bb s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_327e36bc408edd046ca40df8a4e734bb FromStructure(RC_327e36bc408edd046ca40df8a4e734bb s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_327e36bc408edd046ca40df8a4e734bb(s, config);
}

}


