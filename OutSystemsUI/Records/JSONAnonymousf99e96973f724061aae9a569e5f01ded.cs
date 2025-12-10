using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AlertRecord
public class JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a : AbstractRESTStructure<RC_9ca6a18cc49ca7246c44c0f7c2cef62a> {
[JsonProperty("Alert")]
[JsonPropertyName("Alert")]
public ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord AttrAlert;

public JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a() { }

public JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a (RC_9ca6a18cc49ca7246c44c0f7c2cef62a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAlert = ConvertToRestWithoutDefaults(s.ssENAlert, new EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord.FromStructureDelegate(config));
  } else {
AttrAlert = ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord.FromStructure(s.ssENAlert, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a, RC_9ca6a18cc49ca7246c44c0f7c2cef62a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a s) => ToStructure(s, config);
}
public static RC_9ca6a18cc49ca7246c44c0f7c2cef62a ToStructure(ssOutSystemsUI.RestRecords.JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a obj, IBehaviorsConfiguration config) { 
  RC_9ca6a18cc49ca7246c44c0f7c2cef62a s = new RC_9ca6a18cc49ca7246c44c0f7c2cef62a();
  if(obj != null) {
  s.ssENAlert = ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord.ToStructure(obj.AttrAlert, config);
  }
  return s;
}

public static Func<RC_9ca6a18cc49ca7246c44c0f7c2cef62a, ssOutSystemsUI.RestRecords.JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9ca6a18cc49ca7246c44c0f7c2cef62a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a FromStructure(RC_9ca6a18cc49ca7246c44c0f7c2cef62a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_9ca6a18cc49ca7246c44c0f7c2cef62a(s, config);
}

}


