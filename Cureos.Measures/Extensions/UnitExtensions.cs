// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;
using System.Collections.Generic;
using System.Linq;

#if SINGLE
using AmountType = System.Single;
#elif DECIMAL
using AmountType = System.Decimal;
#elif DOUBLE
using AmountType = System.Double;
#endif

namespace Cureos.Measures.Extensions
{
    /// <summary>
    /// Helper class providing extension methods for the <see cref="EnumUnit">Unit enumeration</see>
    /// </summary>
    public static class UnitExtensions
    {
        #region STATIC MEMBER VARIABLES

        private static readonly Dictionary<EnumUnit, UnitDetails> smUnitDetailsMap;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes the unit details map, by specifying associated quantity, text symbol, reference unit status and
        /// amount conversion operators to and from reference unit
        /// </summary>
        static UnitExtensions()
        {
            smUnitDetailsMap = new UnitDetails[]
                                   {
                                       new UnitDetails(EnumUnit.Meter, EnumQuantity.Length, "m"),
                                       new UnitDetails(EnumUnit.DeciMeter, EnumQuantity.Length, "dm", Scales.Deci),
                                       new UnitDetails(EnumUnit.CentiMeter, EnumQuantity.Length, "cm", Scales.Centi),
                                       new UnitDetails(EnumUnit.MilliMeter, EnumQuantity.Length, "mm", Scales.Milli),
                                       new UnitDetails(EnumUnit.SquareMeter, EnumQuantity.Area, "m�"),
                                       new UnitDetails(EnumUnit.SquareDeciMeter, EnumQuantity.Area, "dm�", Scales.Square(Scales.Deci)),
                                       new UnitDetails(EnumUnit.SquareCentiMeter, EnumQuantity.Area, "cm�", Scales.Square(Scales.Centi)),
                                       new UnitDetails(EnumUnit.CubicMeter, EnumQuantity.Volume, "m�"),
                                       new UnitDetails(EnumUnit.Liter, EnumQuantity.Volume, "l", Scales.Cube(Scales.Deci)),
                                       new UnitDetails(EnumUnit.CubicDeciMeter, EnumQuantity.Volume, "dm�", Scales.Cube(Scales.Deci)),
                                       new UnitDetails(EnumUnit.CubicCentiMeter, EnumQuantity.Volume, "cm�", Scales.Cube(Scales.Centi)),
                                       new UnitDetails(EnumUnit.KiloGram, EnumQuantity.Mass, "kg"),
                                       new UnitDetails(EnumUnit.Tonne, EnumQuantity.Mass, "t", Scales.Kilo),
                                       new UnitDetails(EnumUnit.HectoGram, EnumQuantity.Mass, "hg", Scales.Deci),
                                       new UnitDetails(EnumUnit.Gram, EnumQuantity.Mass, "g", Scales.Milli),
                                       new UnitDetails(EnumUnit.Second, EnumQuantity.Time, "s"),
                                       new UnitDetails(EnumUnit.Minute, EnumQuantity.Time, "min", Scales.SecondsPerMinute),
                                       new UnitDetails(EnumUnit.Hour, EnumQuantity.Time, "h", Scales.SecondsPerHour),
                                       new UnitDetails(EnumUnit.Day, EnumQuantity.Time, "dy", Scales.SecondsPerDay),
                                       new UnitDetails(EnumUnit.Week, EnumQuantity.Time, "wk", Scales.SecondsPerWeek),
                                       new UnitDetails(EnumUnit.Kelvin, EnumQuantity.Temperature, "K"),
                                       new UnitDetails(EnumUnit.Celsius, EnumQuantity.Temperature, "�C",
                                                       a => a + Scales.CelsiusKelvinDifference, a => a - Scales.CelsiusKelvinDifference),
                                       new UnitDetails(EnumUnit.Joule, EnumQuantity.Energy, "J"),
                                       new UnitDetails(EnumUnit.KiloJoule, EnumQuantity.Energy, "kJ", Scales.Kilo),
                                       new UnitDetails(EnumUnit.Gray, EnumQuantity.AbsorbedDose, "Gy"),
                                       new UnitDetails(EnumUnit.CentiGray, EnumQuantity.AbsorbedDose, "cGy", Scales.Centi)
                                   }.ToDictionary(ud => ud.Unit);
        }

        #endregion

        #region EXTENSION METHODS

        /// <summary>
        /// Gets the quantity associated with the specified unit
        /// </summary>
        /// <param name="iUnit">Unit for which the associated quantity is requested</param>
        /// <returns>Quantity associated with the specified unit</returns>
        public static EnumQuantity GetQuantity(this EnumUnit iUnit)
        {
            return smUnitDetailsMap[iUnit].Quantity;
        }

        /// <summary>
        /// Gets the reference unit associated with the specified unit
        /// </summary>
        /// <param name="iUnit">Unit for which the reference unit is requested</param>
        /// <returns>Reference unit of the specified unit</returns>
        public static EnumUnit GetReferenceUnit(this EnumUnit iUnit)
        {
            return GetQuantity(iUnit).GetReferenceUnit();
        }

        /// <summary>
        /// Gets the text symbol of the specified unit
        /// </summary>
        /// <param name="iUnit">Unit for which the text symbol is requested</param>
        /// <returns>Text symbol for the specified unit</returns>
        public static string GetSymbol(this EnumUnit iUnit)
        {
            return smUnitDetailsMap[iUnit].Symbol;
        }

        /// <summary>
        /// Returns the <paramref name="iFromUnitAmount">specified amount</paramref>, given in the <paramref name="iFromUnit">
        /// specified unit</paramref>, converted into the reference unit of the specified unit
        /// </summary>
        /// <param name="iFromUnit">Unit of the measured amount</param>
        /// <param name="iFromUnitAmount">Measured amount in the specified unit</param>
        /// <returns>Amount given in the reference unit of the <paramref name="iFromUnit">specified unit</paramref></returns>
        public static AmountType ConvertAmountToReferenceUnit(this EnumUnit iFromUnit, AmountType iFromUnitAmount)
        {
            return smUnitDetailsMap[iFromUnit].AmountToReferenceUnitConverter(iFromUnitAmount);
        }

        /// <summary>
        /// Returns the <paramref name="iReferenceUnitAmount">specified amount</paramref>, given in a reference unit,
        /// converted into the <paramref name="iToUnit">corresponding specified unit</paramref> of the reference unit
        /// </summary>
        /// <param name="iToUnit">Unit into which the reference unit amount should be converted</param>
        /// <param name="iReferenceUnitAmount">Measured amount in the reference unit</param>
        /// <returns>Amount given in the <paramref name="iToUnit">specified unit</paramref> of the reference unit</returns>
        public static AmountType ConvertAmountFromReferenceUnit(this EnumUnit iToUnit, AmountType iReferenceUnitAmount)
        {
            return smUnitDetailsMap[iToUnit].AmountFromReferenceUnitConverter(iReferenceUnitAmount);
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Gets the collection of units associated with the <paramref name="iQuantity">specified quantity</paramref>
        /// </summary>
        /// <param name="iQuantity">Quantity for which the collection of units is requested</param>
        /// <returns>Collection of units associated with the <paramref name="iQuantity">specified quantity</paramref></returns>
        internal static IEnumerable<EnumUnit> GetUnits(EnumQuantity iQuantity)
        {
            return smUnitDetailsMap.Where(kv => kv.Value.Quantity.Equals(iQuantity)).Select(kv => kv.Key);
        }

        #endregion
        
        #region INNER SUPPORT CLASSES

        /// <summary>
        /// Symbol and amount conversion details associated with a physical unit
        /// A unit defined as a reference unit by convention has amount converters to itself
        /// </summary>
        private sealed class UnitDetails
        {
            #region CONSTRUCTORS

            /// <summary>
            /// Reference unit details constructor
            /// </summary>
            /// <param name="iUnit">Unit instance</param>
            /// <param name="iQuantity">Quantity for which this unit is reference unit</param>
            /// <param name="iSymbol">Unit symbol</param>
            internal UnitDetails(EnumUnit iUnit, EnumQuantity iQuantity, string iSymbol)
            {
                Unit = iUnit;
                Quantity = iQuantity;
                Symbol = iSymbol;
                AmountToReferenceUnitConverter = AmountFromReferenceUnitConverter = a => a;
                iQuantity.SetReferenceUnit(iUnit);
            }

            /// <summary>
            /// Initializes a non-reference unit instance which uses multiplicative conversion vis-a-vis the reference unit
            /// </summary>
            /// <param name="iUnit">Unit instance</param>
            /// <param name="iQuantity">Physical quantity associated with this unit</param>
            /// <param name="iSymbol">Unit symbol</param>
            /// <param name="iAmountToReferenceUnitFactor">Multiplicative factor for amount conversion to reference unit</param>
            internal UnitDetails(EnumUnit iUnit, EnumQuantity iQuantity, string iSymbol, AmountType iAmountToReferenceUnitFactor)
            {
                Unit = iUnit;
                Quantity = iQuantity;
                Symbol = iSymbol;
                AmountToReferenceUnitConverter = a => a * iAmountToReferenceUnitFactor;
                AmountFromReferenceUnitConverter = a => a / iAmountToReferenceUnitFactor;
            }

            /// <summary>
            /// Initializes a unit instance which uses a generic unit conversion
            /// </summary>
            /// <param name="iUnit">Unit instance</param>
            /// <param name="iQuantity">Physical quantity associated with this unit</param>
            /// <param name="iSymbol">Unit symbol</param>
            /// <param name="iAmountToReferenceUnitConverter">Function converting amount in this unit to reference unit amount</param>
            /// <param name="iAmountFromReferenceUnitConverter">Function converting reference unit amount to amount in this unit</param>
            internal UnitDetails(EnumUnit iUnit, EnumQuantity iQuantity, string iSymbol,
                Func<AmountType, AmountType> iAmountToReferenceUnitConverter,
                Func<AmountType, AmountType> iAmountFromReferenceUnitConverter)
            {
                Unit = iUnit;
                Quantity = iQuantity;
                Symbol = iSymbol;
                AmountToReferenceUnitConverter = iAmountToReferenceUnitConverter;
                AmountFromReferenceUnitConverter = iAmountFromReferenceUnitConverter;
            }

            #endregion

            #region AUTO-IMPLEMENTED PROPERTIES

            /// <summary>
            /// Gets the quantity associated with this unit
            /// </summary>
            internal EnumQuantity Quantity { get; private set; }

            internal EnumUnit Unit { get; private set; }

            /// <summary>
            /// Gets the unit symbol
            /// </summary>
            internal string Symbol { get; private set; }

            /// <summary>
            /// Gets the function used for converting an amount from this unit to the reference unit of the same dimension
            /// </summary>
            internal Func<AmountType, AmountType> AmountToReferenceUnitConverter { get; private set; }

            /// <summary>
            /// Gets the function used for converting an amount to this unit from the reference unit of the same dimension
            /// </summary>
            internal Func<AmountType, AmountType> AmountFromReferenceUnitConverter { get; private set; }

            #endregion
        }

        #endregion
    }
}