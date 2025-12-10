using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// BarcodeRecord
public class RESTRC_57ba3d0d08ca4ec872815e3480261d89 : AbstractRESTStructure<RC_57ba3d0d08ca4ec872815e3480261d89> {
[JsonProperty("Barcode")]
public ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure AttrBarcode;

public RESTRC_57ba3d0d08ca4ec872815e3480261d89() { }

public RESTRC_57ba3d0d08ca4ec872815e3480261d89 (RC_57ba3d0d08ca4ec872815e3480261d89 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBarcode = ConvertToRestWithoutDefaults(s.ssSTBarcode, new ST_7750e71a4e018dabac19d9f560c2b017Structure(), ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure.FromStructureDelegate(config));
  } else {
AttrBarcode = ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure.FromStructure(s.ssSTBarcode, config);
  }
}

public static RC_57ba3d0d08ca4ec872815e3480261d89 ToStructure(ssZXingLibDemo.RestRecords.RESTRC_57ba3d0d08ca4ec872815e3480261d89 obj) { 
  RC_57ba3d0d08ca4ec872815e3480261d89 s = new RC_57ba3d0d08ca4ec872815e3480261d89();
  if(obj != null) {
  s.ssSTBarcode = ssZXingLibDemo.RestRecords.RESTST_7750e71a4e018dabac19d9f560c2b017Structure.ToStructure(obj.AttrBarcode);
  }
  return s;
}

public static Func<RC_57ba3d0d08ca4ec872815e3480261d89, ssZXingLibDemo.RestRecords.RESTRC_57ba3d0d08ca4ec872815e3480261d89> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_57ba3d0d08ca4ec872815e3480261d89 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_57ba3d0d08ca4ec872815e3480261d89 FromStructure(RC_57ba3d0d08ca4ec872815e3480261d89 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_57ba3d0d08ca4ec872815e3480261d89(s, config);
}

}


