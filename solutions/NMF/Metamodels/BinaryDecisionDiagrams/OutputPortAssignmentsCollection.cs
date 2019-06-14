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

namespace TTC2019.BinaryDecision.Metamodels.BinaryDecisionDiagrams.BDD
{
    
    
    public class OutputPortAssignmentsCollection : ObservableOppositeSet<IOutputPort, IAssignment>
    {
        
        public OutputPortAssignmentsCollection(IOutputPort parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, System.EventArgs e)
        {
            this.Remove(((IAssignment)(sender)));
        }
        
        protected override void SetOpposite(IAssignment item, IOutputPort parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.Port = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.Port == this.Parent))
                {
                    item.Port = parent;
                }
            }
        }
    }
}

