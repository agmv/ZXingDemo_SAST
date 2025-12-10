using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawRectangle_ConfigsRecord
public class RESTRC_2afa68ebeade43c502f553bf208d417d : AbstractRESTStructure<RC_2afa68ebeade43c502f553bf208d417d> {
[JsonProperty("Internal_DrawRectangle_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_9df57e801e7478aaf703933c17abb4f6Structure AttrInternal_DrawRectangle_Configs;

public RESTRC_2afa68ebeade43c502f553bf208d417d() { }

public RESTRC_2afa68ebeade43c502f553bf208d417d (RC_2afa68ebeade43c502f553bf208d417d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_DrawRectangle_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_DrawRectangle_Configs, new ST_9df57e801e7478aaf703933c17abb4f6Structure(), ssOutSystemsMaps.RestRecords.RESTST_9df57e801e7478aaf703933c17abb4f6Structure.FromStructureDelegate(config));
  } else {
AttrInternal_DrawRectangle_Configs = ssOutSystemsMaps.RestRecords.RESTST_9df57e801e7478aaf703933c17abb4f6Structure.FromStructure(s.ssSTInternal_DrawRectangle_Configs, config);
  }
}

public static RC_2afa68ebeade43c502f553bf208d417d ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_2afa68ebeade43c502f553bf208d417d obj) { 
  RC_2afa68ebeade43c502f553bf208d417d s = new RC_2afa68ebeade43c502f553bf208d417d();
  if(obj != null) {
  s.ssSTInternal_DrawRectangle_Configs = ssOutSystemsMaps.RestRecords.RESTST_9df57e801e7478aaf703933c17abb4f6Structure.ToStructure(obj.AttrInternal_DrawRectangle_Configs);
  }
  return s;
}

public static Func<RC_2afa68ebeade43c502f553bf208d417d, ssOutSystemsMaps.RestRecords.RESTRC_2afa68ebeade43c502f553bf208d417d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2afa68ebeade43c502f553bf208d417d s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_2afa68ebeade43c502f553bf208d417d FromStructure(RC_2afa68ebeade43c502f553bf208d417d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_2afa68ebeade43c502f553bf208d417d(s, config);
}

}


