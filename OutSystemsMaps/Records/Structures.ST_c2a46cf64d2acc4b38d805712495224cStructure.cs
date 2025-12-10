namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Stroke (J+in9oNWxkSpnPDBs+hN2Q)
///  <code>ST_c2a46cf64d2acc4b38d805712495224cStructure</code> that represents <code>Stroke</code
/// > <p>Description: Set additional parameters to customize the shape’s stroke.</p>
/// </summary>
// Name: Stroke
public partial struct ST_c2a46cf64d2acc4b38d805712495224cStructure : ITypedRecord<ST_c2a46cf64d2acc4b38d805712495224cStructure> {
internal static readonly GlobalObjectKey IdColor = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*4WJwl8ud_kmQ1tQ3WliH+g");
internal static readonly GlobalObjectKey IdOpacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*LSUkzONQkEODPRdUAG3CGQ");
internal static readonly GlobalObjectKey IdWeight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*5VxsGmzfR0isoILvwamK7A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Color")]
public string ssColor;

[System.Xml.Serialization.XmlElement("Opacity")]
public decimal ssOpacity;

[System.Xml.Serialization.XmlElement("Weight")]
public int ssWeight;


public BitArray OptimizedAttributes;

public ST_c2a46cf64d2acc4b38d805712495224cStructure() {
OptimizedAttributes = null;
ssColor = "#000000";
ssOpacity = (((decimal)1));
ssWeight = 2;
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
ssColor = r.ReadText(index++, "Stroke.Color", "");
ssOpacity = r.ReadDecimal(index++, "Stroke.Opacity", 0.0M);
ssWeight = r.ReadInteger(index++, "Stroke.Weight", 0);
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
public void ReadIM(ST_c2a46cf64d2acc4b38d805712495224cStructure r) {
this = r;
}


public static bool operator == (ST_c2a46cf64d2acc4b38d805712495224cStructure a, ST_c2a46cf64d2acc4b38d805712495224cStructure b) {
if (a.ssColor != b.ssColor) return false;
if (a.ssOpacity != b.ssOpacity) return false;
if (a.ssWeight != b.ssWeight) return false;
return true;
}

public static bool operator != (ST_c2a46cf64d2acc4b38d805712495224cStructure a, ST_c2a46cf64d2acc4b38d805712495224cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_c2a46cf64d2acc4b38d805712495224cStructure)) return false;
return (this == (ST_c2a46cf64d2acc4b38d805712495224cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssColor.GetHashCode()
 ^ ssOpacity.GetHashCode()
 ^ ssWeight.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_c2a46cf64d2acc4b38d805712495224cStructure Duplicate() {
ST_c2a46cf64d2acc4b38d805712495224cStructure t;
t.ssColor = this.ssColor;
t.ssOpacity = this.ssOpacity;
t.ssWeight = this.ssWeight;
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
if (head == "color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Color")) variable.Value = ssColor; else variable.Optimized = true;
} else if (head == "opacity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Opacity")) variable.Value = ssOpacity; else variable.Optimized = true;
} else if (head == "weight") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weight")) variable.Value = ssWeight; else variable.Optimized = true;
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
if (key == IdColor) {
return ssColor;
}
if (key == IdOpacity) {
return ssOpacity;
}
if (key == IdWeight) {
return ssWeight;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColor.Key.AsGuid) {
return ssColor;
}
if (attributeKey == IdOpacity.Key.AsGuid) {
return ssOpacity;
}
if (attributeKey == IdWeight.Key.AsGuid) {
return ssWeight;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssColor = (string) other.AttributeGet(IdColor);
ssOpacity = (decimal) other.AttributeGet(IdOpacity);
ssWeight = (int) other.AttributeGet(IdWeight);
}
} // ST_c2a46cf64d2acc4b38d805712495224cStructure
/// <summary>
/// RecordList type <code>StrokeList</code> that represents a record list of <code>Stroke</code>
/// </summary>
public partial class RL_8cb164b27a70600521e3160acb211c45 : GenericRecordList<ST_c2a46cf64d2acc4b38d805712495224cStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_c2a46cf64d2acc4b38d805712495224cStructure GetElementDefaultValue() {
return new ST_c2a46cf64d2acc4b38d805712495224cStructure();
}

public T[] ToArray<T>(Func<ST_c2a46cf64d2acc4b38d805712495224cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8cb164b27a70600521e3160acb211c45 recordList, Func<ST_c2a46cf64d2acc4b38d805712495224cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8cb164b27a70600521e3160acb211c45(ST_c2a46cf64d2acc4b38d805712495224cStructure[] array) {
  RL_8cb164b27a70600521e3160acb211c45 result = new RL_8cb164b27a70600521e3160acb211c45();
result.InnerFromArray(array);
    return result;
}

public static RL_8cb164b27a70600521e3160acb211c45 ToList<T>(T[] array, Func <T, ST_c2a46cf64d2acc4b38d805712495224cStructure> converter) {
  RL_8cb164b27a70600521e3160acb211c45 result = new RL_8cb164b27a70600521e3160acb211c45();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8cb164b27a70600521e3160acb211c45 FromRestList<T>(RestList<T> restList, Func <T, ST_c2a46cf64d2acc4b38d805712495224cStructure> converter) {
  RL_8cb164b27a70600521e3160acb211c45 result = new RL_8cb164b27a70600521e3160acb211c45();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8cb164b27a70600521e3160acb211c45() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_c2a46cf64d2acc4b38d805712495224cStructure> NewList() {
return new RL_8cb164b27a70600521e3160acb211c45();
}


} // RL_8cb164b27a70600521e3160acb211c45
}

