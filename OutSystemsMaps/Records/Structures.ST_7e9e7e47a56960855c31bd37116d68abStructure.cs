namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] CircleShape (UDJIcrv8s0ejY42V_xUjjg)
///  <code>ST_7e9e7e47a56960855c31bd37116d68abStructure</code> that represents <code>CircleShape</code
/// > <p>Description: Structure that helps defining the shape of the Circle (contains the center
///  coordinates and radius).</p>
/// </summary>
// Name: CircleShape
public partial struct ST_7e9e7e47a56960855c31bd37116d68abStructure : ITypedRecord<ST_7e9e7e47a56960855c31bd37116d68abStructure> {
internal static readonly GlobalObjectKey IdCenter = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*ipqOKDThMEOY5b5f3V3Yrg");
internal static readonly GlobalObjectKey IdRadius = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*yrQ_qVZ+YUOUb0nQWYziJg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Center")]
public ST_0e474756a4be14d378c73cd05f602bcdStructure ssCenter;

[System.Xml.Serialization.XmlElement("Radius")]
public decimal ssRadius;


public BitArray OptimizedAttributes;

public ST_7e9e7e47a56960855c31bd37116d68abStructure() {
OptimizedAttributes = null;
ssCenter = new ST_0e474756a4be14d378c73cd05f602bcdStructure();
ssRadius = 0.0M;
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
    ssCenter.OptimizedAttributes = value[0];
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
ssRadius = r.ReadDecimal(index++, "CircleShape.Radius", 0.0M);
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
public void ReadIM(ST_7e9e7e47a56960855c31bd37116d68abStructure r) {
this = r;
}


public static bool operator == (ST_7e9e7e47a56960855c31bd37116d68abStructure a, ST_7e9e7e47a56960855c31bd37116d68abStructure b) {
if (a.ssCenter != b.ssCenter) return false;
if (a.ssRadius != b.ssRadius) return false;
return true;
}

public static bool operator != (ST_7e9e7e47a56960855c31bd37116d68abStructure a, ST_7e9e7e47a56960855c31bd37116d68abStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7e9e7e47a56960855c31bd37116d68abStructure)) return false;
return (this == (ST_7e9e7e47a56960855c31bd37116d68abStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCenter.GetHashCode()
 ^ ssRadius.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssCenter.RecursiveReset();
}

public void InternalRecursiveSave() {
ssCenter.InternalRecursiveSave();
}


public ST_7e9e7e47a56960855c31bd37116d68abStructure Duplicate() {
ST_7e9e7e47a56960855c31bd37116d68abStructure t;
t.ssCenter = (ST_0e474756a4be14d378c73cd05f602bcdStructure)this.ssCenter.Duplicate();
t.ssRadius = this.ssRadius;
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
if (head == "center") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Center")) variable.Value = ssCenter; else variable.Optimized = true;
variable.SetFieldName("center");
} else if (head == "radius") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Radius")) variable.Value = ssRadius; else variable.Optimized = true;
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
if (key == IdCenter) {
return ssCenter;
}
if (key == IdRadius) {
return ssRadius;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCenter.Key.AsGuid) {
return ssCenter;
}
if (attributeKey == IdRadius.Key.AsGuid) {
return ssRadius;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCenter.FillFromOther((IRecord) other.AttributeGet(IdCenter));
ssRadius = (decimal) other.AttributeGet(IdRadius);
}
} // ST_7e9e7e47a56960855c31bd37116d68abStructure
/// <summary>
/// RecordList type <code>CircleShapeList</code> that represents a record list of
///  <code>CircleShape</code>
/// </summary>
public partial class RL_b481a3e1f57509338918c6099fc91208 : GenericRecordList<ST_7e9e7e47a56960855c31bd37116d68abStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7e9e7e47a56960855c31bd37116d68abStructure GetElementDefaultValue() {
return new ST_7e9e7e47a56960855c31bd37116d68abStructure();
}

public T[] ToArray<T>(Func<ST_7e9e7e47a56960855c31bd37116d68abStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b481a3e1f57509338918c6099fc91208 recordList, Func<ST_7e9e7e47a56960855c31bd37116d68abStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b481a3e1f57509338918c6099fc91208(ST_7e9e7e47a56960855c31bd37116d68abStructure[] array) {
  RL_b481a3e1f57509338918c6099fc91208 result = new RL_b481a3e1f57509338918c6099fc91208();
result.InnerFromArray(array);
    return result;
}

public static RL_b481a3e1f57509338918c6099fc91208 ToList<T>(T[] array, Func <T, ST_7e9e7e47a56960855c31bd37116d68abStructure> converter) {
  RL_b481a3e1f57509338918c6099fc91208 result = new RL_b481a3e1f57509338918c6099fc91208();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b481a3e1f57509338918c6099fc91208 FromRestList<T>(RestList<T> restList, Func <T, ST_7e9e7e47a56960855c31bd37116d68abStructure> converter) {
  RL_b481a3e1f57509338918c6099fc91208 result = new RL_b481a3e1f57509338918c6099fc91208();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b481a3e1f57509338918c6099fc91208() : base() {
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
protected override OSList<ST_7e9e7e47a56960855c31bd37116d68abStructure> NewList() {
return new RL_b481a3e1f57509338918c6099fc91208();
}


} // RL_b481a3e1f57509338918c6099fc91208
}

