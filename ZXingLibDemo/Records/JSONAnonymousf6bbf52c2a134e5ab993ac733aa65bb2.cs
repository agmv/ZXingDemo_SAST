using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// LocalizationRecord
public class JSONRC_9b61cb371b118ff2b906c01399dcb602 : AbstractRESTStructure<RC_9b61cb371b118ff2b906c01399dcb602> {
[JsonProperty("Localization")]
[JsonPropertyName("Localization")]
public ssZXingLibDemo.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure AttrLocalization;

public JSONRC_9b61cb371b118ff2b906c01399dcb602() { }

public JSONRC_9b61cb371b118ff2b906c01399dcb602 (RC_9b61cb371b118ff2b906c01399dcb602 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLocalization = ConvertToRestWithoutDefaults(s.ssSTLocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssZXingLibDemo.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
  } else {
AttrLocalization = ssZXingLibDemo.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.ssSTLocalization, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_9b61cb371b118ff2b906c01399dcb602, RC_9b61cb371b118ff2b906c01399dcb602> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_9b61cb371b118ff2b906c01399dcb602 s) => ToStructure(s, config);
}
public static RC_9b61cb371b118ff2b906c01399dcb602 ToStructure(ssZXingLibDemo.RestRecords.JSONRC_9b61cb371b118ff2b906c01399dcb602 obj, IBehaviorsConfiguration config) { 
  RC_9b61cb371b118ff2b906c01399dcb602 s = new RC_9b61cb371b118ff2b906c01399dcb602();
  if(obj != null) {
  s.ssSTLocalization = ssZXingLibDemo.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.AttrLocalization, config);
  }
  return s;
}

public static Func<RC_9b61cb371b118ff2b906c01399dcb602, ssZXingLibDemo.RestRecords.JSONRC_9b61cb371b118ff2b906c01399dcb602> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9b61cb371b118ff2b906c01399dcb602 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_9b61cb371b118ff2b906c01399dcb602 FromStructure(RC_9b61cb371b118ff2b906c01399dcb602 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_9b61cb371b118ff2b906c01399dcb602(s, config);
}

}


