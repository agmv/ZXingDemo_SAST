using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// WifiRecord
public class RESTRC_df417030a22338c6546ba4bfe47f9e17 : AbstractRESTStructure<RC_df417030a22338c6546ba4bfe47f9e17> {
[JsonProperty("Wifi")]
public ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure AttrWifi;

public RESTRC_df417030a22338c6546ba4bfe47f9e17() { }

public RESTRC_df417030a22338c6546ba4bfe47f9e17 (RC_df417030a22338c6546ba4bfe47f9e17 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWifi = ConvertToRestWithoutDefaults(s.ssSTWifi, new ST_af04a340a4a61afef041397e6f042234Structure(), ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure.FromStructureDelegate(config));
  } else {
AttrWifi = ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure.FromStructure(s.ssSTWifi, config);
  }
}

public static RC_df417030a22338c6546ba4bfe47f9e17 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_df417030a22338c6546ba4bfe47f9e17 obj) { 
  RC_df417030a22338c6546ba4bfe47f9e17 s = new RC_df417030a22338c6546ba4bfe47f9e17();
  if(obj != null) {
  s.ssSTWifi = ssZXingLibDemo.RestRecords.RESTST_af04a340a4a61afef041397e6f042234Structure.ToStructure(obj.AttrWifi);
  }
  return s;
}

public static Func<RC_df417030a22338c6546ba4bfe47f9e17, ssZXingLibDemo.RestRecords.RESTRC_df417030a22338c6546ba4bfe47f9e17> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df417030a22338c6546ba4bfe47f9e17 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_df417030a22338c6546ba4bfe47f9e17 FromStructure(RC_df417030a22338c6546ba4bfe47f9e17 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_df417030a22338c6546ba4bfe47f9e17(s, config);
}

}


