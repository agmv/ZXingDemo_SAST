using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// IsDisableIsRemoveItemsRecord
public class JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc : AbstractRESTStructure<RC_98ce383abd92f0f4c51d49a4fcc3bfcc> {
[JsonProperty("IsDisable")]
[JsonPropertyName("IsDisable")]
public bool? AttrIsDisable;

[JsonProperty("IsRemoveItems")]
[JsonPropertyName("IsRemoveItems")]
public bool? AttrIsRemoveItems;

public JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc() { }

public JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc (RC_98ce383abd92f0f4c51d49a4fcc3bfcc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsDisable = ConvertToRestWithoutDefaults(s.ssIsDisable, false);
AttrIsRemoveItems = ConvertToRestWithoutDefaults(s.ssIsRemoveItems, false);
  } else {
AttrIsDisable = (bool?) s.ssIsDisable;
AttrIsRemoveItems = (bool?) s.ssIsRemoveItems;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc, RC_98ce383abd92f0f4c51d49a4fcc3bfcc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc s) => ToStructure(s, config);
}
public static RC_98ce383abd92f0f4c51d49a4fcc3bfcc ToStructure(ssOutSystemsUI.RestRecords.JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc obj, IBehaviorsConfiguration config) { 
  RC_98ce383abd92f0f4c51d49a4fcc3bfcc s = new RC_98ce383abd92f0f4c51d49a4fcc3bfcc();
  if(obj != null) {
  s.ssIsDisable = obj.AttrIsDisable == null ? false : obj.AttrIsDisable.Value;
  s.ssIsRemoveItems = obj.AttrIsRemoveItems == null ? false : obj.AttrIsRemoveItems.Value;
  }
  return s;
}

public static Func<RC_98ce383abd92f0f4c51d49a4fcc3bfcc, ssOutSystemsUI.RestRecords.JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_98ce383abd92f0f4c51d49a4fcc3bfcc s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc FromStructure(RC_98ce383abd92f0f4c51d49a4fcc3bfcc s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_98ce383abd92f0f4c51d49a4fcc3bfcc(s, config);
}

}


