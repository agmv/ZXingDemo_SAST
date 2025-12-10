namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (kCnaxBP6yUiIoaTmlJp3Og)
///  <code>RC_a11b90f038b532a4625b14a0974b03a2</code> that represent
/// s <code>OptionalRectangleConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalRectangleConfigsRecord
public partial struct RC_a11b90f038b532a4625b14a0974b03a2 : ITypedRecord<RC_a11b90f038b532a4625b14a0974b03a2> {
internal static readonly GlobalObjectKey IdOptionalRectangleConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8JAbobU4pDJiWxSgl0sDog");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalRectangleConfigs")]
public ST_fbded4e930a61a57761a37f0b1ea8d40Structure ssSTOptionalRectangleConfigs;


public static implicit operator ST_fbded4e930a61a57761a37f0b1ea8d40Structure( RC_a11b90f038b532a4625b14a0974b03a2 r) {
return r.ssSTOptionalRectangleConfigs;
}

public static implicit operator RC_a11b90f038b532a4625b14a0974b03a2 (ST_fbded4e930a61a57761a37f0b1ea8d40Structure r) {
RC_a11b90f038b532a4625b14a0974b03a2 res = new RC_a11b90f038b532a4625b14a0974b03a2 ();
res.ssSTOptionalRectangleConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a11b90f038b532a4625b14a0974b03a2() {
OptimizedAttributes = null;
ssSTOptionalRectangleConfigs = new ST_fbded4e930a61a57761a37f0b1ea8d40Structure();
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
    ssSTOptionalRectangleConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalRectangleConfigs.Read( r, ref index);
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
public void ReadIM(RC_a11b90f038b532a4625b14a0974b03a2 r) {
this = r;
}


public static bool operator == (RC_a11b90f038b532a4625b14a0974b03a2 a, RC_a11b90f038b532a4625b14a0974b03a2 b) {
if (a.ssSTOptionalRectangleConfigs != b.ssSTOptionalRectangleConfigs) return false;
return true;
}

public static bool operator != (RC_a11b90f038b532a4625b14a0974b03a2 a, RC_a11b90f038b532a4625b14a0974b03a2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a11b90f038b532a4625b14a0974b03a2)) return false;
return (this == (RC_a11b90f038b532a4625b14a0974b03a2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalRectangleConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalRectangleConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalRectangleConfigs.InternalRecursiveSave();
}


public RC_a11b90f038b532a4625b14a0974b03a2 Duplicate() {
RC_a11b90f038b532a4625b14a0974b03a2 t;
t.ssSTOptionalRectangleConfigs = (ST_fbded4e930a61a57761a37f0b1ea8d40Structure)this.ssSTOptionalRectangleConfigs.Duplicate();
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
if (head == "optionalrectangleconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalRectangleConfigs")) variable.Value = ssSTOptionalRectangleConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalrectangleconfigs");
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
if (key == IdOptionalRectangleConfigs) {
return ssSTOptionalRectangleConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalRectangleConfigs.Key.AsGuid) {
return ssSTOptionalRectangleConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalRectangleConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalRectangleConfigs));
}
} // RC_a11b90f038b532a4625b14a0974b03a2
/// <summary>
/// RecordList type <code>OptionalRectangleConfigsRecordList</code> that represents a record list of
///  <code>OptionalRectangleConfigs</code>
/// </summary>
public partial class RL_031760b0a286b19e96249006302a6d77 : GenericRecordList<RC_a11b90f038b532a4625b14a0974b03a2>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a11b90f038b532a4625b14a0974b03a2 GetElementDefaultValue() {
return new RC_a11b90f038b532a4625b14a0974b03a2();
}

public T[] ToArray<T>(Func<RC_a11b90f038b532a4625b14a0974b03a2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_031760b0a286b19e96249006302a6d77 recordList, Func<RC_a11b90f038b532a4625b14a0974b03a2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_031760b0a286b19e96249006302a6d77(RC_a11b90f038b532a4625b14a0974b03a2[] array) {
  RL_031760b0a286b19e96249006302a6d77 result = new RL_031760b0a286b19e96249006302a6d77();
result.InnerFromArray(array);
    return result;
}

public static RL_031760b0a286b19e96249006302a6d77 ToList<T>(T[] array, Func <T, RC_a11b90f038b532a4625b14a0974b03a2> converter) {
  RL_031760b0a286b19e96249006302a6d77 result = new RL_031760b0a286b19e96249006302a6d77();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_031760b0a286b19e96249006302a6d77 FromRestList<T>(RestList<T> restList, Func <T, RC_a11b90f038b532a4625b14a0974b03a2> converter) {
  RL_031760b0a286b19e96249006302a6d77 result = new RL_031760b0a286b19e96249006302a6d77();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_031760b0a286b19e96249006302a6d77() : base() {
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
protected override OSList<RC_a11b90f038b532a4625b14a0974b03a2> NewList() {
return new RL_031760b0a286b19e96249006302a6d77();
}


} // RL_031760b0a286b19e96249006302a6d77
}

