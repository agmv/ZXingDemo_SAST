using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// DatePickerOptionalConfigsRecord
public class RESTRC_327e36bc408edd046ca40df8a4e734bb : AbstractRESTStructure<RC_327e36bc408edd046ca40df8a4e734bb> {
[JsonProperty("DatePickerOptionalConfigs")]
public ssZXingLibDemo.RestRecords.RESTST_bc4abb4233d9ce894e855c520a20c76fStructure AttrDatePickerOptionalConfigs;

public RESTRC_327e36bc408edd046ca40df8a4e734bb() { }

public RESTRC_327e36bc408edd046ca40df8a4e734bb (RC_327e36bc408edd046ca40df8a4e734bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDatePickerOptionalConfigs, new ST_bc4abb4233d9ce894e855c520a20c76fStructure(), ssZXingLibDemo.RestRecords.RESTST_bc4abb4233d9ce894e855c520a20c76fStructure.FromStructureDelegate(config));
  } else {
AttrDatePickerOptionalConfigs = ssZXingLibDemo.RestRecords.RESTST_bc4abb4233d9ce894e855c520a20c76fStructure.FromStructure(s.ssSTDatePickerOptionalConfigs, config);
  }
}

public static RC_327e36bc408edd046ca40df8a4e734bb ToStructure(ssZXingLibDemo.RestRecords.RESTRC_327e36bc408edd046ca40df8a4e734bb obj) { 
  RC_327e36bc408edd046ca40df8a4e734bb s = new RC_327e36bc408edd046ca40df8a4e734bb();
  if(obj != null) {
  s.ssSTDatePickerOptionalConfigs = ssZXingLibDemo.RestRecords.RESTST_bc4abb4233d9ce894e855c520a20c76fStructure.ToStructure(obj.AttrDatePickerOptionalConfigs);
  }
  return s;
}

public static Func<RC_327e36bc408edd046ca40df8a4e734bb, ssZXingLibDemo.RestRecords.RESTRC_327e36bc408edd046ca40df8a4e734bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_327e36bc408edd046ca40df8a4e734bb s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_327e36bc408edd046ca40df8a4e734bb FromStructure(RC_327e36bc408edd046ca40df8a4e734bb s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_327e36bc408edd046ca40df8a4e734bb(s, config);
}

}


