namespace Sxta.Rti1516.Management
{

    using System;
    using System.IO;
    using System.Collections.Generic;

    using Hla.Rti1516;
    using Sxta.Rti1516.Reflection;
    using Sxta.Rti1516.Interactions;
    using Sxta.Rti1516.Base; // TODO

    using HlaEncodingReader = Sxta.Rti1516.Serializers.XrtiEncoding.HlaEncodingReader;
    using HlaEncodingWriter = Sxta.Rti1516.Serializers.XrtiEncoding.HlaEncodingWriter;
    using Sxta.Rti1516.Serializers.XrtiEncoding;


    ///<summary>
    ///Autogenerated Serializer Helper. Serializes and deserializes HLAfederation.HLAconveyRegionDesignatorSets
    ///parameters into and from HLA formats. 
    ///</summary>
    /// <author> Sxta1516.DynamicCompiler.DynamicCompiler from Management Object Model </author>
    public class HLAfederationPropertyHLAconveyRegionDesignatorSetsXrtiSerializer : BaseInteractionMessageXrtiSerializer
    {
        ///<summary>Constructor for the serializer of HLAfederation.HLAconveyRegionDesignatorSets property.
        /// </summary>
        public HLAfederationPropertyHLAconveyRegionDesignatorSetsXrtiSerializer(XrtiSerializerManager manager)
        : base(manager)
        {
        }

        ///<summary>
        /// Writes this HLAfederation.HLAconveyRegionDesignatorSets to the specified stream.
        ///</summary>
        ///<param name="writer"> the output stream to write to</param>
        ///<param name="HLAconveyRegionDesignatorSets"> the property to serialize</param>
        ///<exception cref="System.IO.IOException"> if an error occurs</exception>
        public override void Serialize(HlaEncodingWriter writer, object HLAconveyRegionDesignatorSets)
        {
            try
            {
                HLAswitchXrtiSerializer.Serialize(writer, (HLAswitch)HLAconveyRegionDesignatorSets);
            }
            catch(IOException ioe)
            {
                throw new RTIinternalError(ioe.ToString());
            }

        }

        ///<summary>
        /// Reads and returns a HLAfederation.HLAconveyRegionDesignatorSets from the specified stream.
        ///</summary>
        ///<param name="reader"> the input stream to read from</param>
        ///<param name="dummy"> this parameter is not used</param>
        ///<returns> the decoded value</returns>
        ///<exception cref="System.IO.IOException"> if an error occurs</exception>
        public override object Deserialize(HlaEncodingReader reader, ref object dummy)
        {
            HLAswitch decodedValue;
            try
            {
                decodedValue = HLAswitchXrtiSerializer.Deserialize(reader);
                return decodedValue;
            }
            catch(IOException ioe)
            {
                throw new FederateInternalError(ioe.ToString());
            }
        }
    }
}