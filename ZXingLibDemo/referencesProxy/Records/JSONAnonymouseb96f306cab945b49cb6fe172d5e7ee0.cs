using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// WifiRecord
public class JSONRC_df417030a22338c6546ba4bfe47f9e17 : AbstractRESTStructure<RC_df417030a22338c6546ba4bfe47f9e17> {
[JsonProperty("Wifi")]
[JsonPropertyName("Wifi")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure AttrWifi;

public JSONRC_df417030a22338c6546ba4bfe47f9e17() { }

public JSONRC_df417030a22338c6546ba4bfe47f9e17 (RC_df417030a22338c6546ba4bfe47f9e17 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWifi = ConvertToRestWithoutDefaults(s.ssSTWifi, new ST_af04a340a4a61afef041397e6f042234Structure(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure.FromStructureDelegate(config));
  } else {
AttrWifi = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure.FromStructure(s.ssSTWifi, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_df417030a22338c6546ba4bfe47f9e17, RC_df417030a22338c6546ba4bfe47f9e17> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_df417030a22338c6546ba4bfe47f9e17 s) => ToStructure(s, config);
}
public static RC_df417030a22338c6546ba4bfe47f9e17 ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_df417030a22338c6546ba4bfe47f9e17 obj, IBehaviorsConfiguration config) { 
  RC_df417030a22338c6546ba4bfe47f9e17 s = new RC_df417030a22338c6546ba4bfe47f9e17();
  if(obj != null) {
  s.ssSTWifi = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_af04a340a4a61afef041397e6f042234Structure.ToStructure(obj.AttrWifi, config);
  }
  return s;
}

public static Func<RC_df417030a22338c6546ba4bfe47f9e17, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_df417030a22338c6546ba4bfe47f9e17> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df417030a22338c6546ba4bfe47f9e17 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_df417030a22338c6546ba4bfe47f9e17 FromStructure(RC_df417030a22338c6546ba4bfe47f9e17 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_df417030a22338c6546ba4bfe47f9e17(s, config);
}

}


