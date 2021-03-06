﻿namespace Sxta.Rti1516.BoostrapProtocol
{
    using System;
    using System.IO;

    using Hla.Rti1516;
    using Sxta.Rti1516.Serializers.XrtiEncoding;
    using Sxta.Rti1516.Interactions;
    using Sxta.Rti1516.Reflection;

    ///<summary>
    ///Autogenerated interaction listener interface. 
    ///</summary>
    /// <author> Sxta.Rti1516.DynamicCompiler.DynamicCompiler from Bootstrap Object Model </author>
    public interface IBootstrapObjectModelInteractionListener : IInteractionListener
    {
        ///<summary>
        ///A piece of a fragmented interaction. 
        ///</summary>
        ///<param name="msg"> the message associated with the interaction</param>
        ///<exception cref="InteractionClassNotRecognized"> if the interaction class was not recognized</exception>
        ///<exception cref="InteractionParameterNotRecognized"> if a parameter of the interaction was not
        /// recognized</exception>
        ///<exception cref="InteractionClassNotSubscribed"> if the federate had not subscribed to the
        /// interaction class</exception>
        ///<exception cref="FederateInternalError"> if an error occurs in the federate</exception>
        void OnReceiveHLAGenericInteraction(HLAGenericInteractionMessage msg);


        ///<summary>
        ///A piece of a fragmented interaction. 
        ///</summary>
        ///<param name="msg"> the message associated with the interaction</param>
        ///<exception cref="InteractionClassNotRecognized"> if the interaction class was not recognized</exception>
        ///<exception cref="InteractionParameterNotRecognized"> if a parameter of the interaction was not
        /// recognized</exception>
        ///<exception cref="InteractionClassNotSubscribed"> if the federate had not subscribed to the
        /// interaction class</exception>
        ///<exception cref="FederateInternalError"> if an error occurs in the federate</exception>
        void OnReceiveHLAinteractionFragment(HLAinteractionFragmentMessage msg);


        ///<summary>
        ///Notifies the federate that the executive is done sending callbacks.
        ///</summary>
        ///<param name="msg"> the message associated with the interaction</param>
        ///<exception cref="InteractionClassNotRecognized"> if the interaction class was not recognized</exception>
        ///<exception cref="InteractionParameterNotRecognized"> if a parameter of the interaction was not
        /// recognized</exception>
        ///<exception cref="InteractionClassNotSubscribed"> if the federate had not subscribed to the
        /// interaction class</exception>
        ///<exception cref="FederateInternalError"> if an error occurs in the federate</exception>
        void OnReceiveHLAcontinue(HLAcontinueMessage msg);


        ///<summary>
        ///A Peer Advertisement describes a peer and the resources it provides
        ///to the system. The Peer Advertisement holds specific information about
        ///the peer such as its unique id, and optionally its name and descriptive
        ///information. It may also contain endpoint addresses and any run-time
        ///attributes that individual peer services want to publish (such as
        ///being a rendezvous peer for a group). 
        ///</summary>
        ///<param name="msg"> the message associated with the interaction</param>
        ///<exception cref="InteractionClassNotRecognized"> if the interaction class was not recognized</exception>
        ///<exception cref="InteractionParameterNotRecognized"> if a parameter of the interaction was not
        /// recognized</exception>
        ///<exception cref="InteractionClassNotSubscribed"> if the federate had not subscribed to the
        /// interaction class</exception>
        ///<exception cref="FederateInternalError"> if an error occurs in the federate</exception>
        void OnReceivePeerAdvertisementInteraction(PeerAdvertisementInteractionMessage msg);

    }
}
