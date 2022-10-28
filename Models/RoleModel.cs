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
    
    
    public class RoleModel {
        
        protected internal int _id;
        
        protected internal string _name;
        
        protected internal string _description;
        
        protected internal bool _isActive;
        
        public RoleModel() {
        }
        
        internal RoleModel(Role entity) {
            this._id = entity.Id;
            this._name = entity.Name;
            this._description = entity.Description;
            this._isActive = entity.IsActive;
        }
        
        [Display(Name = "Id")]
        public int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Required()]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Name")]
        public string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        [Display(Name = "Description")]
        public string Description {
            get {
                return this._description;
            }
            set {
                this._description = value;
            }
        }
        
        [Required()]
        [Display(Name = "Is active")]
        public bool IsActive {
            get {
                return this._isActive;
            }
            set {
                this._isActive = value;
            }
        }
        
        /// Child UserRoles where [UserRole].[RoleId] point to this entity (FK_UserRole_Role)
        public virtual ICollection<UserRoleModel> UserRolesModel { get; set; } = new HashSet<UserRoleModel>();
        
        public override int GetHashCode() {
            int hash = 0;
            hash ^=Name.GetHashCode();
            hash ^=IsActive.GetHashCode();
            return hash;
        }
        
        public override string ToString() {
            return Name
                 + "-" + IsActive.ToString()
;
        }
        
        public override bool Equals(object obj) {
        bool result = false;

            if (obj is RoleModel) {
                RoleModel toCompare = (RoleModel)obj;
              if(toCompare != null)
              {
                  result = Equals(toCompare);
              }
            }

            return result;
        }
        
        public virtual bool Equals(RoleModel toCompare) {

        bool result = false;

            if (toCompare != null) {
                result = string.Compare(toCompare.Name, Name, true) == 0
             && toCompare.IsActive == IsActive
;
            }

            return result;
        }
    }
}

