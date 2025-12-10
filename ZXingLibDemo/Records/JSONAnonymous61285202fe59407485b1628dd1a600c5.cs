using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AttachmentRecord
public class JSONRCAttachmentRecord : AbstractRESTStructure<RCAttachmentRecord> {
[JsonProperty("Attachment")]
[JsonPropertyName("Attachment")]
public ssZXingLibDemo.RestRecords.JSONSTAttachmentStructure AttrAttachment;

public JSONRCAttachmentRecord() { }

public JSONRCAttachmentRecord (RCAttachmentRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAttachment = ConvertToRestWithoutDefaults(s.ssSTAttachment, new STAttachmentStructure(), ssZXingLibDemo.RestRecords.JSONSTAttachmentStructure.FromStructureDelegate(config));
  } else {
AttrAttachment = ssZXingLibDemo.RestRecords.JSONSTAttachmentStructure.FromStructure(s.ssSTAttachment, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRCAttachmentRecord, RCAttachmentRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRCAttachmentRecord s) => ToStructure(s, config);
}
public static RCAttachmentRecord ToStructure(ssZXingLibDemo.RestRecords.JSONRCAttachmentRecord obj, IBehaviorsConfiguration config) { 
  RCAttachmentRecord s = new RCAttachmentRecord();
  if(obj != null) {
  s.ssSTAttachment = ssZXingLibDemo.RestRecords.JSONSTAttachmentStructure.ToStructure(obj.AttrAttachment, config);
  }
  return s;
}

public static Func<RCAttachmentRecord, ssZXingLibDemo.RestRecords.JSONRCAttachmentRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAttachmentRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRCAttachmentRecord FromStructure(RCAttachmentRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRCAttachmentRecord(s, config);
}

}


