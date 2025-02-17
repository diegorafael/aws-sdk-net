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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEndpoint Request Marshaller
    /// </summary>       
    public class CreateEndpointRequestMarshaller : IMarshaller<IRequest, CreateEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.CreateEndpoint";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificateArn())
                {
                    context.Writer.WritePropertyName("CertificateArn");
                    context.Writer.Write(publicRequest.CertificateArn);
                }

                if(publicRequest.IsSetDatabaseName())
                {
                    context.Writer.WritePropertyName("DatabaseName");
                    context.Writer.Write(publicRequest.DatabaseName);
                }

                if(publicRequest.IsSetDmsTransferSettings())
                {
                    context.Writer.WritePropertyName("DmsTransferSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = DmsTransferSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DmsTransferSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDocDbSettings())
                {
                    context.Writer.WritePropertyName("DocDbSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = DocDbSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DocDbSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDynamoDbSettings())
                {
                    context.Writer.WritePropertyName("DynamoDbSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = DynamoDbSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DynamoDbSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetElasticsearchSettings())
                {
                    context.Writer.WritePropertyName("ElasticsearchSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = ElasticsearchSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ElasticsearchSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEndpointIdentifier())
                {
                    context.Writer.WritePropertyName("EndpointIdentifier");
                    context.Writer.Write(publicRequest.EndpointIdentifier);
                }

                if(publicRequest.IsSetEndpointType())
                {
                    context.Writer.WritePropertyName("EndpointType");
                    context.Writer.Write(publicRequest.EndpointType);
                }

                if(publicRequest.IsSetEngineName())
                {
                    context.Writer.WritePropertyName("EngineName");
                    context.Writer.Write(publicRequest.EngineName);
                }

                if(publicRequest.IsSetExternalTableDefinition())
                {
                    context.Writer.WritePropertyName("ExternalTableDefinition");
                    context.Writer.Write(publicRequest.ExternalTableDefinition);
                }

                if(publicRequest.IsSetExtraConnectionAttributes())
                {
                    context.Writer.WritePropertyName("ExtraConnectionAttributes");
                    context.Writer.Write(publicRequest.ExtraConnectionAttributes);
                }

                if(publicRequest.IsSetGcpMySQLSettings())
                {
                    context.Writer.WritePropertyName("GcpMySQLSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = GcpMySQLSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GcpMySQLSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIBMDb2Settings())
                {
                    context.Writer.WritePropertyName("IBMDb2Settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = IBMDb2SettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IBMDb2Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKafkaSettings())
                {
                    context.Writer.WritePropertyName("KafkaSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = KafkaSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KafkaSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKinesisSettings())
                {
                    context.Writer.WritePropertyName("KinesisSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = KinesisSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KinesisSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetMicrosoftSQLServerSettings())
                {
                    context.Writer.WritePropertyName("MicrosoftSQLServerSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = MicrosoftSQLServerSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MicrosoftSQLServerSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMongoDbSettings())
                {
                    context.Writer.WritePropertyName("MongoDbSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = MongoDbSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MongoDbSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMySQLSettings())
                {
                    context.Writer.WritePropertyName("MySQLSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = MySQLSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MySQLSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNeptuneSettings())
                {
                    context.Writer.WritePropertyName("NeptuneSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = NeptuneSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NeptuneSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOracleSettings())
                {
                    context.Writer.WritePropertyName("OracleSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = OracleSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OracleSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPassword())
                {
                    context.Writer.WritePropertyName("Password");
                    context.Writer.Write(publicRequest.Password);
                }

                if(publicRequest.IsSetPort())
                {
                    context.Writer.WritePropertyName("Port");
                    context.Writer.Write(publicRequest.Port);
                }

                if(publicRequest.IsSetPostgreSQLSettings())
                {
                    context.Writer.WritePropertyName("PostgreSQLSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = PostgreSQLSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PostgreSQLSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRedisSettings())
                {
                    context.Writer.WritePropertyName("RedisSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = RedisSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RedisSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRedshiftSettings())
                {
                    context.Writer.WritePropertyName("RedshiftSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = RedshiftSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RedshiftSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceIdentifier())
                {
                    context.Writer.WritePropertyName("ResourceIdentifier");
                    context.Writer.Write(publicRequest.ResourceIdentifier);
                }

                if(publicRequest.IsSetS3Settings())
                {
                    context.Writer.WritePropertyName("S3Settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3SettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServerName())
                {
                    context.Writer.WritePropertyName("ServerName");
                    context.Writer.Write(publicRequest.ServerName);
                }

                if(publicRequest.IsSetServiceAccessRoleArn())
                {
                    context.Writer.WritePropertyName("ServiceAccessRoleArn");
                    context.Writer.Write(publicRequest.ServiceAccessRoleArn);
                }

                if(publicRequest.IsSetSslMode())
                {
                    context.Writer.WritePropertyName("SslMode");
                    context.Writer.Write(publicRequest.SslMode);
                }

                if(publicRequest.IsSetSybaseSettings())
                {
                    context.Writer.WritePropertyName("SybaseSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = SybaseSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SybaseSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUsername())
                {
                    context.Writer.WritePropertyName("Username");
                    context.Writer.Write(publicRequest.Username);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEndpointRequestMarshaller _instance = new CreateEndpointRequestMarshaller();        

        internal static CreateEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}