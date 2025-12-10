using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Notification_InternalConfigRecord
public class RESTRC_f52343ea94aab4a44927e9cbc0e79a19 : AbstractRESTStructure<RC_f52343ea94aab4a44927e9cbc0e79a19> {
[JsonProperty("Notification_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_46bd5f77d899939eaf145ae01d3efd6bStructure AttrNotification_InternalConfig;

public RESTRC_f52343ea94aab4a44927e9cbc0e79a19() { }

public RESTRC_f52343ea94aab4a44927e9cbc0e79a19 (RC_f52343ea94aab4a44927e9cbc0e79a19 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNotification_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTNotification_InternalConfig, new ST_46bd5f77d899939eaf145ae01d3efd6bStructure(), ssOutSystemsUI.RestRecords.RESTST_46bd5f77d899939eaf145ae01d3efd6bStructure.FromStructureDelegate(config));
  } else {
AttrNotification_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_46bd5f77d899939eaf145ae01d3efd6bStructure.FromStructure(s.ssSTNotification_InternalConfig, config);
  }
}

public static RC_f52343ea94aab4a44927e9cbc0e79a19 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_f52343ea94aab4a44927e9cbc0e79a19 obj) { 
  RC_f52343ea94aab4a44927e9cbc0e79a19 s = new RC_f52343ea94aab4a44927e9cbc0e79a19();
  if(obj != null) {
  s.ssSTNotification_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_46bd5f77d899939eaf145ae01d3efd6bStructure.ToStructure(obj.AttrNotification_InternalConfig);
  }
  return s;
}

public static Func<RC_f52343ea94aab4a44927e9cbc0e79a19, ssOutSystemsUI.RestRecords.RESTRC_f52343ea94aab4a44927e9cbc0e79a19> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f52343ea94aab4a44927e9cbc0e79a19 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_f52343ea94aab4a44927e9cbc0e79a19 FromStructure(RC_f52343ea94aab4a44927e9cbc0e79a19 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_f52343ea94aab4a44927e9cbc0e79a19(s, config);
}

}


