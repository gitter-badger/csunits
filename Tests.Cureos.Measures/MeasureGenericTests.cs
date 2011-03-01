﻿// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;
using Cureos.Measures;
using Cureos.Measures.Quantities;
using NUnit.Framework;

namespace Tests.Cureos.Measures
{
    [TestFixture]
    public class MeasureGenericTests
    {
        #region Test Methods

        [Test]
        public void Constructor_WithNonReferenceUnit_InitializesMeasureInReferenceUnit()
        {
            var expected = new Measure(180.0, Unit.Second);
            var actual = new Measure<Time>(3.0, Unit.Minute);
            MeasureAssert.MeasuresAreEqual(expected, actual);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Constructor_WithUnitOfDifferentQuantity_Throws()
        {
            var throws = new Measure<AbsorbedDose>(1.0, Unit.Minute);
        }

        [Test]
        public void DivisionOperator_DivideGenericSameQuantity_ReturnsScalar()
        {
            var expected = 1.0;
            var numerator = new Measure<Area>(500.0, Unit.SquareCentiMeter);
            var denominator = new Measure<Area>(5.0, Unit.SquareDeciMeter);
            var actual = (double) (numerator/denominator);
            Assert.AreEqual(expected, actual, 1.0e-7);
        }

        [Test]
        public void Times_MultiplyAreaAndLength_ReturnsVolume()
        {
            var expected = new Measure<Volume>(6.0);
            var lhs = new Measure<Area>(2.0);
            var rhs = new Measure<Length>(3.0);
            var actual = Measure<Volume>.Times(lhs, rhs);
            MeasureAssert.MeasuresAreEqual(expected, actual);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Times_MultiplyAreaAndAreaToVolume_Throws()
        {
            var lhs = new Measure<Area>(2.0);
            var rhs = new Measure<Area>(3.0);
            var throws = Measure<Volume>.Times(lhs, rhs);
        }

        [Test]
        public void Divide_DivideVolumeAndLength_ReturnsArea()
        {
            var expected = new Measure<Area>(4.0);
            var numerator = new Measure<Volume>(8.0);
            var denominator = new Measure<Length>(200.0, Unit.CentiMeter);
            var actual = Measure<Area>.Divide(numerator, denominator);
            MeasureAssert.MeasuresAreEqual(expected, actual);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Divide_DivideAreaAndAreaToLength_Throws()
        {
            var numerator = new Measure<Area>(8.0);
            var denominator = new Measure<Area>(200.0, Unit.SquareDeciMeter);
            var throws = Measure<Length>.Divide(numerator, denominator);
        }

        #endregion
    }
}