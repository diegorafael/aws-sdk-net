/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EBS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EBS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetSnapshotBlock operation
    /// </summary>  
    public class GetSnapshotBlockResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetSnapshotBlockResponse response = new GetSnapshotBlockResponse();

            response.BlockData = context.Stream;
            if (context.ResponseData.IsHeaderPresent("x-amz-Checksum"))
                response.Checksum = context.ResponseData.GetHeaderValue("x-amz-Checksum");
            if (context.ResponseData.IsHeaderPresent("x-amz-Checksum-Algorithm"))
                response.ChecksumAlgorithm = context.ResponseData.GetHeaderValue("x-amz-Checksum-Algorithm");
            if (context.ResponseData.IsHeaderPresent("x-amz-Data-Length"))
                response.DataLength = int.Parse(context.ResponseData.GetHeaderValue("x-amz-Data-Length"), CultureInfo.InvariantCulture);

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
            {
                return new ValidationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonEBSException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        /// <summary>
        /// Overriden to return true indicating the response contains streaming data.
        /// </summary>
        public override bool HasStreamingProperty
        {
            get
            {
                return true;
            }
        }

        private static GetSnapshotBlockResponseUnmarshaller _instance = new GetSnapshotBlockResponseUnmarshaller();        

        internal static GetSnapshotBlockResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSnapshotBlockResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}