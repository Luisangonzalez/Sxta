﻿namespace Sxta.Rti1516.LowLevelManagement
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    using Hla.Rti1516;
    using Sxta.Rti1516.Channels;
    using Sxta.Rti1516.Serializers.XrtiEncoding;
    using Sxta.Rti1516.Interactions;
    using Sxta.Rti1516.Reflection;
    using Sxta.Rti1516.XrtiHandles;
    using Sxta.Rti1516.BoostrapProtocol;
    
    
    ///<summary>
    ///Autogenerated interaction and serializer registration Helper. 
    ///</summary>
    /// <author> Sxta.Rti1516.DynamicCompiler.DynamicCompiler from Low Level Management Object Model </author>
    [HLAinteractionHelperAttribute(Name = "LowLevelManagementObjectModelInteractionHelper",
                                   FomName = "Low Level Management Object Model",
                                   Semantics = "A Listener Manager and serializer manager")]
    public class LowLevelManagementObjectModelInteractionHelper
    {
        InteractionManager manager;

        /// <summary>Constructor.</summary>
        /// <param name="interactionManager"> the run-time interaction manager</param>
        public LowLevelManagementObjectModelInteractionHelper(InteractionManager interactionManager)
        {
            Type objType;
            manager = interactionManager;
            XrtiSerializerManager serializerMngr = manager.SerializerManager;
            long handle;

            objType = typeof(BaseInteractionMessage);
            manager.AddReceiveInteractionDelegate(objType, "BaseInteraction", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("BaseInteraction").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new BaseInteractionMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLArequestHandlesMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLArequestHandles", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLArequestHandles").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLArequestHandlesMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAreportHandlesMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAreportHandles", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAreportHandles").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAreportHandlesMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAregisterObjectInstanceMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAregisterObjectInstance", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAregisterObjectInstance").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAregisterObjectInstanceMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAregisterObjectInstanceWithTimeMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAregisterObjectInstanceWithTime", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAregisterObjectInstanceWithTime").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAregisterObjectInstanceWithTimeMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLArequestAttributeValueUpdateMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLArequestAttributeValueUpdate", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLArequestAttributeValueUpdate").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLArequestAttributeValueUpdateMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAupdateAttributeValuesMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAupdateAttributeValues", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAupdateAttributeValues").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAupdateAttributeValuesMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAupdateAttributeValuesWithTimeMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAupdateAttributeValuesWithTime", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAupdateAttributeValuesWithTime").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAupdateAttributeValuesWithTimeMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAupdateAttributeValuesBestEffortWithTimeMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAupdateAttributeValuesBestEffortWithTime", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAupdateAttributeValuesBestEffortWithTime").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAupdateAttributeValuesBestEffortWithTimeMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAupdateAttributeValuesReliableWithTimeMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAupdateAttributeValuesReliableWithTime", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAupdateAttributeValuesReliableWithTime").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAupdateAttributeValuesReliableWithTimeMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAupdateAttributeValuesBestEffortMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAupdateAttributeValuesBestEffort", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAupdateAttributeValuesBestEffort").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAupdateAttributeValuesBestEffortMessageXrtiSerializer(serializerMngr));

            objType = typeof(HLAupdateAttributeValuesReliableMessage);
            manager.AddReceiveInteractionDelegate(objType, "HLAupdateAttributeValuesReliable", new InteractionManager.ReceiveInteractionDelegate(this.ReceiveInteraction));
            handle = ((XRTIInteractionClassHandle)manager.DescriptorManager.GetInteractionClassDescriptor("HLAupdateAttributeValuesReliable").Handle).Identifier;
            serializerMngr.RegisterSerializer(objType, handle, new HLAupdateAttributeValuesReliableMessageXrtiSerializer(serializerMngr));
        }

        /// <summary>Notifies the listener of a received interaction.</summary>
        /// <param name="msg"> the message of the received interaction</param>
        public void ReceiveInteraction(BaseInteractionMessage msg)
        {
            try
            {
                if (msg is HLArequestHandlesMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLArequestHandles(msg as HLArequestHandlesMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else if (msg is HLAreportHandlesMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLAreportHandles(msg as HLAreportHandlesMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else if (msg is HLAregisterObjectInstanceMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLAregisterObjectInstance(msg as HLAregisterObjectInstanceMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else if (msg is HLAregisterObjectInstanceWithTimeMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLAregisterObjectInstanceWithTime(msg as HLAregisterObjectInstanceWithTimeMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else if (msg is HLArequestAttributeValueUpdateMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLArequestAttributeValueUpdate(msg as HLArequestAttributeValueUpdateMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else if (msg is HLAupdateAttributeValuesBestEffortWithTimeMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLAupdateAttributeValuesBestEffortWithTime(msg as HLAupdateAttributeValuesBestEffortWithTimeMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else if (msg is HLAupdateAttributeValuesReliableWithTimeMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLAupdateAttributeValuesReliableWithTime(msg as HLAupdateAttributeValuesReliableWithTimeMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else if (msg is HLAupdateAttributeValuesBestEffortMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLAupdateAttributeValuesBestEffort(msg as HLAupdateAttributeValuesBestEffortMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else if (msg is HLAupdateAttributeValuesReliableMessage)
                {
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        if (il is ILowLevelManagementObjectModelInteractionListener)
                            (il as ILowLevelManagementObjectModelInteractionListener).OnReceiveHLAupdateAttributeValuesReliable(msg as HLAupdateAttributeValuesReliableMessage);
                        else
                            il.ReceiveInteraction(msg);
                    }
                }
                else
                    foreach (IInteractionListener il in manager.InteractionListeners)
                    {
                        il.ReceiveInteraction(msg);
                    }
            }
            catch (System.IO.IOException ioe)
            {
                throw new FederateInternalError(ioe.ToString());
            }

        }
    }
}
