/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FinSpaceData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FinSpaceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateChangeset Request Marshaller
    /// </summary>       
    public class CreateChangesetRequestMarshaller : IMarshaller<IRequest, CreateChangesetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateChangesetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateChangesetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FinSpaceData");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-13";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDatasetId())
                throw new AmazonFinSpaceDataException("Request object does not have required field DatasetId set");
            request.AddPathResource("{datasetId}", StringUtils.FromString(publicRequest.DatasetId));
            request.ResourcePath = "/datasets/{datasetId}/changesetsv2";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChangeType())
                {
                    context.Writer.WritePropertyName("changeType");
                    context.Writer.Write(publicRequest.ChangeType);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetFormatParams())
                {
                    context.Writer.WritePropertyName("formatParams");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFormatParamsKvp in publicRequest.FormatParams)
                    {
                        context.Writer.WritePropertyName(publicRequestFormatParamsKvp.Key);
                        var publicRequestFormatParamsValue = publicRequestFormatParamsKvp.Value;

                            context.Writer.Write(publicRequestFormatParamsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceParams())
                {
                    context.Writer.WritePropertyName("sourceParams");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestSourceParamsKvp in publicRequest.SourceParams)
                    {
                        context.Writer.WritePropertyName(publicRequestSourceParamsKvp.Key);
                        var publicRequestSourceParamsValue = publicRequestSourceParamsKvp.Value;

                            context.Writer.Write(publicRequestSourceParamsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateChangesetRequestMarshaller _instance = new CreateChangesetRequestMarshaller();        

        internal static CreateChangesetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateChangesetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}