using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// LocalizationRecord
public class RESTRC_9b61cb371b118ff2b906c01399dcb602 : AbstractRESTStructure<RC_9b61cb371b118ff2b906c01399dcb602> {
[JsonProperty("Localization")]
public ssZXingLibDemo.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure AttrLocalization;

public RESTRC_9b61cb371b118ff2b906c01399dcb602() { }

public RESTRC_9b61cb371b118ff2b906c01399dcb602 (RC_9b61cb371b118ff2b906c01399dcb602 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLocalization = ConvertToRestWithoutDefaults(s.ssSTLocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssZXingLibDemo.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
  } else {
AttrLocalization = ssZXingLibDemo.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.ssSTLocalization, config);
  }
}

public static RC_9b61cb371b118ff2b906c01399dcb602 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_9b61cb371b118ff2b906c01399dcb602 obj) { 
  RC_9b61cb371b118ff2b906c01399dcb602 s = new RC_9b61cb371b118ff2b906c01399dcb602();
  if(obj != null) {
  s.ssSTLocalization = ssZXingLibDemo.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.AttrLocalization);
  }
  return s;
}

public static Func<RC_9b61cb371b118ff2b906c01399dcb602, ssZXingLibDemo.RestRecords.RESTRC_9b61cb371b118ff2b906c01399dcb602> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9b61cb371b118ff2b906c01399dcb602 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_9b61cb371b118ff2b906c01399dcb602 FromStructure(RC_9b61cb371b118ff2b906c01399dcb602 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_9b61cb371b118ff2b906c01399dcb602(s, config);
}

}


