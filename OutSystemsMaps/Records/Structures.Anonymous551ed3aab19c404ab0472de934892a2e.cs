namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (qtMeVZyxSkCwRy3pNIkqLg)
///  <code>RC_a9d171af5978fe3e4b7ef9f38c0c5a39</code> that represents <code>VerbosityRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: VerbosityRecord
public partial struct RC_a9d171af5978fe3e4b7ef9f38c0c5a39 : ITypedRecord<RC_a9d171af5978fe3e4b7ef9f38c0c5a39> {
internal static readonly GlobalObjectKey IdVerbosity = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*r3HRqXhZPv5LfvnzjAxaOQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Verbosity")]
public EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord ssENVerbosity;


public static implicit operator EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord( RC_a9d171af5978fe3e4b7ef9f38c0c5a39 r) {
return r.ssENVerbosity;
}

public static implicit operator RC_a9d171af5978fe3e4b7ef9f38c0c5a39 (EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord r) {
RC_a9d171af5978fe3e4b7ef9f38c0c5a39 res = new RC_a9d171af5978fe3e4b7ef9f38c0c5a39 ();
res.ssENVerbosity = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENVerbosity.ChangedAttributes = value;
}
get {
    return ssENVerbosity.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a9d171af5978fe3e4b7ef9f38c0c5a39() {
OptimizedAttributes = null;
ssENVerbosity = new EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENVerbosity.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENVerbosity.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENVerbosity.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENVerbosity.Read( r, ref index);
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
public void ReadIM(RC_a9d171af5978fe3e4b7ef9f38c0c5a39 r) {
this = r;
}


public static bool operator == (RC_a9d171af5978fe3e4b7ef9f38c0c5a39 a, RC_a9d171af5978fe3e4b7ef9f38c0c5a39 b) {
if (a.ssENVerbosity != b.ssENVerbosity) return false;
return true;
}

public static bool operator != (RC_a9d171af5978fe3e4b7ef9f38c0c5a39 a, RC_a9d171af5978fe3e4b7ef9f38c0c5a39 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a9d171af5978fe3e4b7ef9f38c0c5a39)) return false;
return (this == (RC_a9d171af5978fe3e4b7ef9f38c0c5a39)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENVerbosity.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENVerbosity.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENVerbosity.InternalRecursiveSave();
}


public RC_a9d171af5978fe3e4b7ef9f38c0c5a39 Duplicate() {
RC_a9d171af5978fe3e4b7ef9f38c0c5a39 t;
t.ssENVerbosity = (EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord)this.ssENVerbosity.Duplicate();
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
if (head == "verbosity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Verbosity")) variable.Value = ssENVerbosity; else variable.Optimized = true;
variable.SetFieldName("verbosity");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENVerbosity.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENVerbosity.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdVerbosity) {
return ssENVerbosity;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdVerbosity.Key.AsGuid) {
return ssENVerbosity;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENVerbosity.FillFromOther((IRecord) other.AttributeGet(IdVerbosity));
}
} // RC_a9d171af5978fe3e4b7ef9f38c0c5a39
/// <summary>
/// RecordList type <code>VerbosityRecordList</code> that represents a record list of
///  <code>Verbosity</code>
/// </summary>
public partial class RL_62d317376210e901ee40f919c9f80100 : GenericRecordList<RC_a9d171af5978fe3e4b7ef9f38c0c5a39>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a9d171af5978fe3e4b7ef9f38c0c5a39 GetElementDefaultValue() {
return new RC_a9d171af5978fe3e4b7ef9f38c0c5a39();
}

public T[] ToArray<T>(Func<RC_a9d171af5978fe3e4b7ef9f38c0c5a39, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_62d317376210e901ee40f919c9f80100 recordList, Func<RC_a9d171af5978fe3e4b7ef9f38c0c5a39, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_62d317376210e901ee40f919c9f80100(RC_a9d171af5978fe3e4b7ef9f38c0c5a39[] array) {
  RL_62d317376210e901ee40f919c9f80100 result = new RL_62d317376210e901ee40f919c9f80100();
result.InnerFromArray(array);
    return result;
}

public static RL_62d317376210e901ee40f919c9f80100 ToList<T>(T[] array, Func <T, RC_a9d171af5978fe3e4b7ef9f38c0c5a39> converter) {
  RL_62d317376210e901ee40f919c9f80100 result = new RL_62d317376210e901ee40f919c9f80100();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_62d317376210e901ee40f919c9f80100 FromRestList<T>(RestList<T> restList, Func <T, RC_a9d171af5978fe3e4b7ef9f38c0c5a39> converter) {
  RL_62d317376210e901ee40f919c9f80100 result = new RL_62d317376210e901ee40f919c9f80100();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_62d317376210e901ee40f919c9f80100() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a9d171af5978fe3e4b7ef9f38c0c5a39> NewList() {
return new RL_62d317376210e901ee40f919c9f80100();
}


} // RL_62d317376210e901ee40f919c9f80100
}

