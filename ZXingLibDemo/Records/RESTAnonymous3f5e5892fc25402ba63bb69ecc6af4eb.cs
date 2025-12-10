using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// ContactRecord
public class RESTRC_53f0d7ad72d5d8edb7688d7ec561c618 : AbstractRESTStructure<RC_53f0d7ad72d5d8edb7688d7ec561c618> {
[JsonProperty("Contact")]
public ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure AttrContact;

public RESTRC_53f0d7ad72d5d8edb7688d7ec561c618() { }

public RESTRC_53f0d7ad72d5d8edb7688d7ec561c618 (RC_53f0d7ad72d5d8edb7688d7ec561c618 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContact = ConvertToRestWithoutDefaults(s.ssSTContact, new ST_10cb4adb0f851163080c748983a654c9Structure(), ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure.FromStructureDelegate(config));
  } else {
AttrContact = ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure.FromStructure(s.ssSTContact, config);
  }
}

public static RC_53f0d7ad72d5d8edb7688d7ec561c618 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_53f0d7ad72d5d8edb7688d7ec561c618 obj) { 
  RC_53f0d7ad72d5d8edb7688d7ec561c618 s = new RC_53f0d7ad72d5d8edb7688d7ec561c618();
  if(obj != null) {
  s.ssSTContact = ssZXingLibDemo.RestRecords.RESTST_10cb4adb0f851163080c748983a654c9Structure.ToStructure(obj.AttrContact);
  }
  return s;
}

public static Func<RC_53f0d7ad72d5d8edb7688d7ec561c618, ssZXingLibDemo.RestRecords.RESTRC_53f0d7ad72d5d8edb7688d7ec561c618> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53f0d7ad72d5d8edb7688d7ec561c618 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_53f0d7ad72d5d8edb7688d7ec561c618 FromStructure(RC_53f0d7ad72d5d8edb7688d7ec561c618 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_53f0d7ad72d5d8edb7688d7ec561c618(s, config);
}

}


