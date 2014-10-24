using System;

namespace Machine.Specifications.Runner
{
  [Serializable]
  public class SpecificationInfo
  {
    public SpecificationInfo(string leader, string name, string containingType, string fieldName, string assemblyName)
    {
      Leader = leader;
      Name = name;
      ContainingType = containingType;
      FieldName = fieldName;
      AssemblyName = assemblyName;
    }

    public string Leader { get; set; }
    public string Name { get; set; }
    public string ContainingType { get; set; }
    public string FieldName { get; set; }
    public string AssemblyName { get; set; }
    public string CapturedOutput { get; set; }
  }
}