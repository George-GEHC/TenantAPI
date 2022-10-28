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
    
    
    public class InfoModel {
        
        protected internal int _id;
        
        protected internal string _type;
        
        protected internal string _url;
        
        protected internal string _username;
        
        protected internal string _password;
        
        public InfoModel() {
        }
        
        internal InfoModel(Info entity) {
            this._id = entity.Id;
            this._type = entity.Type;
            this._url = entity.Url;
            this._username = entity.Username;
            this._password = entity.Password;
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
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Type")]
        public string Type {
            get {
                return this._type;
            }
            set {
                this._type = value;
            }
        }
        
        [Required()]
        [MaxLength(256)]
        [StringLength(256)]
        [Url()]
        [Display(Name = "Url")]
        public string Url {
            get {
                return this._url;
            }
            set {
                this._url = value;
            }
        }
        
        [Required()]
        [MaxLength(50)]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public string Username {
            get {
                return this._username;
            }
            set {
                this._username = value;
            }
        }
        
        [Required()]
        [MaxLength(250)]
        [StringLength(250)]
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
        
        public override int GetHashCode() {
            int hash = 0;
            hash ^=Type.GetHashCode();
            hash ^=Url.GetHashCode();
            hash ^=Username.GetHashCode();
            hash ^=Password.GetHashCode();
            return hash;
        }
        
        public override string ToString() {
            return Type
                 + "-" + Url
                 + "-" + Username
                 + "-" + Password
;
        }
        
        public override bool Equals(object obj) {
        bool result = false;

            if (obj is InfoModel) {
                InfoModel toCompare = (InfoModel)obj;
              if(toCompare != null)
              {
                  result = Equals(toCompare);
              }
            }

            return result;
        }
        
        public virtual bool Equals(InfoModel toCompare) {

        bool result = false;

            if (toCompare != null) {
                result = string.Compare(toCompare.Type, Type, true) == 0
             && string.Compare(toCompare.Url, Url, true) == 0
             && string.Compare(toCompare.Username, Username, true) == 0
             && string.Compare(toCompare.Password, Password, true) == 0
;
            }

            return result;
        }
    }
}

