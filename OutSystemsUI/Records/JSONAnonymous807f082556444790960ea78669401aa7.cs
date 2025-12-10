using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ReturnMessageRecord
public class JSONRC_de4b3bacd4ec5ee23880b64e848f90da : AbstractRESTStructure<RC_de4b3bacd4ec5ee23880b64e848f90da> {
[JsonProperty("ReturnMessage")]
[JsonPropertyName("ReturnMessage")]
public ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure AttrReturnMessage;

public JSONRC_de4b3bacd4ec5ee23880b64e848f90da() { }

public JSONRC_de4b3bacd4ec5ee23880b64e848f90da (RC_de4b3bacd4ec5ee23880b64e848f90da s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReturnMessage = ConvertToRestWithoutDefaults(s.ssSTReturnMessage, new ST_13c131829a33cb5bedb5c64aa6f4add2Structure(), ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure.FromStructureDelegate(config));
  } else {
AttrReturnMessage = ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure.FromStructure(s.ssSTReturnMessage, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_de4b3bacd4ec5ee23880b64e848f90da, RC_de4b3bacd4ec5ee23880b64e848f90da> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_de4b3bacd4ec5ee23880b64e848f90da s) => ToStructure(s, config);
}
public static RC_de4b3bacd4ec5ee23880b64e848f90da ToStructure(ssOutSystemsUI.RestRecords.JSONRC_de4b3bacd4ec5ee23880b64e848f90da obj, IBehaviorsConfiguration config) { 
  RC_de4b3bacd4ec5ee23880b64e848f90da s = new RC_de4b3bacd4ec5ee23880b64e848f90da();
  if(obj != null) {
  s.ssSTReturnMessage = ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure.ToStructure(obj.AttrReturnMessage, config);
  }
  return s;
}

public static Func<RC_de4b3bacd4ec5ee23880b64e848f90da, ssOutSystemsUI.RestRecords.JSONRC_de4b3bacd4ec5ee23880b64e848f90da> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_de4b3bacd4ec5ee23880b64e848f90da s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_de4b3bacd4ec5ee23880b64e848f90da FromStructure(RC_de4b3bacd4ec5ee23880b64e848f90da s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_de4b3bacd4ec5ee23880b64e848f90da(s, config);
}

}


