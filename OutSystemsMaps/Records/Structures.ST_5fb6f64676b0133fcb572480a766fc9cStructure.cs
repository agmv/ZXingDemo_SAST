namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Bounds (tcHpctxpOEG9FC5xgN1Cew)
///  <code>ST_5fb6f64676b0133fcb572480a766fc9cStructure</code> that represents <code>Bounds</code
/// > <p>Description: Structure that helps defining the bounds of the Rectangle shape.</p>
/// </summary>
// Name: Bounds
public partial struct ST_5fb6f64676b0133fcb572480a766fc9cStructure : ITypedRecord<ST_5fb6f64676b0133fcb572480a766fc9cStructure> {
internal static readonly GlobalObjectKey IdNorth = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Vny3BTjwQ0uROUzE50fCEg");
internal static readonly GlobalObjectKey IdSouth = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*OOOf15O7dkCWqYB4DEYRjQ");
internal static readonly GlobalObjectKey IdWest = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*nnBXiy3p7Ui8brzXQ+5zyQ");
internal static readonly GlobalObjectKey IdEast = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*NK7rXgXjIEy_GqIx9s60Bg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("North")]
public string ssNorth;

[System.Xml.Serialization.XmlElement("South")]
public string ssSouth;

[System.Xml.Serialization.XmlElement("West")]
public string ssWest;

[System.Xml.Serialization.XmlElement("East")]
public string ssEast;


public BitArray OptimizedAttributes;

public ST_5fb6f64676b0133fcb572480a766fc9cStructure() {
OptimizedAttributes = null;
ssNorth = "";
ssSouth = "";
ssWest = "";
ssEast = "";
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
ssNorth = r.ReadText(index++, "Bounds.North", "");
ssSouth = r.ReadText(index++, "Bounds.South", "");
ssWest = r.ReadText(index++, "Bounds.West", "");
ssEast = r.ReadText(index++, "Bounds.East", "");
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
public void ReadIM(ST_5fb6f64676b0133fcb572480a766fc9cStructure r) {
this = r;
}


public static bool operator == (ST_5fb6f64676b0133fcb572480a766fc9cStructure a, ST_5fb6f64676b0133fcb572480a766fc9cStructure b) {
if (a.ssNorth != b.ssNorth) return false;
if (a.ssSouth != b.ssSouth) return false;
if (a.ssWest != b.ssWest) return false;
if (a.ssEast != b.ssEast) return false;
return true;
}

public static bool operator != (ST_5fb6f64676b0133fcb572480a766fc9cStructure a, ST_5fb6f64676b0133fcb572480a766fc9cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5fb6f64676b0133fcb572480a766fc9cStructure)) return false;
return (this == (ST_5fb6f64676b0133fcb572480a766fc9cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssNorth.GetHashCode()
 ^ ssSouth.GetHashCode()
 ^ ssWest.GetHashCode()
 ^ ssEast.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_5fb6f64676b0133fcb572480a766fc9cStructure Duplicate() {
ST_5fb6f64676b0133fcb572480a766fc9cStructure t;
t.ssNorth = this.ssNorth;
t.ssSouth = this.ssSouth;
t.ssWest = this.ssWest;
t.ssEast = this.ssEast;
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
if (head == "north") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".North")) variable.Value = ssNorth; else variable.Optimized = true;
} else if (head == "south") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".South")) variable.Value = ssSouth; else variable.Optimized = true;
} else if (head == "west") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".West")) variable.Value = ssWest; else variable.Optimized = true;
} else if (head == "east") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".East")) variable.Value = ssEast; else variable.Optimized = true;
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
if (key == IdNorth) {
return ssNorth;
}
if (key == IdSouth) {
return ssSouth;
}
if (key == IdWest) {
return ssWest;
}
if (key == IdEast) {
return ssEast;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNorth.Key.AsGuid) {
return ssNorth;
}
if (attributeKey == IdSouth.Key.AsGuid) {
return ssSouth;
}
if (attributeKey == IdWest.Key.AsGuid) {
return ssWest;
}
if (attributeKey == IdEast.Key.AsGuid) {
return ssEast;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssNorth = (string) other.AttributeGet(IdNorth);
ssSouth = (string) other.AttributeGet(IdSouth);
ssWest = (string) other.AttributeGet(IdWest);
ssEast = (string) other.AttributeGet(IdEast);
}
} // ST_5fb6f64676b0133fcb572480a766fc9cStructure
/// <summary>
/// RecordList type <code>BoundsList</code> that represents a record list of <code>Bounds</code>
/// </summary>
public partial class RL_524f6964155c0065c42f035c25e7b580 : GenericRecordList<ST_5fb6f64676b0133fcb572480a766fc9cStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_5fb6f64676b0133fcb572480a766fc9cStructure GetElementDefaultValue() {
return new ST_5fb6f64676b0133fcb572480a766fc9cStructure();
}

public T[] ToArray<T>(Func<ST_5fb6f64676b0133fcb572480a766fc9cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_524f6964155c0065c42f035c25e7b580 recordList, Func<ST_5fb6f64676b0133fcb572480a766fc9cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_524f6964155c0065c42f035c25e7b580(ST_5fb6f64676b0133fcb572480a766fc9cStructure[] array) {
  RL_524f6964155c0065c42f035c25e7b580 result = new RL_524f6964155c0065c42f035c25e7b580();
result.InnerFromArray(array);
    return result;
}

public static RL_524f6964155c0065c42f035c25e7b580 ToList<T>(T[] array, Func <T, ST_5fb6f64676b0133fcb572480a766fc9cStructure> converter) {
  RL_524f6964155c0065c42f035c25e7b580 result = new RL_524f6964155c0065c42f035c25e7b580();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_524f6964155c0065c42f035c25e7b580 FromRestList<T>(RestList<T> restList, Func <T, ST_5fb6f64676b0133fcb572480a766fc9cStructure> converter) {
  RL_524f6964155c0065c42f035c25e7b580 result = new RL_524f6964155c0065c42f035c25e7b580();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_524f6964155c0065c42f035c25e7b580() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5fb6f64676b0133fcb572480a766fc9cStructure> NewList() {
return new RL_524f6964155c0065c42f035c25e7b580();
}


} // RL_524f6964155c0065c42f035c25e7b580
}

