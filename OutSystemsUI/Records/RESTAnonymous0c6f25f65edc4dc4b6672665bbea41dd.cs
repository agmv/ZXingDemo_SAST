using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSliderProviderRecord
public class RESTRC_45a33caf5ebb3dedd109c21fe6ae3d86 : AbstractRESTStructure<RC_45a33caf5ebb3dedd109c21fe6ae3d86> {
[JsonProperty("RangeSliderProvider")]
public ssOutSystemsUI.RestRecords.RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord AttrRangeSliderProvider;

public RESTRC_45a33caf5ebb3dedd109c21fe6ae3d86() { }

public RESTRC_45a33caf5ebb3dedd109c21fe6ae3d86 (RC_45a33caf5ebb3dedd109c21fe6ae3d86 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRangeSliderProvider = ConvertToRestWithoutDefaults(s.ssENRangeSliderProvider, new EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord.FromStructureDelegate(config));
  } else {
AttrRangeSliderProvider = ssOutSystemsUI.RestRecords.RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord.FromStructure(s.ssENRangeSliderProvider, config);
  }
}

public static RC_45a33caf5ebb3dedd109c21fe6ae3d86 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_45a33caf5ebb3dedd109c21fe6ae3d86 obj) { 
  RC_45a33caf5ebb3dedd109c21fe6ae3d86 s = new RC_45a33caf5ebb3dedd109c21fe6ae3d86();
  if(obj != null) {
  s.ssENRangeSliderProvider = ssOutSystemsUI.RestRecords.RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord.ToStructure(obj.AttrRangeSliderProvider);
  }
  return s;
}

public static Func<RC_45a33caf5ebb3dedd109c21fe6ae3d86, ssOutSystemsUI.RestRecords.RESTRC_45a33caf5ebb3dedd109c21fe6ae3d86> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_45a33caf5ebb3dedd109c21fe6ae3d86 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_45a33caf5ebb3dedd109c21fe6ae3d86 FromStructure(RC_45a33caf5ebb3dedd109c21fe6ae3d86 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_45a33caf5ebb3dedd109c21fe6ae3d86(s, config);
}

}


