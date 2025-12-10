using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// BreakColumnsRecord
public class RESTRC_261685da2c799bcc3b4873485e008694 : AbstractRESTStructure<RC_261685da2c799bcc3b4873485e008694> {
[JsonProperty("BreakColumns")]
public ssOutSystemsUI.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord AttrBreakColumns;

public RESTRC_261685da2c799bcc3b4873485e008694() { }

public RESTRC_261685da2c799bcc3b4873485e008694 (RC_261685da2c799bcc3b4873485e008694 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBreakColumns = ConvertToRestWithoutDefaults(s.ssENBreakColumns, new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.FromStructureDelegate(config));
  } else {
AttrBreakColumns = ssOutSystemsUI.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.FromStructure(s.ssENBreakColumns, config);
  }
}

public static RC_261685da2c799bcc3b4873485e008694 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_261685da2c799bcc3b4873485e008694 obj) { 
  RC_261685da2c799bcc3b4873485e008694 s = new RC_261685da2c799bcc3b4873485e008694();
  if(obj != null) {
  s.ssENBreakColumns = ssOutSystemsUI.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.ToStructure(obj.AttrBreakColumns);
  }
  return s;
}

public static Func<RC_261685da2c799bcc3b4873485e008694, ssOutSystemsUI.RestRecords.RESTRC_261685da2c799bcc3b4873485e008694> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_261685da2c799bcc3b4873485e008694 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_261685da2c799bcc3b4873485e008694 FromStructure(RC_261685da2c799bcc3b4873485e008694 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_261685da2c799bcc3b4873485e008694(s, config);
}

}


