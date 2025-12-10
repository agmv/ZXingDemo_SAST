using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// ColorRecord
public class RESTRC_87351e3b0fa2ca59cf6c6749c6405006 : AbstractRESTStructure<RC_87351e3b0fa2ca59cf6c6749c6405006> {
[JsonProperty("Color")]
public ssZXingLibDemo.RestRecords.RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord AttrColor;

public RESTRC_87351e3b0fa2ca59cf6c6749c6405006() { }

public RESTRC_87351e3b0fa2ca59cf6c6749c6405006 (RC_87351e3b0fa2ca59cf6c6749c6405006 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = ConvertToRestWithoutDefaults(s.ssENColor, new EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord(), ssZXingLibDemo.RestRecords.RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord.FromStructureDelegate(config));
  } else {
AttrColor = ssZXingLibDemo.RestRecords.RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord.FromStructure(s.ssENColor, config);
  }
}

public static RC_87351e3b0fa2ca59cf6c6749c6405006 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_87351e3b0fa2ca59cf6c6749c6405006 obj) { 
  RC_87351e3b0fa2ca59cf6c6749c6405006 s = new RC_87351e3b0fa2ca59cf6c6749c6405006();
  if(obj != null) {
  s.ssENColor = ssZXingLibDemo.RestRecords.RESTEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord.ToStructure(obj.AttrColor);
  }
  return s;
}

public static Func<RC_87351e3b0fa2ca59cf6c6749c6405006, ssZXingLibDemo.RestRecords.RESTRC_87351e3b0fa2ca59cf6c6749c6405006> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87351e3b0fa2ca59cf6c6749c6405006 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_87351e3b0fa2ca59cf6c6749c6405006 FromStructure(RC_87351e3b0fa2ca59cf6c6749c6405006 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_87351e3b0fa2ca59cf6c6749c6405006(s, config);
}

}


