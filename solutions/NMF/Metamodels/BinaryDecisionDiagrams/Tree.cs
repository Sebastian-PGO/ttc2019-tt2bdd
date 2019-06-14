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
    /// The default implementation of the Tree class
    /// </summary>
    [XmlNamespaceAttribute("https://www.transformation-tool-contest.eu/2019/bdd")]
    [XmlNamespacePrefixAttribute("bdd")]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2019/bdd#//Tree")]
    public abstract partial class Tree : ModelElement, ITree, IModelElement
    {
        
        private static Lazy<ITypedElement> _ownerBDDReference = new Lazy<ITypedElement>(RetrieveOwnerBDDReference);
        
        /// <summary>
        /// The backing field for the OwnerBDD property
        /// </summary>
        private IBDD _ownerBDD;
        
        private static Lazy<ITypedElement> _ownerSubtreeForZeroReference = new Lazy<ITypedElement>(RetrieveOwnerSubtreeForZeroReference);
        
        /// <summary>
        /// The backing field for the OwnerSubtreeForZero property
        /// </summary>
        private ISubtree _ownerSubtreeForZero;
        
        private static Lazy<ITypedElement> _ownerSubtreeForOneReference = new Lazy<ITypedElement>(RetrieveOwnerSubtreeForOneReference);
        
        /// <summary>
        /// The backing field for the OwnerSubtreeForOne property
        /// </summary>
        private ISubtree _ownerSubtreeForOne;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ownerBDD property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("ownerBDD")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("tree")]
        public IBDD OwnerBDD
        {
            get
            {
                return this._ownerBDD;
            }
            set
            {
                if ((this._ownerBDD != value))
                {
                    IBDD old = this._ownerBDD;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOwnerBDDChanging(e);
                    this.OnPropertyChanging("OwnerBDD", e, _ownerBDDReference);
                    this._ownerBDD = value;
                    this.Parent = value;
                    if ((old != null))
                    {
                        old.Tree = null;
                    }
                    if ((value != null))
                    {
                        value.Tree = this;
                    }
                    this.OnOwnerBDDChanged(e);
                    this.OnPropertyChanged("OwnerBDD", e, _ownerBDDReference);
                }
            }
        }
        
        /// <summary>
        /// The ownerSubtreeForZero property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("ownerSubtreeForZero")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("treeForZero")]
        public ISubtree OwnerSubtreeForZero
        {
            get
            {
                return this._ownerSubtreeForZero;
            }
            set
            {
                if ((this._ownerSubtreeForZero != value))
                {
                    ISubtree old = this._ownerSubtreeForZero;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOwnerSubtreeForZeroChanging(e);
                    this.OnPropertyChanging("OwnerSubtreeForZero", e, _ownerSubtreeForZeroReference);
                    this._ownerSubtreeForZero = value;
                    if (value != null || this.Parent == old)
                    {
                        this.Parent = value;
                    }
                    if ((old != null))
                    {
                        old.TreeForZero = null;
                    }
                    if ((value != null))
                    {
                        value.TreeForZero = this;
                    }
                    this.OnOwnerSubtreeForZeroChanged(e);
                    this.OnPropertyChanged("OwnerSubtreeForZero", e, _ownerSubtreeForZeroReference);
                }
            }
        }
        
        /// <summary>
        /// The ownerSubtreeForOne property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("ownerSubtreeForOne")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("treeForOne")]
        public ISubtree OwnerSubtreeForOne
        {
            get
            {
                return this._ownerSubtreeForOne;
            }
            set
            {
                if ((this._ownerSubtreeForOne != value))
                {
                    ISubtree old = this._ownerSubtreeForOne;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOwnerSubtreeForOneChanging(e);
                    this.OnPropertyChanging("OwnerSubtreeForOne", e, _ownerSubtreeForOneReference);
                    this._ownerSubtreeForOne = value;
                    if (value != null || this.Parent == old)
                    {
                        this.Parent = value;
                    }
                    if ((old != null))
                    {
                        old.TreeForOne = null;
                    }
                    if ((value != null))
                    {
                        value.TreeForOne = this;
                    }
                    this.OnOwnerSubtreeForOneChanged(e);
                    this.OnPropertyChanged("OwnerSubtreeForOne", e, _ownerSubtreeForOneReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TreeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/bdd#//Tree")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the OwnerBDD property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OwnerBDDChanging;
        
        /// <summary>
        /// Gets fired when the OwnerBDD property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OwnerBDDChanged;
        
        /// <summary>
        /// Gets fired before the OwnerSubtreeForZero property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OwnerSubtreeForZeroChanging;
        
        /// <summary>
        /// Gets fired when the OwnerSubtreeForZero property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OwnerSubtreeForZeroChanged;
        
        /// <summary>
        /// Gets fired before the OwnerSubtreeForOne property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OwnerSubtreeForOneChanging;
        
        /// <summary>
        /// Gets fired when the OwnerSubtreeForOne property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OwnerSubtreeForOneChanged;
        
        private static ITypedElement RetrieveOwnerBDDReference()
        {
            return ((ITypedElement)(((ModelElement)(Tree.ClassInstance)).Resolve("ownerBDD")));
        }
        
        /// <summary>
        /// Raises the OwnerBDDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOwnerBDDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OwnerBDDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OwnerBDDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOwnerBDDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OwnerBDDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OwnerBDD property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOwnerBDD(object sender, System.EventArgs eventArgs)
        {
            this.OwnerBDD = null;
        }
        
        private static ITypedElement RetrieveOwnerSubtreeForZeroReference()
        {
            return ((ITypedElement)(((ModelElement)(Tree.ClassInstance)).Resolve("ownerSubtreeForZero")));
        }
        
        /// <summary>
        /// Raises the OwnerSubtreeForZeroChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOwnerSubtreeForZeroChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OwnerSubtreeForZeroChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OwnerSubtreeForZeroChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOwnerSubtreeForZeroChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OwnerSubtreeForZeroChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OwnerSubtreeForZero property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOwnerSubtreeForZero(object sender, System.EventArgs eventArgs)
        {
            this.OwnerSubtreeForZero = null;
        }
        
        private static ITypedElement RetrieveOwnerSubtreeForOneReference()
        {
            return ((ITypedElement)(((ModelElement)(Tree.ClassInstance)).Resolve("ownerSubtreeForOne")));
        }
        
        /// <summary>
        /// Raises the OwnerSubtreeForOneChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOwnerSubtreeForOneChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OwnerSubtreeForOneChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OwnerSubtreeForOneChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOwnerSubtreeForOneChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OwnerSubtreeForOneChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OwnerSubtreeForOne property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOwnerSubtreeForOne(object sender, System.EventArgs eventArgs)
        {
            this.OwnerSubtreeForOne = null;
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "OWNERBDD"))
            {
                return this.OwnerBDD;
            }
            if ((reference == "OWNERSUBTREEFORZERO"))
            {
                return this.OwnerSubtreeForZero;
            }
            if ((reference == "OWNERSUBTREEFORONE"))
            {
                return this.OwnerSubtreeForOne;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "OWNERBDD"))
            {
                this.OwnerBDD = ((IBDD)(value));
                return;
            }
            if ((feature == "OWNERSUBTREEFORZERO"))
            {
                this.OwnerSubtreeForZero = ((ISubtree)(value));
                return;
            }
            if ((feature == "OWNERSUBTREEFORONE"))
            {
                this.OwnerSubtreeForOne = ((ISubtree)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "OWNERBDD"))
            {
                return new OwnerBDDProxy(this);
            }
            if ((reference == "OWNERSUBTREEFORZERO"))
            {
                return new OwnerSubtreeForZeroProxy(this);
            }
            if ((reference == "OWNERSUBTREEFORONE"))
            {
                return new OwnerSubtreeForOneProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/bdd#//Tree")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Tree class
        /// </summary>
        public class TreeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Tree _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TreeReferencedElementsCollection(Tree parent)
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
                    if ((this._parent.OwnerBDD != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OwnerSubtreeForZero != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OwnerSubtreeForOne != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OwnerBDDChanged += this.PropagateValueChanges;
                this._parent.OwnerSubtreeForZeroChanged += this.PropagateValueChanges;
                this._parent.OwnerSubtreeForOneChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OwnerBDDChanged -= this.PropagateValueChanges;
                this._parent.OwnerSubtreeForZeroChanged -= this.PropagateValueChanges;
                this._parent.OwnerSubtreeForOneChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.OwnerBDD == null))
                {
                    IBDD ownerBDDCasted = item.As<IBDD>();
                    if ((ownerBDDCasted != null))
                    {
                        this._parent.OwnerBDD = ownerBDDCasted;
                        return;
                    }
                }
                if ((this._parent.OwnerSubtreeForZero == null))
                {
                    ISubtree ownerSubtreeForZeroCasted = item.As<ISubtree>();
                    if ((ownerSubtreeForZeroCasted != null))
                    {
                        this._parent.OwnerSubtreeForZero = ownerSubtreeForZeroCasted;
                        return;
                    }
                }
                if ((this._parent.OwnerSubtreeForOne == null))
                {
                    ISubtree ownerSubtreeForOneCasted = item.As<ISubtree>();
                    if ((ownerSubtreeForOneCasted != null))
                    {
                        this._parent.OwnerSubtreeForOne = ownerSubtreeForOneCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OwnerBDD = null;
                this._parent.OwnerSubtreeForZero = null;
                this._parent.OwnerSubtreeForOne = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.OwnerBDD))
                {
                    return true;
                }
                if ((item == this._parent.OwnerSubtreeForZero))
                {
                    return true;
                }
                if ((item == this._parent.OwnerSubtreeForOne))
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
                if ((this._parent.OwnerBDD != null))
                {
                    array[arrayIndex] = this._parent.OwnerBDD;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OwnerSubtreeForZero != null))
                {
                    array[arrayIndex] = this._parent.OwnerSubtreeForZero;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OwnerSubtreeForOne != null))
                {
                    array[arrayIndex] = this._parent.OwnerSubtreeForOne;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.OwnerBDD == item))
                {
                    this._parent.OwnerBDD = null;
                    return true;
                }
                if ((this._parent.OwnerSubtreeForZero == item))
                {
                    this._parent.OwnerSubtreeForZero = null;
                    return true;
                }
                if ((this._parent.OwnerSubtreeForOne == item))
                {
                    this._parent.OwnerSubtreeForOne = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OwnerBDD).Concat(this._parent.OwnerSubtreeForZero).Concat(this._parent.OwnerSubtreeForOne).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ownerBDD property
        /// </summary>
        private sealed class OwnerBDDProxy : ModelPropertyChange<ITree, IBDD>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OwnerBDDProxy(ITree modelElement) : 
                    base(modelElement, "ownerBDD")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IBDD Value
            {
                get
                {
                    return this.ModelElement.OwnerBDD;
                }
                set
                {
                    this.ModelElement.OwnerBDD = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ownerSubtreeForZero property
        /// </summary>
        private sealed class OwnerSubtreeForZeroProxy : ModelPropertyChange<ITree, ISubtree>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OwnerSubtreeForZeroProxy(ITree modelElement) : 
                    base(modelElement, "ownerSubtreeForZero")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISubtree Value
            {
                get
                {
                    return this.ModelElement.OwnerSubtreeForZero;
                }
                set
                {
                    this.ModelElement.OwnerSubtreeForZero = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ownerSubtreeForOne property
        /// </summary>
        private sealed class OwnerSubtreeForOneProxy : ModelPropertyChange<ITree, ISubtree>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OwnerSubtreeForOneProxy(ITree modelElement) : 
                    base(modelElement, "ownerSubtreeForOne")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISubtree Value
            {
                get
                {
                    return this.ModelElement.OwnerSubtreeForOne;
                }
                set
                {
                    this.ModelElement.OwnerSubtreeForOne = value;
                }
            }
        }
    }
}

