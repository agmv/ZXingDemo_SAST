namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalPolylineConfigs (bufMu+B4h0iY_mjF6UNYwQ)
///  <code>ST_f85923824a33f65ded14770af5377402Structure</code> that represent
/// s <code>OptionalPolylineConfigs</code> <p>Description: Set additional parameters to customize the
///  polyline's behavior and functionality.</p>
/// </summary>
// Name: OptionalPolylineConfigs
public partial struct ST_f85923824a33f65ded14770af5377402Structure : ITypedRecord<ST_f85923824a33f65ded14770af5377402Structure> {
internal static readonly GlobalObjectKey IdAllowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*l1vD+XCMLE2IrZ9RDMgThQ");
internal static readonly GlobalObjectKey IdAllowEdit = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*_vQ0AKOz1Ei_I8lEz05urQ");
internal static readonly GlobalObjectKey IdStroke = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*3_Wda8NWUE2fwz5yU3KOYg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AllowDrag")]
public bool ssAllowDrag;

[System.Xml.Serialization.XmlElement("AllowEdit")]
public bool ssAllowEdit;

[System.Xml.Serialization.XmlElement("Stroke")]
public ST_c2a46cf64d2acc4b38d805712495224cStructure ssStroke;


public BitArray OptimizedAttributes;

public ST_f85923824a33f65ded14770af5377402Structure() {
OptimizedAttributes = null;
ssAllowDrag = false;
ssAllowEdit = false;
ssStroke = new ST_c2a46cf64d2acc4b38d805712495224cStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssStroke.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssAllowDrag = r.ReadBoolean(index++, "OptionalPolylineConfigs.AllowDrag", false);
ssAllowEdit = r.ReadBoolean(index++, "OptionalPolylineConfigs.AllowEdit", false);
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
public void ReadIM(ST_f85923824a33f65ded14770af5377402Structure r) {
this = r;
}


public static bool operator == (ST_f85923824a33f65ded14770af5377402Structure a, ST_f85923824a33f65ded14770af5377402Structure b) {
if (a.ssAllowDrag != b.ssAllowDrag) return false;
if (a.ssAllowEdit != b.ssAllowEdit) return false;
if (a.ssStroke != b.ssStroke) return false;
return true;
}

public static bool operator != (ST_f85923824a33f65ded14770af5377402Structure a, ST_f85923824a33f65ded14770af5377402Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f85923824a33f65ded14770af5377402Structure)) return false;
return (this == (ST_f85923824a33f65ded14770af5377402Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAllowDrag.GetHashCode()
 ^ ssAllowEdit.GetHashCode()
 ^ ssStroke.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssStroke.RecursiveReset();
}

public void InternalRecursiveSave() {
ssStroke.InternalRecursiveSave();
}


public ST_f85923824a33f65ded14770af5377402Structure Duplicate() {
ST_f85923824a33f65ded14770af5377402Structure t;
t.ssAllowDrag = this.ssAllowDrag;
t.ssAllowEdit = this.ssAllowEdit;
t.ssStroke = (ST_c2a46cf64d2acc4b38d805712495224cStructure)this.ssStroke.Duplicate();
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAllowDrag = (bool) other.AttributeGet(IdAllowDrag);
ssAllowEdit = (bool) other.AttributeGet(IdAllowEdit);
ssStroke.FillFromOther((IRecord) other.AttributeGet(IdStroke));
}
} // ST_f85923824a33f65ded14770af5377402Structure
/// <summary>
/// RecordList type <code>OptionalPolylineConfigsList</code> that represents a record list of
///  <code>OptionalPolylineConfigs</code>
/// </summary>
public partial class RL_7abacef66f8c8ee19e972f9405ffd4ae : GenericRecordList<ST_f85923824a33f65ded14770af5377402Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_f85923824a33f65ded14770af5377402Structure GetElementDefaultValue() {
return new ST_f85923824a33f65ded14770af5377402Structure();
}

public T[] ToArray<T>(Func<ST_f85923824a33f65ded14770af5377402Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7abacef66f8c8ee19e972f9405ffd4ae recordList, Func<ST_f85923824a33f65ded14770af5377402Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7abacef66f8c8ee19e972f9405ffd4ae(ST_f85923824a33f65ded14770af5377402Structure[] array) {
  RL_7abacef66f8c8ee19e972f9405ffd4ae result = new RL_7abacef66f8c8ee19e972f9405ffd4ae();
result.InnerFromArray(array);
    return result;
}

public static RL_7abacef66f8c8ee19e972f9405ffd4ae ToList<T>(T[] array, Func <T, ST_f85923824a33f65ded14770af5377402Structure> converter) {
  RL_7abacef66f8c8ee19e972f9405ffd4ae result = new RL_7abacef66f8c8ee19e972f9405ffd4ae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7abacef66f8c8ee19e972f9405ffd4ae FromRestList<T>(RestList<T> restList, Func <T, ST_f85923824a33f65ded14770af5377402Structure> converter) {
  RL_7abacef66f8c8ee19e972f9405ffd4ae result = new RL_7abacef66f8c8ee19e972f9405ffd4ae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7abacef66f8c8ee19e972f9405ffd4ae() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f85923824a33f65ded14770af5377402Structure> NewList() {
return new RL_7abacef66f8c8ee19e972f9405ffd4ae();
}


} // RL_7abacef66f8c8ee19e972f9405ffd4ae
}

