namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalCircleConfigs (KWqANzca0UqgnF3a_3P4YQ)
///  <code>ST_9a87c036f8540c84242b92bb54609014Structure</code> that represent
/// s <code>OptionalCircleConfigs</code> <p>Description: Set additional parameters to customize the
///  circle’s behavior and functionality.</p>
/// </summary>
// Name: OptionalCircleConfigs
public partial struct ST_9a87c036f8540c84242b92bb54609014Structure : ITypedRecord<ST_9a87c036f8540c84242b92bb54609014Structure> {
internal static readonly GlobalObjectKey IdAllowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*k0cOfsEFwEuqaTLf_vdzEQ");
internal static readonly GlobalObjectKey IdAllowEdit = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*GCHem6RQrE6v67UYdbZn3Q");
internal static readonly GlobalObjectKey IdStroke = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*VhwRiWcaVUaVds2ibRMWxw");
internal static readonly GlobalObjectKey IdFill = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*nhFGCb2nSEe3VyUTbW5+Kw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AllowDrag")]
public bool ssAllowDrag;

[System.Xml.Serialization.XmlElement("AllowEdit")]
public bool ssAllowEdit;

[System.Xml.Serialization.XmlElement("Stroke")]
public ST_c2a46cf64d2acc4b38d805712495224cStructure ssStroke;

[System.Xml.Serialization.XmlElement("Fill")]
public ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure ssFill;


public BitArray OptimizedAttributes;

public ST_9a87c036f8540c84242b92bb54609014Structure() {
OptimizedAttributes = null;
ssAllowDrag = false;
ssAllowEdit = false;
ssStroke = new ST_c2a46cf64d2acc4b38d805712495224cStructure();
ssFill = new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssStroke.OptimizedAttributes = value[0];
    ssFill.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssAllowDrag = r.ReadBoolean(index++, "OptionalCircleConfigs.AllowDrag", false);
ssAllowEdit = r.ReadBoolean(index++, "OptionalCircleConfigs.AllowEdit", false);
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
public void ReadIM(ST_9a87c036f8540c84242b92bb54609014Structure r) {
this = r;
}


public static bool operator == (ST_9a87c036f8540c84242b92bb54609014Structure a, ST_9a87c036f8540c84242b92bb54609014Structure b) {
if (a.ssAllowDrag != b.ssAllowDrag) return false;
if (a.ssAllowEdit != b.ssAllowEdit) return false;
if (a.ssStroke != b.ssStroke) return false;
if (a.ssFill != b.ssFill) return false;
return true;
}

public static bool operator != (ST_9a87c036f8540c84242b92bb54609014Structure a, ST_9a87c036f8540c84242b92bb54609014Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9a87c036f8540c84242b92bb54609014Structure)) return false;
return (this == (ST_9a87c036f8540c84242b92bb54609014Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAllowDrag.GetHashCode()
 ^ ssAllowEdit.GetHashCode()
 ^ ssStroke.GetHashCode()
 ^ ssFill.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssStroke.RecursiveReset();
ssFill.RecursiveReset();
}

public void InternalRecursiveSave() {
ssStroke.InternalRecursiveSave();
ssFill.InternalRecursiveSave();
}


public ST_9a87c036f8540c84242b92bb54609014Structure Duplicate() {
ST_9a87c036f8540c84242b92bb54609014Structure t;
t.ssAllowDrag = this.ssAllowDrag;
t.ssAllowEdit = this.ssAllowEdit;
t.ssStroke = (ST_c2a46cf64d2acc4b38d805712495224cStructure)this.ssStroke.Duplicate();
t.ssFill = (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure)this.ssFill.Duplicate();
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
if (head == "allowdrag") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllowDrag")) variable.Value = ssAllowDrag; else variable.Optimized = true;
} else if (head == "allowedit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllowEdit")) variable.Value = ssAllowEdit; else variable.Optimized = true;
} else if (head == "stroke") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Stroke")) variable.Value = ssStroke; else variable.Optimized = true;
variable.SetFieldName("stroke");
} else if (head == "fill") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fill")) variable.Value = ssFill; else variable.Optimized = true;
variable.SetFieldName("fill");
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
if (key == IdAllowDrag) {
return ssAllowDrag;
}
if (key == IdAllowEdit) {
return ssAllowEdit;
}
if (key == IdStroke) {
return ssStroke;
}
if (key == IdFill) {
return ssFill;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAllowDrag.Key.AsGuid) {
return ssAllowDrag;
}
if (attributeKey == IdAllowEdit.Key.AsGuid) {
return ssAllowEdit;
}
if (attributeKey == IdStroke.Key.AsGuid) {
return ssStroke;
}
if (attributeKey == IdFill.Key.AsGuid) {
return ssFill;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAllowDrag = (bool) other.AttributeGet(IdAllowDrag);
ssAllowEdit = (bool) other.AttributeGet(IdAllowEdit);
ssStroke.FillFromOther((IRecord) other.AttributeGet(IdStroke));
ssFill.FillFromOther((IRecord) other.AttributeGet(IdFill));
}
} // ST_9a87c036f8540c84242b92bb54609014Structure
/// <summary>
/// RecordList type <code>OptionalCircleConfigsList</code> that represents a record list of
///  <code>OptionalCircleConfigs</code>
/// </summary>
public partial class RL_f7d09f5b5f749dd750fd11763217536f : GenericRecordList<ST_9a87c036f8540c84242b92bb54609014Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_9a87c036f8540c84242b92bb54609014Structure GetElementDefaultValue() {
return new ST_9a87c036f8540c84242b92bb54609014Structure();
}

public T[] ToArray<T>(Func<ST_9a87c036f8540c84242b92bb54609014Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f7d09f5b5f749dd750fd11763217536f recordList, Func<ST_9a87c036f8540c84242b92bb54609014Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f7d09f5b5f749dd750fd11763217536f(ST_9a87c036f8540c84242b92bb54609014Structure[] array) {
  RL_f7d09f5b5f749dd750fd11763217536f result = new RL_f7d09f5b5f749dd750fd11763217536f();
result.InnerFromArray(array);
    return result;
}

public static RL_f7d09f5b5f749dd750fd11763217536f ToList<T>(T[] array, Func <T, ST_9a87c036f8540c84242b92bb54609014Structure> converter) {
  RL_f7d09f5b5f749dd750fd11763217536f result = new RL_f7d09f5b5f749dd750fd11763217536f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f7d09f5b5f749dd750fd11763217536f FromRestList<T>(RestList<T> restList, Func <T, ST_9a87c036f8540c84242b92bb54609014Structure> converter) {
  RL_f7d09f5b5f749dd750fd11763217536f result = new RL_f7d09f5b5f749dd750fd11763217536f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f7d09f5b5f749dd750fd11763217536f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = null;
def[1] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9a87c036f8540c84242b92bb54609014Structure> NewList() {
return new RL_f7d09f5b5f749dd750fd11763217536f();
}


} // RL_f7d09f5b5f749dd750fd11763217536f
}

