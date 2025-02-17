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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides the Config rule owner (Amazon Web Services or customer), the rule identifier,
    /// and the events that trigger the evaluation of your Amazon Web Services resources.
    /// </summary>
    public partial class Source
    {
        private Owner _owner;
        private List<SourceDetail> _sourceDetails = new List<SourceDetail>();
        private string _sourceIdentifier;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Indicates whether Amazon Web Services or the customer owns and manages the Config
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDetails. 
        /// <para>
        /// Provides the source and type of the event that causes Config to evaluate your Amazon
        /// Web Services resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<SourceDetail> SourceDetails
        {
            get { return this._sourceDetails; }
            set { this._sourceDetails = value; }
        }

        // Check to see if SourceDetails property is set
        internal bool IsSetSourceDetails()
        {
            return this._sourceDetails != null && this._sourceDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        /// For Config managed rules, a predefined identifier from a list. For example, <code>IAM_PASSWORD_POLICY</code>
        /// is a managed rule. To reference a managed rule, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">Using
        /// Config managed rules</a>.
        /// </para>
        ///  
        /// <para>
        /// For custom rules, the identifier is the Amazon Resource Name (ARN) of the rule's Lambda
        /// function, such as <code>arn:aws:lambda:us-east-2:123456789012:function:custom_rule_name</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }

    }
}