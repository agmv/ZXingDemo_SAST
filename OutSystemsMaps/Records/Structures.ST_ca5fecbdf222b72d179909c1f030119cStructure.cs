namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_heatmapLayer_configs (aoVhSDVqRE6nT2T3keGrKA)
///  <code>ST_ca5fecbdf222b72d179909c1f030119cStructure</code> that represent
/// s <code>Internal_to_provider_heatmapLayer_configs</code> <p>Description: Set additional parameters
///  to customize the file layer behavior and functionality.</p>
/// </summary>
// Name: Internal_to_provider_heatmapLayer_configs
public partial struct ST_ca5fecbdf222b72d179909c1f030119cStructure : ITypedRecord<ST_ca5fecbdf222b72d179909c1f030119cStructure> {
internal static readonly GlobalObjectKey Idpoints = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*zHxbqNIRREe0CuzdTSj2kw");
internal static readonly GlobalObjectKey IdmaxIntensity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Dj76wE3jTEqmY3zNC_BqhQ");
internal static readonly GlobalObjectKey Idopacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*BSgA1bdw0U6oy1TVdC2jXQ");
internal static readonly GlobalObjectKey Idradius = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*aGSOp40erUm3GBzCxB4pFQ");
internal static readonly GlobalObjectKey IddissipateOnZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*8NhmIjpyZkKcDjjSQ7y7Lw");
internal static readonly GlobalObjectKey Idgradient = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*EMqGMGWi0U6qjgnZDBNmFQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("points")]
public RL_3e9d003efe19bfd5edf008a600c8d3af sspoints;

[System.Xml.Serialization.XmlElement("maxIntensity")]
public decimal ssmaxIntensity;

[System.Xml.Serialization.XmlElement("opacity")]
public decimal ssopacity;

[System.Xml.Serialization.XmlElement("radius")]
public int ssradius;

[System.Xml.Serialization.XmlElement("dissipateOnZoom")]
public bool ssdissipateOnZoom;

[System.Xml.Serialization.XmlElement("gradient")]
public BasicTypeList<string> ssgradient;


public BitArray OptimizedAttributes;

public ST_ca5fecbdf222b72d179909c1f030119cStructure() {
OptimizedAttributes = null;
sspoints = new RL_3e9d003efe19bfd5edf008a600c8d3af();
ssmaxIntensity = (new Decimal (0));
ssopacity = (new Decimal (0));
ssradius = 0;
ssdissipateOnZoom = true;
ssgradient = new BasicTypeList<string>();
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
ssmaxIntensity = r.ReadDecimal(index++, "Internal_to_provider_heatmapLayer_configs.maxIntensity", 0.0M);
ssopacity = r.ReadDecimal(index++, "Internal_to_provider_heatmapLayer_configs.opacity", 0.0M);
ssradius = r.ReadInteger(index++, "Internal_to_provider_heatmapLayer_configs.radius", 0);
ssdissipateOnZoom = r.ReadBoolean(index++, "Internal_to_provider_heatmapLayer_configs.dissipateOnZoom", false);
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
public void ReadIM(ST_ca5fecbdf222b72d179909c1f030119cStructure r) {
this = r;
}


public static bool operator == (ST_ca5fecbdf222b72d179909c1f030119cStructure a, ST_ca5fecbdf222b72d179909c1f030119cStructure b) {
if (a.sspoints != b.sspoints) return false;
if (a.ssmaxIntensity != b.ssmaxIntensity) return false;
if (a.ssopacity != b.ssopacity) return false;
if (a.ssradius != b.ssradius) return false;
if (a.ssdissipateOnZoom != b.ssdissipateOnZoom) return false;
if (a.ssgradient != b.ssgradient) return false;
return true;
}

public static bool operator != (ST_ca5fecbdf222b72d179909c1f030119cStructure a, ST_ca5fecbdf222b72d179909c1f030119cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ca5fecbdf222b72d179909c1f030119cStructure)) return false;
return (this == (ST_ca5fecbdf222b72d179909c1f030119cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ sspoints.GetHashCode()
 ^ ssmaxIntensity.GetHashCode()
 ^ ssopacity.GetHashCode()
 ^ ssradius.GetHashCode()
 ^ ssdissipateOnZoom.GetHashCode()
 ^ ssgradient.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
sspoints.RecursiveReset();
ssgradient.RecursiveReset();
}

public void InternalRecursiveSave() {
sspoints.InternalRecursiveSave();
ssgradient.InternalRecursiveSave();
}


public ST_ca5fecbdf222b72d179909c1f030119cStructure Duplicate() {
ST_ca5fecbdf222b72d179909c1f030119cStructure t;
t.sspoints = (RL_3e9d003efe19bfd5edf008a600c8d3af)this.sspoints.Duplicate();
t.ssmaxIntensity = this.ssmaxIntensity;
t.ssopacity = this.ssopacity;
t.ssradius = this.ssradius;
t.ssdissipateOnZoom = this.ssdissipateOnZoom;
t.ssgradient = (BasicTypeList<string>)this.ssgradient.Duplicate();
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
if (head == "points") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".points")) variable.Value = sspoints; else variable.Optimized = true;
variable.SetFieldName("points");
} else if (head == "maxintensity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".maxIntensity")) variable.Value = ssmaxIntensity; else variable.Optimized = true;
} else if (head == "opacity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".opacity")) variable.Value = ssopacity; else variable.Optimized = true;
} else if (head == "radius") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".radius")) variable.Value = ssradius; else variable.Optimized = true;
} else if (head == "dissipateonzoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".dissipateOnZoom")) variable.Value = ssdissipateOnZoom; else variable.Optimized = true;
} else if (head == "gradient") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".gradient")) variable.Value = ssgradient; else variable.Optimized = true;
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
if (key == Idpoints) {
return sspoints;
}
if (key == IdmaxIntensity) {
return ssmaxIntensity;
}
if (key == Idopacity) {
return ssopacity;
}
if (key == Idradius) {
return ssradius;
}
if (key == IddissipateOnZoom) {
return ssdissipateOnZoom;
}
if (key == Idgradient) {
return ssgradient;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idpoints.Key.AsGuid) {
return sspoints;
}
if (attributeKey == IdmaxIntensity.Key.AsGuid) {
return ssmaxIntensity;
}
if (attributeKey == Idopacity.Key.AsGuid) {
return ssopacity;
}
if (attributeKey == Idradius.Key.AsGuid) {
return ssradius;
}
if (attributeKey == IddissipateOnZoom.Key.AsGuid) {
return ssdissipateOnZoom;
}
if (attributeKey == Idgradient.Key.AsGuid) {
return ssgradient;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
sspoints = new RL_3e9d003efe19bfd5edf008a600c8d3af();
sspoints.FillFromOther((IOSList) other.AttributeGet(Idpoints));
ssmaxIntensity = (decimal) other.AttributeGet(IdmaxIntensity);
ssopacity = (decimal) other.AttributeGet(Idopacity);
ssradius = (int) other.AttributeGet(Idradius);
ssdissipateOnZoom = (bool) other.AttributeGet(IddissipateOnZoom);
ssgradient = new BasicTypeList<string>();
ssgradient.FillFromOther((IOSList) other.AttributeGet(Idgradient));
}
} // ST_ca5fecbdf222b72d179909c1f030119cStructure
/// <summary>
/// RecordList type <code>Internal_to_provider_heatmapLayer_configsList</code> that represents a record
///  list of <code>Internal_to_provider_heatmapLayer_configs</code>
/// </summary>
public partial class RL_077ade80c9c35d6a29f94ecd2102a671 : GenericRecordList<ST_ca5fecbdf222b72d179909c1f030119cStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_ca5fecbdf222b72d179909c1f030119cStructure GetElementDefaultValue() {
return new ST_ca5fecbdf222b72d179909c1f030119cStructure();
}

public T[] ToArray<T>(Func<ST_ca5fecbdf222b72d179909c1f030119cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_077ade80c9c35d6a29f94ecd2102a671 recordList, Func<ST_ca5fecbdf222b72d179909c1f030119cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_077ade80c9c35d6a29f94ecd2102a671(ST_ca5fecbdf222b72d179909c1f030119cStructure[] array) {
  RL_077ade80c9c35d6a29f94ecd2102a671 result = new RL_077ade80c9c35d6a29f94ecd2102a671();
result.InnerFromArray(array);
    return result;
}

public static RL_077ade80c9c35d6a29f94ecd2102a671 ToList<T>(T[] array, Func <T, ST_ca5fecbdf222b72d179909c1f030119cStructure> converter) {
  RL_077ade80c9c35d6a29f94ecd2102a671 result = new RL_077ade80c9c35d6a29f94ecd2102a671();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_077ade80c9c35d6a29f94ecd2102a671 FromRestList<T>(RestList<T> restList, Func <T, ST_ca5fecbdf222b72d179909c1f030119cStructure> converter) {
  RL_077ade80c9c35d6a29f94ecd2102a671 result = new RL_077ade80c9c35d6a29f94ecd2102a671();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_077ade80c9c35d6a29f94ecd2102a671() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ca5fecbdf222b72d179909c1f030119cStructure> NewList() {
return new RL_077ade80c9c35d6a29f94ecd2102a671();
}


} // RL_077ade80c9c35d6a29f94ecd2102a671
}

