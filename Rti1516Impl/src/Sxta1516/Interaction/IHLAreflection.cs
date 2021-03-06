namespace Sxta.Rti1516.Proxies
{

    using System;

    using Hla.Rti1516;

    ///<summary>
    ///Autogenerated object instance interface. 
    ///</summary>
    /// <author> Sxta.Rti1516.Compiler.ProxyCompiler</author>
    public interface IHLAreflection : IHLAobjectRoot
    {
        ///<summary>Adds a listener for the attributes associated with the IHLAreflection class.</summary>
        ///<param name="l"> the listener to Add</param>
        //void AddIHLAreflectionListener(IHLAreflectionListener l);

        ///<summary>Removes a listener for the attributes associated with the IHLAreflection class.</summary>
        ///<param name="l"> the listener to Remove</param>
        //void RemoveIHLAreflectionListener(IHLAreflectionListener l);

        /// <summary>Sets the value of the reflectionName attribute.</summary>
        /// <param name="p"> ReflectionName the new attribute value</param>
        /// <param name="userSuppliedTag"> a user-supplied tag to associate with the action</param>
        /// <exception cref="ObjectInstanceNotKnown"> if the object instance is unknown</exception>
        /// <exception cref="AttributeNotDefined"> if one of the attributes is undefined</exception>
        /// <exception cref="AttributeNotOwned"> if one of the attributes is not owned</exception>
        /// <exception cref="FederateNotExecutionMember"> if the federate is not a member of an execution</exception>
        /// <exception cref="SaveInProgress"> if a save operation is in progress</exception>
        /// <exception cref="RestoreInProgress"> if a restore operation is in progress</exception>
        /// <exception cref="RTIinternalError"> if an internal error occurred in the
        /// run-time infrastructure</exception>
        void SetReflectionName(String pReflectionName, byte[] userSuppliedTag);

        ///<summary>Returns the value of the reflectionName attribute.</summary>
        ///<returns> the current attribute value</returns>
     String GetReflectionName();
    }
}
