using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AttachmentRecord
public class RESTRCAttachmentRecord : AbstractRESTStructure<RCAttachmentRecord> {
[JsonProperty("Attachment")]
public ssZXingLibDemo.RestRecords.RESTSTAttachmentStructure AttrAttachment;

public RESTRCAttachmentRecord() { }

public RESTRCAttachmentRecord (RCAttachmentRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAttachment = ConvertToRestWithoutDefaults(s.ssSTAttachment, new STAttachmentStructure(), ssZXingLibDemo.RestRecords.RESTSTAttachmentStructure.FromStructureDelegate(config));
  } else {
AttrAttachment = ssZXingLibDemo.RestRecords.RESTSTAttachmentStructure.FromStructure(s.ssSTAttachment, config);
  }
}

public static RCAttachmentRecord ToStructure(ssZXingLibDemo.RestRecords.RESTRCAttachmentRecord obj) { 
  RCAttachmentRecord s = new RCAttachmentRecord();
  if(obj != null) {
  s.ssSTAttachment = ssZXingLibDemo.RestRecords.RESTSTAttachmentStructure.ToStructure(obj.AttrAttachment);
  }
  return s;
}

public static Func<RCAttachmentRecord, ssZXingLibDemo.RestRecords.RESTRCAttachmentRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAttachmentRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRCAttachmentRecord FromStructure(RCAttachmentRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRCAttachmentRecord(s, config);
}

}


