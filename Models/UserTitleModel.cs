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
    
    
    public class UserTitleModel {
        
        protected internal int _titleId;
        
        protected internal string _abbreviation;
        
        protected internal string _description;
        
        public UserTitleModel() {
        }
        
        internal UserTitleModel(UserTitle entity) {
            this._titleId = entity.TitleId;
            this._abbreviation = entity.Abbreviation;
            this._description = entity.Description;
        }
        
        [Display(Name = "Title ID")]
        public int TitleId {
            get {
                return this._titleId;
            }
            set {
                this._titleId = value;
            }
        }
        
        [Required()]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Abbreviation")]
        public string Abbreviation {
            get {
                return this._abbreviation;
            }
            set {
                this._abbreviation = value;
            }
        }
        
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string Description {
            get {
                return this._description;
            }
            set {
                this._description = value;
            }
        }
        
        /// Child Users where [User].[TitleId] point to this entity (FK_User_UserTitle)
        public virtual ICollection<UserModel> UsersModel { get; set; } = new HashSet<UserModel>();
        
        public override int GetHashCode() {
            int hash = 0;
            hash ^=Abbreviation.GetHashCode();
            return hash;
        }
        
        public override string ToString() {
            return Abbreviation
;
        }
        
        public override bool Equals(object obj) {
        bool result = false;

            if (obj is UserTitleModel) {
                UserTitleModel toCompare = (UserTitleModel)obj;
              if(toCompare != null)
              {
                  result = Equals(toCompare);
              }
            }

            return result;
        }
        
        public virtual bool Equals(UserTitleModel toCompare) {

        bool result = false;

            if (toCompare != null) {
                result = string.Compare(toCompare.Abbreviation, Abbreviation, true) == 0
             && toCompare.Description.Equals(Description)
;
            }

            return result;
        }
    }
}

