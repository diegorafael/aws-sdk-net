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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the DeleteRecommendationTemplate operation.
    /// </summary>
    public partial class DeleteRecommendationTemplateResponse : AmazonWebServiceResponse
    {
        private string _recommendationTemplateArn;
        private RecommendationTemplateStatus _status;

        /// <summary>
        /// Gets and sets the property RecommendationTemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendationTemplateArn
        {
            get { return this._recommendationTemplateArn; }
            set { this._recommendationTemplateArn = value; }
        }

        // Check to see if RecommendationTemplateArn property is set
        internal bool IsSetRecommendationTemplateArn()
        {
            return this._recommendationTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationTemplateStatus Status
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