using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ReturnMessageRecord
public class RESTRC_de4b3bacd4ec5ee23880b64e848f90da : AbstractRESTStructure<RC_de4b3bacd4ec5ee23880b64e848f90da> {
[JsonProperty("ReturnMessage")]
public ssOutSystemsUI.RestRecords.RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure AttrReturnMessage;

public RESTRC_de4b3bacd4ec5ee23880b64e848f90da() { }

public RESTRC_de4b3bacd4ec5ee23880b64e848f90da (RC_de4b3bacd4ec5ee23880b64e848f90da s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReturnMessage = ConvertToRestWithoutDefaults(s.ssSTReturnMessage, new ST_13c131829a33cb5bedb5c64aa6f4add2Structure(), ssOutSystemsUI.RestRecords.RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure.FromStructureDelegate(config));
  } else {
AttrReturnMessage = ssOutSystemsUI.RestRecords.RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure.FromStructure(s.ssSTReturnMessage, config);
  }
}

public static RC_de4b3bacd4ec5ee23880b64e848f90da ToStructure(ssOutSystemsUI.RestRecords.RESTRC_de4b3bacd4ec5ee23880b64e848f90da obj) { 
  RC_de4b3bacd4ec5ee23880b64e848f90da s = new RC_de4b3bacd4ec5ee23880b64e848f90da();
  if(obj != null) {
  s.ssSTReturnMessage = ssOutSystemsUI.RestRecords.RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure.ToStructure(obj.AttrReturnMessage);
  }
  return s;
}

public static Func<RC_de4b3bacd4ec5ee23880b64e848f90da, ssOutSystemsUI.RestRecords.RESTRC_de4b3bacd4ec5ee23880b64e848f90da> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_de4b3bacd4ec5ee23880b64e848f90da s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_de4b3bacd4ec5ee23880b64e848f90da FromStructure(RC_de4b3bacd4ec5ee23880b64e848f90da s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_de4b3bacd4ec5ee23880b64e848f90da(s, config);
}

}


