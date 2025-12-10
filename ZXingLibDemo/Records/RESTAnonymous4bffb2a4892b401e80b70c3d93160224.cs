using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// MetadataRecord
public class RESTRC_7ef51ad4bf41859d359e0a9b0b3ca1b5 : AbstractRESTStructure<RC_7ef51ad4bf41859d359e0a9b0b3ca1b5> {
[JsonProperty("Metadata")]
public ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure AttrMetadata;

public RESTRC_7ef51ad4bf41859d359e0a9b0b3ca1b5() { }

public RESTRC_7ef51ad4bf41859d359e0a9b0b3ca1b5 (RC_7ef51ad4bf41859d359e0a9b0b3ca1b5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMetadata = ConvertToRestWithoutDefaults(s.ssSTMetadata, new ST_a1f7d5fa968628cf9ed1d90efadf9506Structure(), ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure.FromStructureDelegate(config));
  } else {
AttrMetadata = ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure.FromStructure(s.ssSTMetadata, config);
  }
}

public static RC_7ef51ad4bf41859d359e0a9b0b3ca1b5 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_7ef51ad4bf41859d359e0a9b0b3ca1b5 obj) { 
  RC_7ef51ad4bf41859d359e0a9b0b3ca1b5 s = new RC_7ef51ad4bf41859d359e0a9b0b3ca1b5();
  if(obj != null) {
  s.ssSTMetadata = ssZXingLibDemo.RestRecords.RESTST_a1f7d5fa968628cf9ed1d90efadf9506Structure.ToStructure(obj.AttrMetadata);
  }
  return s;
}

public static Func<RC_7ef51ad4bf41859d359e0a9b0b3ca1b5, ssZXingLibDemo.RestRecords.RESTRC_7ef51ad4bf41859d359e0a9b0b3ca1b5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7ef51ad4bf41859d359e0a9b0b3ca1b5 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_7ef51ad4bf41859d359e0a9b0b3ca1b5 FromStructure(RC_7ef51ad4bf41859d359e0a9b0b3ca1b5 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_7ef51ad4bf41859d359e0a9b0b3ca1b5(s, config);
}

}


