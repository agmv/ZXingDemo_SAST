using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// IdentityProviderRecord
public class JSONRC_3bbfc6c91fcd8a2dd97847564be30682 : AbstractRESTStructure<RC_3bbfc6c91fcd8a2dd97847564be30682> {
[JsonProperty("IdentityProvider")]
[JsonPropertyName("IdentityProvider")]
public ssOutSystemsUI.RestRecords.JSONEN_f9178b4aae1879ea388b92402c64db4cEntityRecord AttrIdentityProvider;

public JSONRC_3bbfc6c91fcd8a2dd97847564be30682() { }

public JSONRC_3bbfc6c91fcd8a2dd97847564be30682 (RC_3bbfc6c91fcd8a2dd97847564be30682 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIdentityProvider = ConvertToRestWithoutDefaults(s.ssENIdentityProvider, new EN_f9178b4aae1879ea388b92402c64db4cEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_f9178b4aae1879ea388b92402c64db4cEntityRecord.FromStructureDelegate(config));
  } else {
AttrIdentityProvider = ssOutSystemsUI.RestRecords.JSONEN_f9178b4aae1879ea388b92402c64db4cEntityRecord.FromStructure(s.ssENIdentityProvider, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_3bbfc6c91fcd8a2dd97847564be30682, RC_3bbfc6c91fcd8a2dd97847564be30682> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_3bbfc6c91fcd8a2dd97847564be30682 s) => ToStructure(s, config);
}
public static RC_3bbfc6c91fcd8a2dd97847564be30682 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_3bbfc6c91fcd8a2dd97847564be30682 obj, IBehaviorsConfiguration config) { 
  RC_3bbfc6c91fcd8a2dd97847564be30682 s = new RC_3bbfc6c91fcd8a2dd97847564be30682();
  if(obj != null) {
  s.ssENIdentityProvider = ssOutSystemsUI.RestRecords.JSONEN_f9178b4aae1879ea388b92402c64db4cEntityRecord.ToStructure(obj.AttrIdentityProvider, config);
  }
  return s;
}

public static Func<RC_3bbfc6c91fcd8a2dd97847564be30682, ssOutSystemsUI.RestRecords.JSONRC_3bbfc6c91fcd8a2dd97847564be30682> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3bbfc6c91fcd8a2dd97847564be30682 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_3bbfc6c91fcd8a2dd97847564be30682 FromStructure(RC_3bbfc6c91fcd8a2dd97847564be30682 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_3bbfc6c91fcd8a2dd97847564be30682(s, config);
}

}


