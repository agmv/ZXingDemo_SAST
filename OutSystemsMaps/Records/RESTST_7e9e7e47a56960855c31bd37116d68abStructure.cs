using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// CircleShape
public class RESTST_7e9e7e47a56960855c31bd37116d68abStructure : AbstractRESTStructure<ST_7e9e7e47a56960855c31bd37116d68abStructure> {
[JsonProperty("Center")]
public ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure AttrCenter;

[JsonProperty("Radius")]
public decimal? AttrRadius;

public RESTST_7e9e7e47a56960855c31bd37116d68abStructure() { }

public RESTST_7e9e7e47a56960855c31bd37116d68abStructure (ST_7e9e7e47a56960855c31bd37116d68abStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCenter = ConvertToRestWithoutDefaults(s.ssCenter, new ST_0e474756a4be14d378c73cd05f602bcdStructure(), ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructureDelegate(config));
AttrRadius = ConvertToRestWithoutDefaults(s.ssRadius, 0.0M);
  } else {
AttrCenter = ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.FromStructure(s.ssCenter, config);
AttrRadius = (decimal?) s.ssRadius;
  }
}

public static ST_7e9e7e47a56960855c31bd37116d68abStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_7e9e7e47a56960855c31bd37116d68abStructure obj) { 
  ST_7e9e7e47a56960855c31bd37116d68abStructure s = new ST_7e9e7e47a56960855c31bd37116d68abStructure();
  if(obj != null) {
  s.ssCenter = ssOutSystemsMaps.RestRecords.RESTST_0e474756a4be14d378c73cd05f602bcdStructure.ToStructure(obj.AttrCenter);
  s.ssRadius = obj.AttrRadius == null ? 0.0M : obj.AttrRadius.Value;
  }
  return s;
}

public static Func<ST_7e9e7e47a56960855c31bd37116d68abStructure, ssOutSystemsMaps.RestRecords.RESTST_7e9e7e47a56960855c31bd37116d68abStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7e9e7e47a56960855c31bd37116d68abStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_7e9e7e47a56960855c31bd37116d68abStructure FromStructure(ST_7e9e7e47a56960855c31bd37116d68abStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_7e9e7e47a56960855c31bd37116d68abStructure(s, config);
}

}


