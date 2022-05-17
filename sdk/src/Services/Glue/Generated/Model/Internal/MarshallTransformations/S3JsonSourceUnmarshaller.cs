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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3JsonSource Object
    /// </summary>  
    public class S3JsonSourceUnmarshaller : IUnmarshaller<S3JsonSource, XmlUnmarshallerContext>, IUnmarshaller<S3JsonSource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        S3JsonSource IUnmarshaller<S3JsonSource, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3JsonSource Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            S3JsonSource unmarshalledObject = new S3JsonSource();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalOptions", targetDepth))
                {
                    var unmarshaller = S3DirectSourceAdditionalOptionsUnmarshaller.Instance;
                    unmarshalledObject.AdditionalOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompressionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CompressionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Exclusions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Exclusions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GroupFiles", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupFiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GroupSize", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JsonPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JsonPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxBand", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxBand = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxFilesInBand", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxFilesInBand = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Multiline", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Multiline = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputSchemas", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GlueSchema, GlueSchemaUnmarshaller>(GlueSchemaUnmarshaller.Instance);
                    unmarshalledObject.OutputSchemas = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Paths", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Paths = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Recurse", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Recurse = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static S3JsonSourceUnmarshaller _instance = new S3JsonSourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3JsonSourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}