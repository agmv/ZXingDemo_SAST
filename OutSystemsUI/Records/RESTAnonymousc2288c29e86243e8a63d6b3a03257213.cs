using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// IsDisableIsRemoveItemsRecord
public class RESTRC_98ce383abd92f0f4c51d49a4fcc3bfcc : AbstractRESTStructure<RC_98ce383abd92f0f4c51d49a4fcc3bfcc> {
[JsonProperty("IsDisable")]
public bool? AttrIsDisable;

[JsonProperty("IsRemoveItems")]
public bool? AttrIsRemoveItems;

public RESTRC_98ce383abd92f0f4c51d49a4fcc3bfcc() { }

public RESTRC_98ce383abd92f0f4c51d49a4fcc3bfcc (RC_98ce383abd92f0f4c51d49a4fcc3bfcc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsDisable = ConvertToRestWithoutDefaults(s.ssIsDisable, false);
AttrIsRemoveItems = ConvertToRestWithoutDefaults(s.ssIsRemoveItems, false);
  } else {
AttrIsDisable = (bool?) s.ssIsDisable;
AttrIsRemoveItems = (bool?) s.ssIsRemoveItems;
  }
}

public static RC_98ce383abd92f0f4c51d49a4fcc3bfcc ToStructure(ssOutSystemsUI.RestRecords.RESTRC_98ce383abd92f0f4c51d49a4fcc3bfcc obj) { 
  RC_98ce383abd92f0f4c51d49a4fcc3bfcc s = new RC_98ce383abd92f0f4c51d49a4fcc3bfcc();
  if(obj != null) {
  s.ssIsDisable = obj.AttrIsDisable == null ? false : obj.AttrIsDisable.Value;
  s.ssIsRemoveItems = obj.AttrIsRemoveItems == null ? false : obj.AttrIsRemoveItems.Value;
  }
  return s;
}

public static Func<RC_98ce383abd92f0f4c51d49a4fcc3bfcc, ssOutSystemsUI.RestRecords.RESTRC_98ce383abd92f0f4c51d49a4fcc3bfcc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_98ce383abd92f0f4c51d49a4fcc3bfcc s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_98ce383abd92f0f4c51d49a4fcc3bfcc FromStructure(RC_98ce383abd92f0f4c51d49a4fcc3bfcc s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_98ce383abd92f0f4c51d49a4fcc3bfcc(s, config);
}

}


