﻿#region Copyright
// 
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2013
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using DotNetNuke.Services.Social.Subscriptions.Entities;

namespace DotNetNuke.Services.Social.Subscriptions
{
    public interface ISubscriptionTypeController
    {
        /// <summary>
        /// Creates a new Subscription Type
        /// </summary>
        /// <param name="subscriptionType">Subscription Type</param>
        /// <returns>Subscription type Id</returns>
        int AddSubscriptionType(SubscriptionType subscriptionType);

        /// <summary>
        /// Retrieves a Single Subscription Type that match the where predicate
        /// </summary>
        /// <param name="predicate">Where Predicate</param>
        /// <returns>Subscription Type</returns>
        SubscriptionType GetSubscriptionType(Func<SubscriptionType, bool> predicate);

        /// <summary>
        /// Retrieves all the Subscription Type
        /// </summary>
        /// <returns>Subscription Types collection</returns>
        IEnumerable<SubscriptionType> GetSubscriptionTypes();

        /// <summary>
        /// Retrieves a set of Subscription Types specifying a where predicate
        /// </summary>
        /// <param name="predicate">Where predicate</param>
        /// <returns>Subscription Type collection</returns>
        IEnumerable<SubscriptionType> GetSubscriptionTypes(Func<SubscriptionType, bool> predicate);
        
        /// <summary>
        /// Deletes a Subscription Type from the system
        /// </summary>
        /// <param name="subscriptionTypeId">Subscription Type Id</param>
        /// <returns>true if subscription has been deleted, false otherwise</returns>
        bool DeleteSubscriptionType(int subscriptionTypeId);
    }
}