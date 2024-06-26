//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2019.BinaryDecision.Metamodels.TruthTables.TT
{
    
    
    /// <summary>
    /// The public interface for LocatedElement
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(LocatedElement))]
    [XmlDefaultImplementationTypeAttribute(typeof(LocatedElement))]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2019/tt#//LocatedElement")]
    public interface ILocatedElement : IModelElement
    {
        
        /// <summary>
        /// The location property
        /// </summary>
        [DisplayNameAttribute("location")]
        [CategoryAttribute("LocatedElement")]
        [XmlElementNameAttribute("location")]
        [XmlAttributeAttribute(true)]
        string Location
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Location property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocationChanging;
        
        /// <summary>
        /// Gets fired when the Location property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocationChanged;
    }
}

