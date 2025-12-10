using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// CodeDefaultsRecord
public class RESTRC_8acf1c157094e2761d62d068555c0d1c : AbstractRESTStructure<RC_8acf1c157094e2761d62d068555c0d1c> {
[JsonProperty("CodeDefaults")]
public ssZXingLibDemo.RestRecords.RESTEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord AttrCodeDefaults;

public RESTRC_8acf1c157094e2761d62d068555c0d1c() { }

public RESTRC_8acf1c157094e2761d62d068555c0d1c (RC_8acf1c157094e2761d62d068555c0d1c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCodeDefaults = ConvertToRestWithoutDefaults(s.ssENCodeDefaults, new EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord(), ssZXingLibDemo.RestRecords.RESTEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.FromStructureDelegate(config));
  } else {
AttrCodeDefaults = ssZXingLibDemo.RestRecords.RESTEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.FromStructure(s.ssENCodeDefaults, config);
  }
}

public static RC_8acf1c157094e2761d62d068555c0d1c ToStructure(ssZXingLibDemo.RestRecords.RESTRC_8acf1c157094e2761d62d068555c0d1c obj) { 
  RC_8acf1c157094e2761d62d068555c0d1c s = new RC_8acf1c157094e2761d62d068555c0d1c();
  if(obj != null) {
  s.ssENCodeDefaults = ssZXingLibDemo.RestRecords.RESTEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.ToStructure(obj.AttrCodeDefaults);
  }
  return s;
}

public static Func<RC_8acf1c157094e2761d62d068555c0d1c, ssZXingLibDemo.RestRecords.RESTRC_8acf1c157094e2761d62d068555c0d1c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8acf1c157094e2761d62d068555c0d1c s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_8acf1c157094e2761d62d068555c0d1c FromStructure(RC_8acf1c157094e2761d62d068555c0d1c s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_8acf1c157094e2761d62d068555c0d1c(s, config);
}

}


