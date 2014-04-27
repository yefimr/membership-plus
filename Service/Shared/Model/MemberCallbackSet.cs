//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool from CryptoGateway Software Inc.
//     Tool name: CGW X-Script RDB visual Layer Generator
//
//     Archymeta Information Technologies Co., Ltd.
//
//     Changes to this file, could be overwritten if the code is re-generated.
//     Add (if not yet) a code-manager node to the generator to specify 
//     how existing files are processed.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Configuration;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Runtime.Serialization;

namespace CryptoGateway.RDB.Data.MembershipPlus
{
    /// <summary>
    /// A structure representing possible combination of foreign key constraint of the data set of "MemberCallbacks".
    /// </summary>
    [DataContract]
    [Serializable]
    public class MemberCallbackSetConstraints
    {
        /// <summary>
        /// internal use.
        /// </summary>
        public string CacheKey
        {
            get 
            {
                if (_cacheKey == null) 
                    _cacheKey = (ApplicationIDWrap != null ? ApplicationIDWrap.CacheKey : "" ) + "_" + (UserIDWrap != null ? UserIDWrap.CacheKey : "" ) + "_"; 
                return _cacheKey;
            }
        }
        private string _cacheKey = null;

        /// <summary>
        /// The wrapper for the ApplicationID key value.
        /// </summary>
        [DataMember]
        public ForeignKeyData<string> ApplicationIDWrap
        {
            get;
            set;
        }
        /// <summary>
        /// The wrapper for the UserID key value.
        /// </summary>
        [DataMember]
        public ForeignKeyData<string> UserIDWrap
        {
            get;
            set;
        }
        /// <summary>
        /// The corresponding item count.
        /// </summary>
        [DataMember]
        public int ItemCount
        {
            get;
            set;
        }

        /// <summary>
        /// Is it the same as the input one
        /// </summary>
        /// <param name="constraints">The one to be compared with.</param>
        /// <returns></returns>
        public bool IsTheSameAs(MemberCallbackSetConstraints constraints)
        {
            return ApplicationIDWrap.KeyValue == constraints.ApplicationIDWrap.KeyValue && UserIDWrap.KeyValue == constraints.UserIDWrap.KeyValue;
        }
    }

    /// <summary>
    /// A structure representing a limited set of available constraints of "MemberCallbacks".
    /// </summary>
    [DataContract]
    [Serializable]
    public class MemberCallbackSetConstraintsColl
    {
        /// <summary>
        /// Total number
        /// </summary>
        [DataMember]
        public Int64 AllCounts
        {
            get;
            set;
        }

        /// <summary>
        /// Next page id
        /// </summary>
        [DataMember]
        public string NextPageId
        {
            get;
            set;
        }

        /// <summary>
        /// A list of non-trivial constraints. 
        /// </summary>
        /// <remarks>If the total is tool large, it will be set to null so that the client will do active search.</remarks>
        [DataMember]
        public MemberCallbackSetConstraints[] AvailableOnes
        {
            get;
            set;
        }

    }

    /// <summary>
    /// A structure representing the data set of "MemberCallbacks".
    /// </summary>
    [DataContract]
    [Serializable]
    public class MemberCallbackSet
    {
        /// <summary>
        /// The size of a page in the set.
        /// </summary>
        [DataMember]
        public int PageSize_
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }
        private int _pageSize = 15;

        /// <summary>
        /// The size of a page block in the set. A block of page frames are retrieved from the service at a time.
        /// </summary>
        [DataMember]
        public int PageBlockSize
        {
            get { return _pageBlockSize; }
            set { _pageBlockSize = value; }
        }
        private int _pageBlockSize = 10;

        /// <summary>
        /// The namespace. It is used internally.
        /// </summary>
        public string NameSpace
        {
            get;
            set;
        }

        /// <summary>
        /// The kind of the set.
        /// </summary>
        [DataMember]
        public string SetKindName
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the set.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The entity name of the set.
        /// </summary>
        [DataMember]
        public string EntityName
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not there is a backing data store at present.
        /// </summary>
        [DataMember]
        public bool DoesSetExist
        {
            get { return _doesSetExist; }
            set { _doesSetExist = value; }
        }
        private bool _doesSetExist = false;

        /// <summary>
        /// Whether or not the set has a sync-timestamp field
        /// </summary>
        [DataMember]
        public bool HasSyncTimeStampField
        {
            get { return _syncTimeStampFieldExist; }
            set { _syncTimeStampFieldExist = value; }
        }
        private bool _syncTimeStampFieldExist = false;

        /// <summary>
        /// The number of entities inside the set.
        /// </summary>
        [DataMember]
        public Int64 EntityCount
        {
            get { return _entityCount; }
            set { _entityCount = value; }
        }
        private Int64 _entityCount = 0;

        /// <summary>
        /// The filter expression for the set. If it is not empty or null, the set is a sub-set of corresponding data set inside the data source.
        /// </summary>
        [DataMember]
        public string SetFilter
        {
            get;
            set;
        }

        /// <summary>
        /// The sorter options for the set.
        /// </summary>
        [DataMember]
        public List<QToken> Sorters
        {
            get;
            set;
        }

        /// <summary>
        /// The loaded pages of the set.
        /// </summary>
        [DataMember]
        public List<MemberCallbackPage> Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }
        private List<MemberCallbackPage> _pages;

        /// <summary>
        /// The displaying page block of the set.
        /// </summary>
        [DataMember]
        public List<MemberCallbackPage> PagesWindow
        {
            get { return _pagesWindow; }
            set { _pagesWindow = value; }
        }
        private List<MemberCallbackPage> _pagesWindow;

        /// <summary>
        /// A key that identifies the set in caches.
        /// </summary>
        public string CacheKey
        {
            get
            {
                return "" + PageSize_ + "." + PageBlockSize + "." + (SetFilter == null ? "" : SetFilter);
            }
        }

        public MemberCallbackSet()
        {
            NameSpace = "dbo";
            //Name = "MemberCallbacks " + StringResources.Table;
            Name = "MemberCallbacks " + "Table";
            EntityName = "MemberCallback";
            //... other init
            _pages = new List<MemberCallbackPage>();
        }
    }

}