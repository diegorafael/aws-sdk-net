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
    /// List of FPort assigned for different LoRaWAN application packages to use
    /// </summary>
    public partial class FPorts
    {
        private int? _clockSync;
        private int? _fuota;
        private int? _multicast;

        /// <summary>
        /// Gets and sets the property ClockSync.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int ClockSync
        {
            get { return this._clockSync.GetValueOrDefault(); }
            set { this._clockSync = value; }
        }

        // Check to see if ClockSync property is set
        internal bool IsSetClockSync()
        {
            return this._clockSync.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Fuota.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int Fuota
        {
            get { return this._fuota.GetValueOrDefault(); }
            set { this._fuota = value; }
        }

        // Check to see if Fuota property is set
        internal bool IsSetFuota()
        {
            return this._fuota.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Multicast.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int Multicast
        {
            get { return this._multicast.GetValueOrDefault(); }
            set { this._multicast = value; }
        }

        // Check to see if Multicast property is set
        internal bool IsSetMulticast()
        {
            return this._multicast.HasValue; 
        }

    }
}