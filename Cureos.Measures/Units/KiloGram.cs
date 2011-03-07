// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;
using Cureos.Measures.Quantities;

namespace Cureos.Measures.Units
{
    public partial struct KiloGram : IUnit<Mass>
    {
        #region Implementation of IUnit

        public EnumUnit EnumeratedUnit
        {
            get { throw new NotImplementedException(); }
        }

        public string Symbol
        {
            get { return "kg"; }
        }

        #endregion

        #region Implementation of IUnit<Mass>

        public IQuantity<Mass> ReferencedQuantity
        {
            get { return Quantity.Mass; }
        }

        #endregion
    }
}