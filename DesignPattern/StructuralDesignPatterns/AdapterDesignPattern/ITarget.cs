namespace DesignPattern.StructuralDesignPatterns.AdapterDesignPattern
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'ITarget' interface
    /// </summary>
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }
}
