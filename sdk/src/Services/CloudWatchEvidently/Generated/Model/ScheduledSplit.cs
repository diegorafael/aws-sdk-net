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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This structure defines the traffic allocation percentages among the feature variations
    /// during one step of a launch, and the start time of that step.
    /// </summary>
    public partial class ScheduledSplit
    {
        private Dictionary<string, long> _groupWeights = new Dictionary<string, long>();
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property GroupWeights. 
        /// <para>
        /// The traffic allocation percentages among the feature variations during one step of
        /// a launch. This is a set of key-value pairs. The keys are variation names. The values
        /// represent the percentage of traffic to allocate to that variation during this step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, long> GroupWeights
        {
            get { return this._groupWeights; }
            set { this._groupWeights = value; }
        }

        // Check to see if GroupWeights property is set
        internal bool IsSetGroupWeights()
        {
            return this._groupWeights != null && this._groupWeights.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time that this step of the launch starts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}