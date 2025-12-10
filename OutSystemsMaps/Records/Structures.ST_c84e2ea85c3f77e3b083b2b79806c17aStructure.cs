namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalHeatmapLayerConfigs (pu6qx994h0eDhljil91Z9w)
///  <code>ST_c84e2ea85c3f77e3b083b2b79806c17aStructure</code> that represent
/// s <code>OptionalHeatmapLayerConfigs</code> <p>Description: Set additional parameters to customize
///  the file layer behavior and functionality.</p>
/// </summary>
// Name: OptionalHeatmapLayerConfigs
public partial struct ST_c84e2ea85c3f77e3b083b2b79806c17aStructure : ITypedRecord<ST_c84e2ea85c3f77e3b083b2b79806c17aStructure> {
internal static readonly GlobalObjectKey IdMaxIntensity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*MyOBsh2MRU2ehZ3dgG1PUQ");
internal static readonly GlobalObjectKey IdOpacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*GhPBbXu7JUGl3iOTCs9E3w");
internal static readonly GlobalObjectKey IdRadius = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*BM0eCCreT0G5wJbqwj2g8A");
internal static readonly GlobalObjectKey IdDissipateOnZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*GdtU9nlxwESH200qQm4sIw");
internal static readonly GlobalObjectKey IdGradient = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*fhuLclG97Ea3l14TILsfzw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MaxIntensity")]
public decimal ssMaxIntensity;

[System.Xml.Serialization.XmlElement("Opacity")]
public decimal ssOpacity;

[System.Xml.Serialization.XmlElement("Radius")]
public int ssRadius;

[System.Xml.Serialization.XmlElement("DissipateOnZoom")]
public bool ssDissipateOnZoom;

[System.Xml.Serialization.XmlElement("Gradient")]
public BasicTypeList<string> ssGradient;


public BitArray OptimizedAttributes;

public ST_c84e2ea85c3f77e3b083b2b79806c17aStructure() {
OptimizedAttributes = null;
ssMaxIntensity = 0.0M;
ssOpacity = 0.6m;
ssRadius = 3;
ssDissipateOnZoom = true;
ssGradient = new BasicTypeList<string>();
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
ssMaxIntensity = r.ReadDecimal(index++, "OptionalHeatmapLayerConfigs.MaxIntensity", 0.0M);
ssOpacity = r.ReadDecimal(index++, "OptionalHeatmapLayerConfigs.Opacity", 0.0M);
ssRadius = r.ReadInteger(index++, "OptionalHeatmapLayerConfigs.Radius", 0);
ssDissipateOnZoom = r.ReadBoolean(index++, "OptionalHeatmapLayerConfigs.DissipateOnZoom", false);
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
public void ReadIM(ST_c84e2ea85c3f77e3b083b2b79806c17aStructure r) {
this = r;
}


public static bool operator == (ST_c84e2ea85c3f77e3b083b2b79806c17aStructure a, ST_c84e2ea85c3f77e3b083b2b79806c17aStructure b) {
if (a.ssMaxIntensity != b.ssMaxIntensity) return false;
if (a.ssOpacity != b.ssOpacity) return false;
if (a.ssRadius != b.ssRadius) return false;
if (a.ssDissipateOnZoom != b.ssDissipateOnZoom) return false;
if (a.ssGradient != b.ssGradient) return false;
return true;
}

public static bool operator != (ST_c84e2ea85c3f77e3b083b2b79806c17aStructure a, ST_c84e2ea85c3f77e3b083b2b79806c17aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_c84e2ea85c3f77e3b083b2b79806c17aStructure)) return false;
return (this == (ST_c84e2ea85c3f77e3b083b2b79806c17aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMaxIntensity.GetHashCode()
 ^ ssOpacity.GetHashCode()
 ^ ssRadius.GetHashCode()
 ^ ssDissipateOnZoom.GetHashCode()
 ^ ssGradient.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssGradient.RecursiveReset();
}

public void InternalRecursiveSave() {
ssGradient.InternalRecursiveSave();
}


public ST_c84e2ea85c3f77e3b083b2b79806c17aStructure Duplicate() {
ST_c84e2ea85c3f77e3b083b2b79806c17aStructure t;
t.ssMaxIntensity = this.ssMaxIntensity;
t.ssOpacity = this.ssOpacity;
t.ssRadius = this.ssRadius;
t.ssDissipateOnZoom = this.ssDissipateOnZoom;
t.ssGradient = (BasicTypeList<string>)this.ssGradient.Duplicate();
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
if (head == "maxintensity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxIntensity")) variable.Value = ssMaxIntensity; else variable.Optimized = true;
} else if (head == "opacity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Opacity")) variable.Value = ssOpacity; else variable.Optimized = true;
} else if (head == "radius") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Radius")) variable.Value = ssRadius; else variable.Optimized = true;
} else if (head == "dissipateonzoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DissipateOnZoom")) variable.Value = ssDissipateOnZoom; else variable.Optimized = true;
} else if (head == "gradient") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Gradient")) variable.Value = ssGradient; else variable.Optimized = true;
variable.SetFieldName("gradient");
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
if (key == IdMaxIntensity) {
return ssMaxIntensity;
}
if (key == IdOpacity) {
return ssOpacity;
}
if (key == IdRadius) {
return ssRadius;
}
if (key == IdDissipateOnZoom) {
return ssDissipateOnZoom;
}
if (key == IdGradient) {
return ssGradient;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMaxIntensity.Key.AsGuid) {
return ssMaxIntensity;
}
if (attributeKey == IdOpacity.Key.AsGuid) {
return ssOpacity;
}
if (attributeKey == IdRadius.Key.AsGuid) {
return ssRadius;
}
if (attributeKey == IdDissipateOnZoom.Key.AsGuid) {
return ssDissipateOnZoom;
}
if (attributeKey == IdGradient.Key.AsGuid) {
return ssGradient;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssMaxIntensity = (decimal) other.AttributeGet(IdMaxIntensity);
ssOpacity = (decimal) other.AttributeGet(IdOpacity);
ssRadius = (int) other.AttributeGet(IdRadius);
ssDissipateOnZoom = (bool) other.AttributeGet(IdDissipateOnZoom);
ssGradient = new BasicTypeList<string>();
ssGradient.FillFromOther((IOSList) other.AttributeGet(IdGradient));
}
} // ST_c84e2ea85c3f77e3b083b2b79806c17aStructure
/// <summary>
/// RecordList type <code>OptionalHeatmapLayerConfigsList</code> that represents a record list of
///  <code>OptionalHeatmapLayerConfigs</code>
/// </summary>
public partial class RL_815d85007a1f216f0067d3825a34d1a7 : GenericRecordList<ST_c84e2ea85c3f77e3b083b2b79806c17aStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_c84e2ea85c3f77e3b083b2b79806c17aStructure GetElementDefaultValue() {
return new ST_c84e2ea85c3f77e3b083b2b79806c17aStructure();
}

public T[] ToArray<T>(Func<ST_c84e2ea85c3f77e3b083b2b79806c17aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_815d85007a1f216f0067d3825a34d1a7 recordList, Func<ST_c84e2ea85c3f77e3b083b2b79806c17aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_815d85007a1f216f0067d3825a34d1a7(ST_c84e2ea85c3f77e3b083b2b79806c17aStructure[] array) {
  RL_815d85007a1f216f0067d3825a34d1a7 result = new RL_815d85007a1f216f0067d3825a34d1a7();
result.InnerFromArray(array);
    return result;
}

public static RL_815d85007a1f216f0067d3825a34d1a7 ToList<T>(T[] array, Func <T, ST_c84e2ea85c3f77e3b083b2b79806c17aStructure> converter) {
  RL_815d85007a1f216f0067d3825a34d1a7 result = new RL_815d85007a1f216f0067d3825a34d1a7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_815d85007a1f216f0067d3825a34d1a7 FromRestList<T>(RestList<T> restList, Func <T, ST_c84e2ea85c3f77e3b083b2b79806c17aStructure> converter) {
  RL_815d85007a1f216f0067d3825a34d1a7 result = new RL_815d85007a1f216f0067d3825a34d1a7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_815d85007a1f216f0067d3825a34d1a7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_c84e2ea85c3f77e3b083b2b79806c17aStructure> NewList() {
return new RL_815d85007a1f216f0067d3825a34d1a7();
}


} // RL_815d85007a1f216f0067d3825a34d1a7
}

