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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Paginators for the Outposts service
    ///</summary>
    public class OutpostsPaginatorFactory : IOutpostsPaginatorFactory
    {
        private readonly IAmazonOutposts client;

        internal OutpostsPaginatorFactory(IAmazonOutposts client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCatalogItems operation
        ///</summary>
        public IListCatalogItemsPaginator ListCatalogItems(ListCatalogItemsRequest request) 
        {
            return new ListCatalogItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrders operation
        ///</summary>
        public IListOrdersPaginator ListOrders(ListOrdersRequest request) 
        {
            return new ListOrdersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOutposts operation
        ///</summary>
        public IListOutpostsPaginator ListOutposts(ListOutpostsRequest request) 
        {
            return new ListOutpostsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSites operation
        ///</summary>
        public IListSitesPaginator ListSites(ListSitesRequest request) 
        {
            return new ListSitesPaginator(this.client, request);
        }
    }
}