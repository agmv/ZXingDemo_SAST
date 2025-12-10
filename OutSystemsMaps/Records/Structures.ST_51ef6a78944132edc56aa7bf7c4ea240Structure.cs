namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_marker_configs (iHo4eqkgekWfWoI8SqpqJQ)
///  <code>ST_51ef6a78944132edc56aa7bf7c4ea240Structure</code> that represent
/// s <code>Internal_to_provider_marker_configs</code> <p>Description: Structure to handle internal
///  configurations associated with the Markers at the provider level.</p>
/// </summary>
// Name: Internal_to_provider_marker_configs
public partial struct ST_51ef6a78944132edc56aa7bf7c4ea240Structure : ITypedRecord<ST_51ef6a78944132edc56aa7bf7c4ea240Structure> {
internal static readonly GlobalObjectKey Idlocation = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*LCU9ACHyu0CX++c3mehrcg");
internal static readonly GlobalObjectKey IdiconUrl = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*rBACOe3kA0yHJPv3NrNjQA");
internal static readonly GlobalObjectKey Idtitle = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*bEATmy4WWEiK47B9UzCWvA");
internal static readonly GlobalObjectKey Idlabel = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*xkRiLRJ2DE2yCUSv53UANQ");
internal static readonly GlobalObjectKey IdallowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*HVaJQsVRsUGCLahhCoBk5A");
internal static readonly GlobalObjectKey IdiconWidth = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*n158EWJS+kiU+4ZrIFdPhA");
internal static readonly GlobalObjectKey IdiconHeight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*s90tkg0iaE2Ost4fHnlIMg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("location")]
public string sslocation;

[System.Xml.Serialization.XmlElement("iconUrl")]
public string ssiconUrl;

[System.Xml.Serialization.XmlElement("title")]
public string sstitle;

[System.Xml.Serialization.XmlElement("label")]
public string sslabel;

[System.Xml.Serialization.XmlElement("allowDrag")]
public bool ssallowDrag;

[System.Xml.Serialization.XmlElement("iconWidth")]
public string ssiconWidth;

[System.Xml.Serialization.XmlElement("iconHeight")]
public string ssiconHeight;


public BitArray OptimizedAttributes;

public ST_51ef6a78944132edc56aa7bf7c4ea240Structure() {
OptimizedAttributes = null;
sslocation = "";
ssiconUrl = "";
sstitle = "";
sslabel = "";
ssallowDrag = false;
ssiconWidth = "";
ssiconHeight = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
sslocation = r.ReadText(index++, "Internal_to_provider_marker_configs.location", "");
ssiconUrl = r.ReadText(index++, "Internal_to_provider_marker_configs.iconUrl", "");
sstitle = r.ReadText(index++, "Internal_to_provider_marker_configs.title", "");
sslabel = r.ReadText(index++, "Internal_to_provider_marker_configs.label", "");
ssallowDrag = r.ReadBoolean(index++, "Internal_to_provider_marker_configs.allowDrag", false);
ssiconWidth = r.ReadText(index++, "Internal_to_provider_marker_configs.iconWidth", "");
ssiconHeight = r.ReadText(index++, "Internal_to_provider_marker_configs.iconHeight", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_51ef6a78944132edc56aa7bf7c4ea240Structure r) {
this = r;
}


public static bool operator == (ST_51ef6a78944132edc56aa7bf7c4ea240Structure a, ST_51ef6a78944132edc56aa7bf7c4ea240Structure b) {
if (a.sslocation != b.sslocation) return false;
if (a.ssiconUrl != b.ssiconUrl) return false;
if (a.sstitle != b.sstitle) return false;
if (a.sslabel != b.sslabel) return false;
if (a.ssallowDrag != b.ssallowDrag) return false;
if (a.ssiconWidth != b.ssiconWidth) return false;
if (a.ssiconHeight != b.ssiconHeight) return false;
return true;
}

public static bool operator != (ST_51ef6a78944132edc56aa7bf7c4ea240Structure a, ST_51ef6a78944132edc56aa7bf7c4ea240Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_51ef6a78944132edc56aa7bf7c4ea240Structure)) return false;
return (this == (ST_51ef6a78944132edc56aa7bf7c4ea240Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ sslocation.GetHashCode()
 ^ ssiconUrl.GetHashCode()
 ^ sstitle.GetHashCode()
 ^ sslabel.GetHashCode()
 ^ ssallowDrag.GetHashCode()
 ^ ssiconWidth.GetHashCode()
 ^ ssiconHeight.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_51ef6a78944132edc56aa7bf7c4ea240Structure Duplicate() {
ST_51ef6a78944132edc56aa7bf7c4ea240Structure t;
t.sslocation = this.sslocation;
t.ssiconUrl = this.ssiconUrl;
t.sstitle = this.sstitle;
t.sslabel = this.sslabel;
t.ssallowDrag = this.ssallowDrag;
t.ssiconWidth = this.ssiconWidth;
t.ssiconHeight = this.ssiconHeight;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "location") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".location")) variable.Value = sslocation; else variable.Optimized = true;
} else if (head == "iconurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".iconUrl")) variable.Value = ssiconUrl; else variable.Optimized = true;
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".title")) variable.Value = sstitle; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".label")) variable.Value = sslabel; else variable.Optimized = true;
} else if (head == "allowdrag") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".allowDrag")) variable.Value = ssallowDrag; else variable.Optimized = true;
} else if (head == "iconwidth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".iconWidth")) variable.Value = ssiconWidth; else variable.Optimized = true;
} else if (head == "iconheight") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".iconHeight")) variable.Value = ssiconHeight; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == Idlocation) {
return sslocation;
}
if (key == IdiconUrl) {
return ssiconUrl;
}
if (key == Idtitle) {
return sstitle;
}
if (key == Idlabel) {
return sslabel;
}
if (key == IdallowDrag) {
return ssallowDrag;
}
if (key == IdiconWidth) {
return ssiconWidth;
}
if (key == IdiconHeight) {
return ssiconHeight;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idlocation.Key.AsGuid) {
return sslocation;
}
if (attributeKey == IdiconUrl.Key.AsGuid) {
return ssiconUrl;
}
if (attributeKey == Idtitle.Key.AsGuid) {
return sstitle;
}
if (attributeKey == Idlabel.Key.AsGuid) {
return sslabel;
}
if (attributeKey == IdallowDrag.Key.AsGuid) {
return ssallowDrag;
}
if (attributeKey == IdiconWidth.Key.AsGuid) {
return ssiconWidth;
}
if (attributeKey == IdiconHeight.Key.AsGuid) {
return ssiconHeight;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
sslocation = (string) other.AttributeGet(Idlocation);
ssiconUrl = (string) other.AttributeGet(IdiconUrl);
sstitle = (string) other.AttributeGet(Idtitle);
sslabel = (string) other.AttributeGet(Idlabel);
ssallowDrag = (bool) other.AttributeGet(IdallowDrag);
ssiconWidth = (string) other.AttributeGet(IdiconWidth);
ssiconHeight = (string) other.AttributeGet(IdiconHeight);
}
} // ST_51ef6a78944132edc56aa7bf7c4ea240Structure
/// <summary>
/// RecordList type <code>Internal_to_provider_marker_configsList</code> that represents a record list
///  of <code>Internal_to_provider_marker_configs</code>
/// </summary>
public partial class RL_61f987775598f16873dffb86d0b27a55 : GenericRecordList<ST_51ef6a78944132edc56aa7bf7c4ea240Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_51ef6a78944132edc56aa7bf7c4ea240Structure GetElementDefaultValue() {
return new ST_51ef6a78944132edc56aa7bf7c4ea240Structure();
}

public T[] ToArray<T>(Func<ST_51ef6a78944132edc56aa7bf7c4ea240Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_61f987775598f16873dffb86d0b27a55 recordList, Func<ST_51ef6a78944132edc56aa7bf7c4ea240Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_61f987775598f16873dffb86d0b27a55(ST_51ef6a78944132edc56aa7bf7c4ea240Structure[] array) {
  RL_61f987775598f16873dffb86d0b27a55 result = new RL_61f987775598f16873dffb86d0b27a55();
result.InnerFromArray(array);
    return result;
}

public static RL_61f987775598f16873dffb86d0b27a55 ToList<T>(T[] array, Func <T, ST_51ef6a78944132edc56aa7bf7c4ea240Structure> converter) {
  RL_61f987775598f16873dffb86d0b27a55 result = new RL_61f987775598f16873dffb86d0b27a55();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_61f987775598f16873dffb86d0b27a55 FromRestList<T>(RestList<T> restList, Func <T, ST_51ef6a78944132edc56aa7bf7c4ea240Structure> converter) {
  RL_61f987775598f16873dffb86d0b27a55 result = new RL_61f987775598f16873dffb86d0b27a55();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_61f987775598f16873dffb86d0b27a55() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_51ef6a78944132edc56aa7bf7c4ea240Structure> NewList() {
return new RL_61f987775598f16873dffb86d0b27a55();
}


} // RL_61f987775598f16873dffb86d0b27a55
}

