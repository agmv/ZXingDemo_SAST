using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// CodeDefaultsRecord
public class JSONRC_8acf1c157094e2761d62d068555c0d1c : AbstractRESTStructure<RC_8acf1c157094e2761d62d068555c0d1c> {
[JsonProperty("CodeDefaults")]
[JsonPropertyName("CodeDefaults")]
public ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord AttrCodeDefaults;

public JSONRC_8acf1c157094e2761d62d068555c0d1c() { }

public JSONRC_8acf1c157094e2761d62d068555c0d1c (RC_8acf1c157094e2761d62d068555c0d1c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCodeDefaults = ConvertToRestWithoutDefaults(s.ssENCodeDefaults, new EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord(), ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.FromStructureDelegate(config));
  } else {
AttrCodeDefaults = ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.FromStructure(s.ssENCodeDefaults, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_8acf1c157094e2761d62d068555c0d1c, RC_8acf1c157094e2761d62d068555c0d1c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_8acf1c157094e2761d62d068555c0d1c s) => ToStructure(s, config);
}
public static RC_8acf1c157094e2761d62d068555c0d1c ToStructure(ssZXingLibDemo.RestRecords.JSONRC_8acf1c157094e2761d62d068555c0d1c obj, IBehaviorsConfiguration config) { 
  RC_8acf1c157094e2761d62d068555c0d1c s = new RC_8acf1c157094e2761d62d068555c0d1c();
  if(obj != null) {
  s.ssENCodeDefaults = ssZXingLibDemo.RestRecords.JSONEN_8e4f4aeefdfc6896f169ba6182857006EntityRecord.ToStructure(obj.AttrCodeDefaults, config);
  }
  return s;
}

public static Func<RC_8acf1c157094e2761d62d068555c0d1c, ssZXingLibDemo.RestRecords.JSONRC_8acf1c157094e2761d62d068555c0d1c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8acf1c157094e2761d62d068555c0d1c s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_8acf1c157094e2761d62d068555c0d1c FromStructure(RC_8acf1c157094e2761d62d068555c0d1c s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_8acf1c157094e2761d62d068555c0d1c(s, config);
}

}


