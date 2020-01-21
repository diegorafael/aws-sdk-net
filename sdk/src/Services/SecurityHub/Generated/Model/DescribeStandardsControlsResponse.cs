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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeStandardsControls operation.
    /// </summary>
    public partial class DescribeStandardsControlsResponse : AmazonWebServiceResponse
    {
        private List<StandardsControl> _controls = new List<StandardsControl>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Controls. 
        /// <para>
        /// A list of compliance standards controls.
        /// </para>
        /// </summary>
        public List<StandardsControl> Controls
        {
            get { return this._controls; }
            set { this._controls = value; }
        }

        // Check to see if Controls property is set
        internal bool IsSetControls()
        {
            return this._controls != null && this._controls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more compliance standards control remaining in the results, then this
        /// is the pagination token to use to request the next page of compliance standard controls.
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

    }
}