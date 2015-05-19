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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output of DescribeSpotFleetInstances.
    /// </summary>
    public partial class DescribeSpotFleetInstancesResult : AmazonWebServiceResponse
    {
        private List<ActiveInstance> _activeInstances = new List<ActiveInstance>();
        private string _nextToken;
        private string _spotFleetRequestId;

        /// <summary>
        /// Gets and sets the property ActiveInstances. 
        /// <para>
        /// The running instances. Note that this list is refreshed periodically and might be
        /// out of date.
        /// </para>
        /// </summary>
        public List<ActiveInstance> ActiveInstances
        {
            get { return this._activeInstances; }
            set { this._activeInstances = value; }
        }

        // Check to see if ActiveInstances property is set
        internal bool IsSetActiveInstances()
        {
            return this._activeInstances != null && this._activeInstances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token required to retrieve the next set of results. This value is <code>null</code>
        /// when there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot fleet request.
        /// </para>
        /// </summary>
        public string SpotFleetRequestId
        {
            get { return this._spotFleetRequestId; }
            set { this._spotFleetRequestId = value; }
        }

        // Check to see if SpotFleetRequestId property is set
        internal bool IsSetSpotFleetRequestId()
        {
            return this._spotFleetRequestId != null;
        }

    }
}