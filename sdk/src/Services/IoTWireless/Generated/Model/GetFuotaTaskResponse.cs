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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// This is the response object from the GetFuotaTask operation.
    /// </summary>
    public partial class GetFuotaTaskResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private string _firmwareUpdateImage;
        private string _firmwareUpdateRole;
        private string _id;
        private LoRaWANFuotaTaskGetInfo _loRaWAN;
        private string _name;
        private FuotaTaskStatus _status;

        /// <summary>
        /// Gets and sets the property Arn.
        /// </summary>
        [AWSProperty(Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FirmwareUpdateImage.
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string FirmwareUpdateImage
        {
            get { return this._firmwareUpdateImage; }
            set { this._firmwareUpdateImage = value; }
        }

        // Check to see if FirmwareUpdateImage property is set
        internal bool IsSetFirmwareUpdateImage()
        {
            return this._firmwareUpdateImage != null;
        }

        /// <summary>
        /// Gets and sets the property FirmwareUpdateRole.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FirmwareUpdateRole
        {
            get { return this._firmwareUpdateRole; }
            set { this._firmwareUpdateRole = value; }
        }

        // Check to see if FirmwareUpdateRole property is set
        internal bool IsSetFirmwareUpdateRole()
        {
            return this._firmwareUpdateRole != null;
        }

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        [AWSProperty(Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LoRaWAN.
        /// </summary>
        public LoRaWANFuotaTaskGetInfo LoRaWAN
        {
            get { return this._loRaWAN; }
            set { this._loRaWAN = value; }
        }

        // Check to see if LoRaWAN property is set
        internal bool IsSetLoRaWAN()
        {
            return this._loRaWAN != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public FuotaTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}