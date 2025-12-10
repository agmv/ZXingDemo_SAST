using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// ContactRecord
public class JSONRC_53f0d7ad72d5d8edb7688d7ec561c618 : AbstractRESTStructure<RC_53f0d7ad72d5d8edb7688d7ec561c618> {
[JsonProperty("Contact")]
[JsonPropertyName("Contact")]
public ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure AttrContact;

public JSONRC_53f0d7ad72d5d8edb7688d7ec561c618() { }

public JSONRC_53f0d7ad72d5d8edb7688d7ec561c618 (RC_53f0d7ad72d5d8edb7688d7ec561c618 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContact = ConvertToRestWithoutDefaults(s.ssSTContact, new ST_10cb4adb0f851163080c748983a654c9Structure(), ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure.FromStructureDelegate(config));
  } else {
AttrContact = ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure.FromStructure(s.ssSTContact, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_53f0d7ad72d5d8edb7688d7ec561c618, RC_53f0d7ad72d5d8edb7688d7ec561c618> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_53f0d7ad72d5d8edb7688d7ec561c618 s) => ToStructure(s, config);
}
public static RC_53f0d7ad72d5d8edb7688d7ec561c618 ToStructure(ssZXingLibDemo.RestRecords.JSONRC_53f0d7ad72d5d8edb7688d7ec561c618 obj, IBehaviorsConfiguration config) { 
  RC_53f0d7ad72d5d8edb7688d7ec561c618 s = new RC_53f0d7ad72d5d8edb7688d7ec561c618();
  if(obj != null) {
  s.ssSTContact = ssZXingLibDemo.RestRecords.JSONST_10cb4adb0f851163080c748983a654c9Structure.ToStructure(obj.AttrContact, config);
  }
  return s;
}

public static Func<RC_53f0d7ad72d5d8edb7688d7ec561c618, ssZXingLibDemo.RestRecords.JSONRC_53f0d7ad72d5d8edb7688d7ec561c618> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53f0d7ad72d5d8edb7688d7ec561c618 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_53f0d7ad72d5d8edb7688d7ec561c618 FromStructure(RC_53f0d7ad72d5d8edb7688d7ec561c618 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_53f0d7ad72d5d8edb7688d7ec561c618(s, config);
}

}


