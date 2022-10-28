// ----------------------------------------------------------------------------------
// <copyright company="Exesoft Inc.">
//	This code was generated by Instant Web API code automation software (https://www.InstantWebAPI.com)
//	Copyright Exesoft Inc. © 2019.  All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TenantAPI.Entities;
using TenantAPI.Models;

namespace TenantAPI.Models {
    
    
    public class TenantModel {
        
        protected internal System.Guid _id;
        
        protected internal string _companyName;
        
        protected internal string _website;
        
        protected internal string _databaseName;
        
        protected internal string _dataSource;
        
        protected internal string _userId;
        
        protected internal string _password;
        
        public TenantModel() {
            this._id = SequentialGuid.NewGuid();
        }
        
        internal TenantModel(Tenant entity) {
            this._id = entity.Id;
            this._companyName = entity.CompanyName;
            this._website = entity.Website;
            this._databaseName = entity.DatabaseName;
            this._dataSource = entity.DataSource;
            this._userId = entity.UserId;
            this._password = entity.Password;
        }
        
        [Required()]
        [Display(Name = "Id")]
        public System.Guid Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Required()]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Company name")]
        public string CompanyName {
            get {
                return this._companyName;
            }
            set {
                this._companyName = value;
            }
        }
        
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Website")]
        public string Website {
            get {
                return this._website;
            }
            set {
                this._website = value;
            }
        }
        
        [Required()]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Database name")]
        public string DatabaseName {
            get {
                return this._databaseName;
            }
            set {
                this._databaseName = value;
            }
        }
        
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Data source")]
        public string DataSource {
            get {
                return this._dataSource;
            }
            set {
                this._dataSource = value;
            }
        }
        
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "User ID")]
        public string UserId {
            get {
                return this._userId;
            }
            set {
                this._userId = value;
            }
        }
        
        [MaxLength(50)]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password {
            get {
                return this._password;
            }
            set {
                this._password = value;
            }
        }
        
        /// Child Users where [User].[TenantId] point to this entity (FK_User_Tenant)
        public virtual ICollection<UserModel> UsersModel { get; set; } = new HashSet<UserModel>();
        
        public override int GetHashCode() {
            int hash = 0;
            hash ^=Id.GetHashCode();
            return hash;
        }
        
        public override string ToString() {
            return Id.ToString()
;
        }
        
        public override bool Equals(object obj) {
        bool result = false;

            if (obj is TenantModel) {
                TenantModel toCompare = (TenantModel)obj;
              if(toCompare != null)
              {
                  result = Equals(toCompare);
              }
            }

            return result;
        }
        
        public virtual bool Equals(TenantModel toCompare) {

        bool result = false;

            if (toCompare != null) {
                result = toCompare.Id.Equals(Id)
;
            }

            return result;
        }
    }
}

