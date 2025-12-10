using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// VideoCaptionsRecord
public class JSONRC_23e4ac7b03ba2050af5811737c8cc89f : AbstractRESTStructure<RC_23e4ac7b03ba2050af5811737c8cc89f> {
[JsonProperty("VideoCaptions")]
[JsonPropertyName("VideoCaptions")]
public ssOutSystemsUI.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure AttrVideoCaptions;

public JSONRC_23e4ac7b03ba2050af5811737c8cc89f() { }

public JSONRC_23e4ac7b03ba2050af5811737c8cc89f (RC_23e4ac7b03ba2050af5811737c8cc89f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVideoCaptions = ConvertToRestWithoutDefaults(s.ssSTVideoCaptions, new ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure(), ssOutSystemsUI.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure.FromStructureDelegate(config));
  } else {
AttrVideoCaptions = ssOutSystemsUI.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure.FromStructure(s.ssSTVideoCaptions, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_23e4ac7b03ba2050af5811737c8cc89f, RC_23e4ac7b03ba2050af5811737c8cc89f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_23e4ac7b03ba2050af5811737c8cc89f s) => ToStructure(s, config);
}
public static RC_23e4ac7b03ba2050af5811737c8cc89f ToStructure(ssOutSystemsUI.RestRecords.JSONRC_23e4ac7b03ba2050af5811737c8cc89f obj, IBehaviorsConfiguration config) { 
  RC_23e4ac7b03ba2050af5811737c8cc89f s = new RC_23e4ac7b03ba2050af5811737c8cc89f();
  if(obj != null) {
  s.ssSTVideoCaptions = ssOutSystemsUI.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure.ToStructure(obj.AttrVideoCaptions, config);
  }
  return s;
}

public static Func<RC_23e4ac7b03ba2050af5811737c8cc89f, ssOutSystemsUI.RestRecords.JSONRC_23e4ac7b03ba2050af5811737c8cc89f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_23e4ac7b03ba2050af5811737c8cc89f s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_23e4ac7b03ba2050af5811737c8cc89f FromStructure(RC_23e4ac7b03ba2050af5811737c8cc89f s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_23e4ac7b03ba2050af5811737c8cc89f(s, config);
}

}


