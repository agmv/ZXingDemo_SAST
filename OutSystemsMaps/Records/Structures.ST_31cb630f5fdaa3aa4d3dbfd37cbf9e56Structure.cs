namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] SearchArea (4C55UxDftE68eEIdNB6L5Q)
///  <code>ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure</code> that represents <code>SearchArea</code
/// > <p>Description: Area where to return results (north, south, east, and west). If the bounds are
///  defined, the results returned must be within that area.</p>
/// </summary>
// Name: SearchArea
public partial struct ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure : ITypedRecord<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> {
internal static readonly GlobalObjectKey IdNorth = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*_UJXADH8ZU2E4MjkhHV4MQ");
internal static readonly GlobalObjectKey IdSouth = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*tk0+8llhkUiIv6GhWANgCA");
internal static readonly GlobalObjectKey IdWest = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*GIC+NCwvzUOmvdKaAuMJMA");
internal static readonly GlobalObjectKey IdEast = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*nJOxKEk7mkGjruiSud0Yxg");

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

public ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure() {
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
ssNorth = r.ReadText(index++, "SearchArea.North", "");
ssSouth = r.ReadText(index++, "SearchArea.South", "");
ssWest = r.ReadText(index++, "SearchArea.West", "");
ssEast = r.ReadText(index++, "SearchArea.East", "");
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
public void ReadIM(ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure r) {
this = r;
}


public static bool operator == (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure a, ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure b) {
if (a.ssNorth != b.ssNorth) return false;
if (a.ssSouth != b.ssSouth) return false;
if (a.ssWest != b.ssWest) return false;
if (a.ssEast != b.ssEast) return false;
return true;
}

public static bool operator != (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure a, ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure)) return false;
return (this == (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure)o);
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


public ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure Duplicate() {
ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure t;
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
} // ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure
/// <summary>
/// RecordList type <code>SearchAreaList</code> that represents a record list of
///  <code>SearchArea</code>
/// </summary>
public partial class RL_15a080885a824b18c40f8b64d818ce41 : GenericRecordList<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure GetElementDefaultValue() {
return new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure();
}

public T[] ToArray<T>(Func<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_15a080885a824b18c40f8b64d818ce41 recordList, Func<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_15a080885a824b18c40f8b64d818ce41(ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure[] array) {
  RL_15a080885a824b18c40f8b64d818ce41 result = new RL_15a080885a824b18c40f8b64d818ce41();
result.InnerFromArray(array);
    return result;
}

public static RL_15a080885a824b18c40f8b64d818ce41 ToList<T>(T[] array, Func <T, ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> converter) {
  RL_15a080885a824b18c40f8b64d818ce41 result = new RL_15a080885a824b18c40f8b64d818ce41();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_15a080885a824b18c40f8b64d818ce41 FromRestList<T>(RestList<T> restList, Func <T, ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> converter) {
  RL_15a080885a824b18c40f8b64d818ce41 result = new RL_15a080885a824b18c40f8b64d818ce41();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_15a080885a824b18c40f8b64d818ce41() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure> NewList() {
return new RL_15a080885a824b18c40f8b64d818ce41();
}


} // RL_15a080885a824b18c40f8b64d818ce41
}

