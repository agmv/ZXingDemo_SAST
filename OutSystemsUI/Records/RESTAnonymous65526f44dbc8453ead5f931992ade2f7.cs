using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TriggerRecord
public class RESTRC_ab84a98a3ac9de80e9278e5b21681a23 : AbstractRESTStructure<RC_ab84a98a3ac9de80e9278e5b21681a23> {
[JsonProperty("Trigger")]
public ssOutSystemsUI.RestRecords.RESTEN_52e55d60c515b6016f81404afb220594EntityRecord AttrTrigger;

public RESTRC_ab84a98a3ac9de80e9278e5b21681a23() { }

public RESTRC_ab84a98a3ac9de80e9278e5b21681a23 (RC_ab84a98a3ac9de80e9278e5b21681a23 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTrigger = ConvertToRestWithoutDefaults(s.ssENTrigger, new EN_52e55d60c515b6016f81404afb220594EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_52e55d60c515b6016f81404afb220594EntityRecord.FromStructureDelegate(config));
  } else {
AttrTrigger = ssOutSystemsUI.RestRecords.RESTEN_52e55d60c515b6016f81404afb220594EntityRecord.FromStructure(s.ssENTrigger, config);
  }
}

public static RC_ab84a98a3ac9de80e9278e5b21681a23 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_ab84a98a3ac9de80e9278e5b21681a23 obj) { 
  RC_ab84a98a3ac9de80e9278e5b21681a23 s = new RC_ab84a98a3ac9de80e9278e5b21681a23();
  if(obj != null) {
  s.ssENTrigger = ssOutSystemsUI.RestRecords.RESTEN_52e55d60c515b6016f81404afb220594EntityRecord.ToStructure(obj.AttrTrigger);
  }
  return s;
}

public static Func<RC_ab84a98a3ac9de80e9278e5b21681a23, ssOutSystemsUI.RestRecords.RESTRC_ab84a98a3ac9de80e9278e5b21681a23> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ab84a98a3ac9de80e9278e5b21681a23 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_ab84a98a3ac9de80e9278e5b21681a23 FromStructure(RC_ab84a98a3ac9de80e9278e5b21681a23 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_ab84a98a3ac9de80e9278e5b21681a23(s, config);
}

}


