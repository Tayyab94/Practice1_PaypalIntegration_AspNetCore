/*********************************************************
       Code Generated By  .  .  .  .  Delaney's Script Bot
       WWW .  .  .  .  .  .  .  .  .  www.scriptbot.io
       Version.  .  .  .  .  .  .  .  10.0.0.14 
       Build  .  .  .  .  .  .  .  .  20191113 216
       Template Name.  .  .  .  .  .  Project Green 2.0
       Template Version.  .  .  .  .  20191030 002
       Author .  .  .  .  .  .  .  .  Delaney

                      ,        ,--,_
                       \ _ ___/ /\|
                       ( )__, )
                      |/_  '--,
                        \ `  / '
 
 Note: Do not send this object to the view.
       Use objects create from Models classes instead.
       This class in a representation of data objects.
 
 *********************************************************/
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Delaney.Services.Data.Core.Domain
{
    [XmlType(Namespace = "")]
    public partial class Product : Services.Data.Core.Domain.Abstract
    {
        public Product()
        {
            _createdDate = System.DateTime.Now;
        }
        #region Properties
        /// <summary>
        /// Primary Key
        /// </summary>
        public int? Id { get; set; }

        #region Description
        private string _description = "";
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if(value != null)
                    value = value.Trim();

                if (_description != value)
                {
                    _description = value;
                    IsSaved = false;
                }
            }
        }
        #endregion

        #region Name
        private string _name = "";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value != null)
                    value = value.Trim();

                if (_name != value)
                {
                    _name = value;
                    IsSaved = false;
                }
            }
        }
        #endregion

        #region Price
        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    IsSaved = false;
                }
            }
        }
        #endregion

        #region Quantity
        private int _quantity;
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    IsSaved = false;
                }
            }
        }
        #endregion

        private Core.Domain.Basket _backet = null;
        [IgnoreDataMember]
        [XmlIgnore]
        public Core.Domain.Basket Basket 
        { 
            get
            {
                return _backet;
            }
            set
            {
                if(_backet != value)
                {
                    _backet = value;
                    _backetId = null;
                }
            }            
        }
        
        private int? _backetId = null;
        public int? BacketId
        {
            get
            {
                if(_backetId == null
                && Basket != null)
                    _backetId = Basket.Id;

                return _backetId;
            }
            set
            {
                if (_backetId != value)
                {
                    _backetId = value;
                    IsSaved = false;
                }
            }
        }
        #endregion
        
        #region Methods
        public override void Update(Abstract entity)
        {
            var product = (Product)entity;

            BacketId = product.BacketId;
            Description = product.Description;
            Name = product.Name;
            Price = product.Price;
            Quantity = product.Quantity;
        }
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}