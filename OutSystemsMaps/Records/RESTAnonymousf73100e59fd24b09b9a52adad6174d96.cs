using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalPopupMarkerConfigsRecord
public class RESTRC_dfb836f467b00be2b3ce838401b340cc : AbstractRESTStructure<RC_dfb836f467b00be2b3ce838401b340cc> {
[JsonProperty("OptionalPopupMarkerConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_bbc1ca6a16af45dbf463953c280f2bf7Structure AttrOptionalPopupMarkerConfigs;

public RESTRC_dfb836f467b00be2b3ce838401b340cc() { }

public RESTRC_dfb836f467b00be2b3ce838401b340cc (RC_dfb836f467b00be2b3ce838401b340cc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalPopupMarkerConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalPopupMarkerConfigs, new ST_bbc1ca6a16af45dbf463953c280f2bf7Structure(), ssOutSystemsMaps.RestRecords.RESTST_bbc1ca6a16af45dbf463953c280f2bf7Structure.FromStructureDelegate(config));
  } else {
AttrOptionalPopupMarkerConfigs = ssOutSystemsMaps.RestRecords.RESTST_bbc1ca6a16af45dbf463953c280f2bf7Structure.FromStructure(s.ssSTOptionalPopupMarkerConfigs, config);
  }
}

public static RC_dfb836f467b00be2b3ce838401b340cc ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_dfb836f467b00be2b3ce838401b340cc obj) { 
  RC_dfb836f467b00be2b3ce838401b340cc s = new RC_dfb836f467b00be2b3ce838401b340cc();
  if(obj != null) {
  s.ssSTOptionalPopupMarkerConfigs = ssOutSystemsMaps.RestRecords.RESTST_bbc1ca6a16af45dbf463953c280f2bf7Structure.ToStructure(obj.AttrOptionalPopupMarkerConfigs);
  }
  return s;
}

public static Func<RC_dfb836f467b00be2b3ce838401b340cc, ssOutSystemsMaps.RestRecords.RESTRC_dfb836f467b00be2b3ce838401b340cc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dfb836f467b00be2b3ce838401b340cc s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_dfb836f467b00be2b3ce838401b340cc FromStructure(RC_dfb836f467b00be2b3ce838401b340cc s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_dfb836f467b00be2b3ce838401b340cc(s, config);
}

}


