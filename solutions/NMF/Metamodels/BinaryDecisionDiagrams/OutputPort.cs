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
    
    
    /// <summary>
    /// The default implementation of the OutputPort class
    /// </summary>
    [XmlNamespaceAttribute("https://www.transformation-tool-contest.eu/2019/bdd")]
    [XmlNamespacePrefixAttribute("bdd")]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2019/bdd#//OutputPort")]
    [DebuggerDisplayAttribute("OutputPort {Name}")]
    public partial class OutputPort : Port, IOutputPort, IModelElement
    {
        
        private static Lazy<ITypedElement> _assignmentsReference = new Lazy<ITypedElement>(RetrieveAssignmentsReference);
        
        /// <summary>
        /// The backing field for the Assignments property
        /// </summary>
        private OutputPortAssignmentsCollection _assignments;
        
        private static IClass _classInstance;
        
        public OutputPort()
        {
            this._assignments = new OutputPortAssignmentsCollection(this);
            this._assignments.CollectionChanging += this.AssignmentsCollectionChanging;
            this._assignments.CollectionChanged += this.AssignmentsCollectionChanged;
        }
        
        /// <summary>
        /// The assignments property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("assignments")]
        [CategoryAttribute("OutputPort")]
        [XmlElementNameAttribute("assignments")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("port")]
        [ConstantAttribute()]
        public ISetExpression<IAssignment> Assignments
        {
            get
            {
                return this._assignments;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new OutputPortReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/bdd#//OutputPort")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveAssignmentsReference()
        {
            return ((ITypedElement)(((ModelElement)(OutputPort.ClassInstance)).Resolve("assignments")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Assignments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssignmentsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Assignments", e, _assignmentsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Assignments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssignmentsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Assignments", e, _assignmentsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ASSIGNMENTS"))
            {
                return this._assignments;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/bdd#//OutputPort")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OutputPort class
        /// </summary>
        public class OutputPortReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OutputPort _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OutputPortReferencedElementsCollection(OutputPort parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Assignments.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Assignments.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Assignments.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAssignment assignmentsCasted = item.As<IAssignment>();
                if ((assignmentsCasted != null))
                {
                    this._parent.Assignments.Add(assignmentsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Assignments.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Assignments.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> assignmentsEnumerator = this._parent.Assignments.GetEnumerator();
                try
                {
                    for (
                    ; assignmentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = assignmentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    assignmentsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAssignment assignmentItem = item.As<IAssignment>();
                if (((assignmentItem != null) 
                            && this._parent.Assignments.Remove(assignmentItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Assignments).GetEnumerator();
            }
        }
    }
}

