/*
 *  Copyright (c) 2011-2015, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSUnits.
 *
 *  CSUnits is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  CSUnits is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with CSUnits. If not, see http://www.gnu.org/licenses/.
 */

/*
 * This file is auto-generated.
 */

namespace Cureos.Measures.Quantities
{
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;

#if SINGLE
    using AmountType = System.Single;
#elif DECIMAL
    using AmountType = System.Decimal;
#elif DOUBLE
    using AmountType = System.Double;
#endif

    /// <summary>
    /// Implementation of the frequency quantity
    /// </summary>
    [DataContract]
    public partial struct Frequency : IQuantity<Frequency>, IMeasure<Frequency>, IEquatable<Frequency>, IComparable<Frequency>
    {
        #region FIELDS

        // ReSharper disable once InconsistentNaming
        private static readonly IMeasureFactory<Frequency> factory = new MeasureFactory();

        // ReSharper disable once InconsistentNaming
        private static readonly QuantityDimension dimension = new QuantityDimension(0, 0, -1, 0, 0, 0, 0);

        public static readonly Unit<Frequency> Hertz = new ConstantConverterUnit<Frequency>("Hz");

        public static readonly Unit<Frequency> NanoHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Nano);
        public static readonly Unit<Frequency> MicroHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Micro);
        public static readonly Unit<Frequency> MilliHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Milli);
        public static readonly Unit<Frequency> CentiHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Centi);
        public static readonly Unit<Frequency> DeciHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Deci);
        public static readonly Unit<Frequency> DekaHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Deka);
        public static readonly Unit<Frequency> HectoHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Hecto);
        public static readonly Unit<Frequency> KiloHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Kilo);
        public static readonly Unit<Frequency> MegaHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Mega);
        public static readonly Unit<Frequency> GigaHertz = new ConstantConverterUnit<Frequency>(UnitPrefix.Giga);

        [DataMember]
        private readonly AmountType amount;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Static constructor for defining static class properties
        /// </summary>
        static Frequency()
        {
            Zero = new Frequency(Constants.Zero);
            Epsilon = new Frequency(Constants.MachineEpsilon);
        }
        
        /// <summary>
        /// Initializes a frequency object from an object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="other">Object implemeting the IMeasure&lt;Frequency&gt; interface</param>
        public Frequency(IMeasure<Frequency> other)
            : this(other.StandardAmount)
        {
        }

        /// <summary>
        /// Initializes a measure to the specified amount and standard unit of the measured quantity
        /// </summary>
        /// <param name="amount">Measured amount in standard unit of the specified quantity</param>
        public Frequency(double amount)
        {
            this.amount = (AmountType)amount;
        }

        /// <summary>
        /// Initializes a measure to the specified amount and standard unit of the measured quantity
        /// </summary>
        /// <param name="amount">Measured amount in standard unit of the specified quantity</param>
        public Frequency(float amount)
        {
            this.amount = (AmountType)amount;
        }

        /// <summary>
        /// Initializes a measure to the specified amount and standard unit of the measured quantity
        /// </summary>
        /// <param name="amount">Measured amount in standard unit of the specified quantity</param>
        public Frequency(decimal amount)
        {
            this.amount = (AmountType)amount;
        }

        /// <summary>
        /// Initializes a measure to the specified amount and unit
        /// </summary>
        /// <param name="amount">Measured amount</param>
        /// <param name="unit">Unit of measure</param>
        /// <exception cref="ArgumentNullException">if the specified unit is null</exception>
        public Frequency(double amount, IUnit<Frequency> unit)
        {
            if (unit == null) throw new ArgumentNullException("unit");
            this.amount = unit.ConvertAmountToStandardUnit((AmountType)amount);
        }

        /// <summary>
        /// Initializes a measure to the specified amount and unit
        /// </summary>
        /// <param name="amount">Measured amount</param>
        /// <param name="unit">Unit of measure</param>
        /// <exception cref="ArgumentNullException">if the specified unit is null</exception>
        public Frequency(float amount, IUnit<Frequency> unit)
        {
            if (unit == null) throw new ArgumentNullException("unit");
            this.amount = unit.ConvertAmountToStandardUnit((AmountType)amount);
        }

        /// <summary>
        /// Initializes a measure to the specified amount and unit
        /// </summary>
        /// <param name="amount">Measured amount</param>
        /// <param name="unit">Unit of measure</param>
        /// <exception cref="ArgumentNullException">if the specified unit is null</exception>
        public Frequency(decimal amount, IUnit<Frequency> unit)
        {
            if (unit == null) throw new ArgumentNullException("unit");
            this.amount = unit.ConvertAmountToStandardUnit((AmountType)amount);
        }

        #endregion

        #region Implementation of IQuantity<Frequency>

        /// <summary>
        /// Gets the display name of the quantity
        /// </summary>
        public string DisplayName 
        { 
            get { return "Frequency"; } 
        }

        /// <summary>
        /// Gets the physical dimension of the quantity in terms of SI units
        /// </summary>
        QuantityDimension IQuantity.Dimension
        {
            get { return dimension; }
        }

        /// <summary>
        /// Gets the standard unit associated with the quantity
        /// </summary>
        IUnit IQuantity.StandardUnit
        {
            get { return this.StandardUnit; }
        }

        /// <summary>
        /// Gets the standard unit associated with the quantity
        /// </summary>
        public IUnit<Frequency> StandardUnit
        {
            get { return Hertz; }
        }

        /// <summary>
        /// Gets the measure factory associated with the quantity.
        /// </summary>
        IMeasureFactory<Frequency> IQuantity<Frequency>.Factory
        { 
            get { return factory; }
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        bool IEquatable<IQuantity>.Equals(IQuantity other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }
            return other is Frequency;
        }

        #endregion

        #region Implementation of IMeasure<Frequency>

        /// <summary>
        /// Gets the measured amount in the <see cref="StandardUnit">standard unit of measure</see>
        /// </summary>
        public AmountType Amount
        {
            get { return this.amount; }
        }

        /// <summary>
        /// Gets the measured amount in the standard unit of measure for the frequency quantity
        /// </summary>
        public AmountType StandardAmount
        {
            get { return this.amount; }
        }

        /// <summary>
        /// Gets the unit of measure
        /// </summary>
        /// <remarks>Always return the standard unit of measure</remarks>
        IUnit IMeasure.Unit
        {
            get { return this.StandardUnit; }
        }

        /// <summary>
        /// Gets the amount of this measure in the requested unit
        /// </summary>
        /// <param name="unit">Unit to which the measured amount should be converted</param>
        /// <returns>Measured amount converted into <paramref name="unit">specified unit</paramref></returns>
        AmountType IMeasure.GetAmount(IUnit unit)
        {
            return this.GetAmount(unit as IUnit<Frequency>);
        }

        /// <summary>
        /// Gets a new unit specific measure based on this measure but in the <paramref name="unit">specified unit</paramref>
        /// </summary>
        /// <param name="unit">Unit in which the new measure should be specified</param>
        /// <exception cref="ArgumentNullException">if specified unit is null or if specified unit is not of the Frequency quantity.</exception>
        IMeasure IMeasure.this[IUnit unit]
        {
            get { return this[unit as IUnit<Frequency>]; }
        }

        /// <summary>
        /// Gets the quantity-typed unit of measure
        /// </summary>
        /// <remarks>Always return the standard unit of measure</remarks>
        public IUnit<Frequency> Unit
        {
            get { return this.StandardUnit; }
        }

        /// <summary>
        /// Gets the amount of this measure in the requested unit
        /// </summary>
        /// <param name="unit">Unit to which the measured amount should be converted</param>
        /// <returns>Measured amount converted into <paramref name="unit">specified unit</paramref></returns>
        public AmountType GetAmount(IUnit<Frequency> unit)
        {
            if (unit == null) throw new ArgumentNullException("unit");
            return unit.ConvertStandardAmountToUnit(this.amount);
        }

        /// <summary>
        /// Gets a new unit specific measure based on this measure but in the <paramref name="unit">specified unit</paramref>
        /// </summary>
        /// <param name="unit">Unit in which the new measure should be specified</param>
        IMeasure<Frequency> IMeasure<Frequency>.this[IUnit<Frequency> unit]
        {
            get { return this[unit]; }
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        bool IEquatable<IMeasure<Frequency>>.Equals(IMeasure<Frequency> other)
        {
            if (ReferenceEquals(null, other)) return false;
            return this.amount.Equals(other.StandardAmount);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        bool IEquatable<IMeasure>.Equals(IMeasure other)
        {
            return this.Equals(other as IMeasure<Frequency>);
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <returns>
        /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings:  
        ///    Value              Meaning 
        ///    Less than zero     This object is less than the <paramref name="other"/> parameter.
        ///    Zero               This object is equal to <paramref name="other"/>. 
        ///    Greater than zero  This object is greater than <paramref name="other"/>. 
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        int IComparable<IMeasure<Frequency>>.CompareTo(IMeasure<Frequency> other)
        {
            if (other == null) throw new ArgumentNullException("other");
            return this.amount.CompareTo(other.StandardAmount);
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has the following meanings:  
        ///    Value              Meaning 
        ///    Less than zero     This object is less than the <paramref name="other"/> parameter.
        ///    Zero               This object is equal to <paramref name="other"/>. 
        ///    Greater than zero  This object is greater than <paramref name="other"/>. 
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        int IComparable<IMeasure>.CompareTo(IMeasure other)
        {
            if (other == null) throw new ArgumentNullException("other");
            if (!(other.Unit.Quantity is IMeasure<Frequency>)) throw new ArgumentException("Measures are of different quantities");
            return this.amount.CompareTo(other.StandardAmount);
        }

        #endregion

        #region Implementation of IEquatable<Frequency>

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Frequency other)
        {
            return this.amount.Equals(other.amount);
        }

        #endregion

        #region Implementation of IComparable<Frequency>

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <returns>
        /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings:  
        ///    Value              Meaning 
        ///    Less than zero     This object is less than the <paramref name="other"/> parameter.
        ///    Zero               This object is equal to <paramref name="other"/>. 
        ///    Greater than zero  This object is greater than <paramref name="other"/>. 
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public int CompareTo(Frequency other)
        {
            return this.amount.CompareTo(other.amount);
        }

        #endregion

        #region INDEXERS

        /// <summary>
        /// Gets a new unit preserving measure based on this measure but in the <paramref name="unit">specified unit</paramref>
        /// </summary>
        /// <param name="unit">Unit in which the new measure should be specified</param>
        public Measure<Frequency> this[IUnit<Frequency> unit]
        {
            get
            {
                if (unit == null) throw new ArgumentNullException("unit");
                return new Measure<Frequency>(this.GetAmount(unit), unit);
            }
        }

        #endregion

        #region PROPERTIES
        
        public static Frequency Zero { get; private set; }

        public static Frequency Epsilon { get; private set; }

        #endregion
        
        #region METHODS

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
        /// <exception cref="T:System.NullReferenceException">The <paramref name="obj"/> parameter is null.</exception>
        /// <filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            return obj is IMeasure<Frequency> && this.Equals((IMeasure<Frequency>)obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return this.amount.GetHashCode();
        }

        /// <summary>
        /// Returns the actual value with the quantity suffixed
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> containing a the actual value with the quantity symbol appended
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns the actual value in formatted form with the quantity suffixed
        /// </summary>
        /// <param name="format">Format string to display the value with</param>
        /// <returns>A <see cref="T:System.String"/> containing a the actual value in formatted form with the quantity symbol appended</returns>
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }
        
        /// <summary>
        /// Returns the actual value in formatted form with the quantity suffixed
        /// </summary>
        /// <param name="provider">Formatting provider to format the value with</param>
        /// <returns></returns>
        public string ToString(IFormatProvider provider)
        {
            return this.ToString("G", provider);
        }
        
        /// <summary>
        /// Returns the actual value in formatted form with the quantity suffixed
        /// </summary>
        /// <param name="format">Format string to display the value with</param>
        /// <param name="provider">Formatting provider to format the value with</param>
        /// <returns></returns>
        public string ToString(string format, IFormatProvider provider)
        {
            return String.Format("({0}) {1} {2}", this.DisplayName, this.amount.ToString(format, provider), this.Unit.Symbol).TrimEnd();
        }
        
        #endregion

        #region OPERATORS

        /// <summary>
        /// Casts a double value to a Frequency object
        /// </summary>
        /// <param name="standardAmount">Standard amount</param>
        /// <returns>Frequency representation of <paramref name="standardAmount"/> in unit Hertz</returns>
        public static explicit operator Frequency(double standardAmount)
        {
            return new Frequency(standardAmount);
        }

        /// <summary>
        /// Casts a float value to a Frequency object
        /// </summary>
        /// <param name="standardAmount">Standard amount</param>
        /// <returns>Frequency representation of <paramref name="standardAmount"/> in unit Hertz</returns>
        public static explicit operator Frequency(float standardAmount)
        {
            return new Frequency(standardAmount);
        }

        /// <summary>
        /// Casts a decimal value to a Frequency object
        /// </summary>
        /// <param name="standardAmount">Standard amount</param>
        /// <returns>Frequency representation of <paramref name="standardAmount"/> in unit Hertz</returns>
        public static explicit operator Frequency(decimal standardAmount)
        {
            return new Frequency(standardAmount);
        }
        
        /// <summary>
        /// Adds two measure objects provided the measured quantities are equal
        /// </summary>
        /// <param name="lhs">First measure term</param>
        /// <param name="rhs">Second measure term</param>
        /// <returns>Sum of the two measure objects in the unit of the <paramref name="lhs">left-hand side measure</paramref></returns>
        public static Frequency operator +(Frequency lhs,  Frequency rhs)
        {
            return new Frequency(lhs.amount + rhs.amount);
        }

        /// <summary>
        /// Adds two measure objects provided the measured quantities are equal
        /// </summary>
        /// <param name="lhs">First measure term</param>
        /// <param name="rhs">Second measure term (any object implementing the IMeasure interface)</param>
        /// <returns>Sum of the two measure objects in the unit of the <paramref name="lhs">left-hand side measure</paramref></returns>
        public static Frequency operator +(Frequency lhs, IMeasure<Frequency> rhs)
        {
            return new Frequency(lhs.amount + rhs.StandardAmount);
        }

        /// <summary>
        /// Subtract two measure objects of the same quantity
        /// </summary>
        /// <param name="lhs">First measure object</param>
        /// <param name="rhs">Second measure object</param>
        /// <returns>Difference of the measure objects</returns>
        public static Frequency operator -(Frequency lhs, Frequency rhs)
        {
            return new Frequency(lhs.amount - rhs.amount);
        }

        /// <summary>
        /// Subtract two measure objects of the same quantity
        /// </summary>
        /// <param name="lhs">First measure object</param>
        /// <param name="rhs">Second measure object (any object implementing the IMeasure interface)</param>
        /// <returns>Difference of the measure objects</returns>
        public static Frequency operator -(Frequency lhs, IMeasure<Frequency> rhs)
        {
            return new Frequency(lhs.amount - rhs.StandardAmount);
        }

        /// <summary>
        /// Multiply a scalar and a measure object
        /// </summary>
        /// <param name="scalar">Floating-point scalar</param>
        /// <param name="measure">Measure object</param>
        /// <returns>Product of the scalar and the measure object</returns>
        public static Frequency operator *(double scalar, Frequency measure)
        {
            return new Frequency((AmountType)scalar * measure.amount);
        }

        /// <summary>
        /// Multiply a scalar and a measure object
        /// </summary>
        /// <param name="scalar">Floating-point scalar</param>
        /// <param name="measure">Measure object</param>
        /// <returns>Product of the scalar and the measure object</returns>
        public static Frequency operator *(float scalar, Frequency measure)
        {
            return new Frequency((AmountType)scalar * measure.amount);
        }

        /// <summary>
        /// Multiply a scalar and a measure object
        /// </summary>
        /// <param name="scalar">Floating-point scalar</param>
        /// <param name="measure">Measure object</param>
        /// <returns>Product of the scalar and the measure object</returns>
        public static Frequency operator *(decimal scalar, Frequency measure)
        {
            return new Frequency((AmountType)scalar * measure.amount);
        }

        /// <summary>
        /// Multiply a measure object and a scalar
        /// </summary>
        /// <param name="measure">Measure object</param>
        /// <param name="scalar">Floating-point scalar</param>
        /// <returns>Product of the measure object and the scalar</returns>
        public static Frequency operator *(Frequency measure, double scalar)
        {
            return new Frequency(measure.amount * (AmountType)scalar);
        }

        /// <summary>
        /// Multiply a measure object and a scalar
        /// </summary>
        /// <param name="measure">Measure object</param>
        /// <param name="scalar">Floating-point scalar</param>
        /// <returns>Product of the measure object and the scalar</returns>
        public static Frequency operator *(Frequency measure, float scalar)
        {
            return new Frequency(measure.amount * (AmountType)scalar);
        }

        /// <summary>
        /// Multiply a measure object and a scalar
        /// </summary>
        /// <param name="measure">Measure object</param>
        /// <param name="scalar">Floating-point scalar</param>
        /// <returns>Product of the measure object and the scalar</returns>
        public static Frequency operator *(Frequency measure, decimal scalar)
        {
            return new Frequency(measure.amount * (AmountType)scalar);
        }

        /// <summary>
        /// Multiply a measure object and a number
        /// </summary>
        /// <param name="measure">Measure object</param>
        /// <param name="scalar">Floating-point number</param>
        /// <returns>Product of the measure object and the number</returns>
        public static Frequency operator *(Frequency measure, IMeasure<Number> scalar)
        {
            return new Frequency(measure.amount * scalar.StandardAmount);
        }

        /// <summary>
        /// Divide a measure object with a scalar
        /// </summary>
        /// <param name="measure">measure object</param>
        /// <param name="scalar">Floating-point scalar</param>
        /// <returns>Quotient of the measure object and the scalar</returns>
        public static Frequency operator /(Frequency measure, double scalar)
        {
            return new Frequency(measure.amount / (AmountType)scalar);
        }

        /// <summary>
        /// Divide a measure object with a scalar
        /// </summary>
        /// <param name="measure">measure object</param>
        /// <param name="scalar">Floating-point scalar</param>
        /// <returns>Quotient of the measure object and the scalar</returns>
        public static Frequency operator /(Frequency measure, float scalar)
        {
            return new Frequency(measure.amount / (AmountType)scalar);
        }

        /// <summary>
        /// Divide a measure object with a scalar
        /// </summary>
        /// <param name="measure">measure object</param>
        /// <param name="scalar">Floating-point scalar</param>
        /// <returns>Quotient of the measure object and the scalar</returns>
        public static Frequency operator /(Frequency measure, decimal scalar)
        {
            return new Frequency(measure.amount / (AmountType)scalar);
        }

        /// <summary>
        /// Divide a measure object with a number
        /// </summary>
        /// <param name="measure">measure object</param>
        /// <param name="scalar">Floating-point number</param>
        /// <returns>Quotient of the measure object and the number</returns>
        public static Frequency operator /(Frequency measure, IMeasure<Number> scalar)
        {
            return new Frequency(measure.amount / scalar.StandardAmount);
        }

        /// <summary>
        /// Divide a measure object with a measure object of the same quantity
        /// </summary>
        /// <param name="dividend">Dividend of specific quantity</param>
        /// <param name="divisor">Divisor of same quantity as dividend</param>
        /// <returns>Quotient of the two measure objects</returns>
        public static Number operator /(Frequency dividend, Frequency divisor)
        {
            return new Number(dividend.amount / divisor.amount);
        }

        /// <summary>
        /// Divide a measure object with a measure object of the same quantity
        /// </summary>
        /// <param name="dividend">Dividend of specific quantity</param>
        /// <param name="divisor">Divisor of same quantity as dividend</param>
        /// <returns>Quotient of the two measure objects</returns>
        public static Number operator /(Frequency dividend, IMeasure<Frequency> divisor)
        {
            return new Number(dividend.amount / divisor.StandardAmount);
        }

        /// <summary>
        /// Less than operator for measure objects
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if first measure object is less than second measure object; false otherwise</returns>
        public static bool operator <(Frequency lhs, Frequency rhs)
        {
            return lhs.amount < rhs.amount;
        }

        /// <summary>
        /// Less than operator for measure objects, where right-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <returns>true if first measure object is less than second measure object; false otherwise</returns>
        public static bool operator <(Frequency lhs, IMeasure<Frequency> rhs)
        {
            return lhs.amount < rhs.StandardAmount;
        }

        /// <summary>
        /// Less than operator for measure objects, where left-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if first measure object is less than second measure object; false otherwise</returns>
        public static bool operator <(IMeasure<Frequency> lhs, Frequency rhs)
        {
            return lhs.StandardAmount < rhs.amount;
        }

        /// <summary>
        /// Greater than operator for measure objects
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if first measure object is greater than second measure object; false otherwise</returns>
        public static bool operator >(Frequency lhs, Frequency rhs)
        {
            return lhs.amount > rhs.amount;
        }

        /// <summary>
        /// Greater than operator for measure objects, where right-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <returns>true if first measure object is greater than second measure object; false otherwise</returns>
        public static bool operator >(Frequency lhs, IMeasure<Frequency> rhs)
        {
            return lhs.amount > rhs.StandardAmount;
        }

        /// <summary>
        /// Greater than operator for measure objects, where left-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if first measure object is greater than second measure object; false otherwise</returns>
        public static bool operator >(IMeasure<Frequency> lhs, Frequency rhs)
        {
            return lhs.StandardAmount > rhs.amount;
        }

        /// <summary>
        /// Less than or equal to operator for measure objects
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if first measure object is less than or equal to second measure object; false otherwise</returns>
        public static bool operator <=(Frequency lhs, Frequency rhs)
        {
            return lhs.amount <= rhs.amount;
        }

        /// <summary>
        /// Less than or equal to operator for measure objects, where right-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <returns>true if first measure object is less than or equal to second measure object; false otherwise</returns>
        public static bool operator <=(Frequency lhs, IMeasure<Frequency> rhs)
        {
            return lhs.amount <= rhs.StandardAmount;
        }

        /// <summary>
        /// Less than or equal to operator for measure objects, where left-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if first measure object is less than or equal to second measure object; false otherwise</returns>
        public static bool operator <=(IMeasure<Frequency> lhs, Frequency rhs)
        {
            return lhs.StandardAmount <= rhs.amount;
        }

        /// <summary>
        /// Greater than or equal to operator for measure objects
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if first measure object is greater than or equal to second measure object; false otherwise</returns>
        public static bool operator >=(Frequency lhs, Frequency rhs)
        {
            return lhs.amount >= rhs.amount;
        }

        /// <summary>
        /// Greater than or equal to operator for measure objects, where right-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <returns>true if first measure object is greater than or equal to second measure object; false otherwise</returns>
        public static bool operator >=(Frequency lhs, IMeasure<Frequency> rhs)
        {
            return lhs.amount >= rhs.StandardAmount;
        }

        /// <summary>
        /// Greater than or equal to operator for measure objects, where left-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if first measure object is greater than or equal to second measure object; false otherwise</returns>
        public static bool operator >=(IMeasure<Frequency> lhs, Frequency rhs)
        {
            return lhs.StandardAmount >= rhs.amount;
        }

        /// <summary>
        /// Equality operator for measure objects
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if the two measure objects are equal; false otherwise</returns>
        public static bool operator ==(Frequency lhs, Frequency rhs)
        {
            return lhs.amount == rhs.amount;
        }

        /// <summary>
        /// Equality operator for measure objects, where right-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <returns>true if the two measure objects are equal; false otherwise</returns>
        public static bool operator ==(Frequency lhs, IMeasure<Frequency> rhs)
        {
            return lhs.amount == rhs.StandardAmount;
        }

        /// <summary>
        /// Equality operator for measure objects, where left-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if the two measure objects are equal; false otherwise</returns>
        public static bool operator ==(IMeasure<Frequency> lhs, Frequency rhs)
        {
            return lhs.StandardAmount == rhs.amount;
        }

        /// <summary>
        /// Inequality operator for measure objects
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if the two measure objects are not equal; false if they are equal</returns>
        public static bool operator !=(Frequency lhs, Frequency rhs)
        {
            return lhs.amount != rhs.amount;
        }

        /// <summary>
        /// Inequality operator for measure objects, where right-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <returns>true if the two measure objects are not equal; false if they are equal</returns>
        public static bool operator !=(Frequency lhs, IMeasure<Frequency> rhs)
        {
            return lhs.amount != rhs.StandardAmount;
        }

        /// <summary>
        /// Inequality operator for measure objects, where left-hand side may be any object implementing the IMeasure&lt;Frequency&gt; interface
        /// </summary>
        /// <param name="lhs">First object (any object implementing IMeasure&lt;Frequency&gt; interface)</param>
        /// <param name="rhs">Second object</param>
        /// <returns>true if the two measure objects are not equal; false if they are equal</returns>
        public static bool operator !=(IMeasure<Frequency> lhs, Frequency rhs)
        {
            return lhs.StandardAmount != rhs.amount;
        }

        #endregion

        #region Private class implementation of IMeasureFactory<Frequency>

        private class MeasureFactory : IMeasureFactory<Frequency>
        {
            /// <summary>
            /// Creates a new standard unit measure at the specified <paramref name="amount"/>.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <returns>Standard unit measure at the specified <paramref name="amount"/>.</returns>
            public Frequency New(double amount)
            {
                return new Frequency(amount);
            }

            /// <summary>
            /// Creates a new standard unit measure.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <param name="unit">Unit.</param>
            /// <returns>Standard unit measure.</returns>
            public Frequency New(double amount, IUnit<Frequency> unit)
            {
                return new Frequency(amount, unit);
            }

            /// <summary>
            /// Creates a new standard unit measure at the specified <paramref name="amount"/>.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <returns>Standard unit measure at the specified <paramref name="amount"/>.</returns>
            public Frequency New(float amount)
            {
                return new Frequency(amount);
            }

            /// <summary>
            /// Creates a new standard unit measure.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <param name="unit">Unit.</param>
            /// <returns>Standard unit measure.</returns>
            public Frequency New(float amount, IUnit<Frequency> unit)
            {
                return new Frequency(amount, unit);
            }

            /// <summary>
            /// Creates a new standard unit measure at the specified <paramref name="amount"/>.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <returns>Standard unit measure at the specified <paramref name="amount"/>.</returns>
            public Frequency New(decimal amount)
            {
                return new Frequency(amount);
            }

            /// <summary>
            /// Creates a new standard unit measure.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <param name="unit">Unit.</param>
            /// <returns>Standard unit measure.</returns>
            public Frequency New(decimal amount, IUnit<Frequency> unit)
            {
                return new Frequency(amount, unit);
            }

            /// <summary>
            /// Creates a new measure from the specified <paramref name="amount"/> and <paramref name="unit"/>.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <param name="unit">Unit.</param>
            /// <returns>Measure from the specified <paramref name="amount"/> and <paramref name="unit"/>.</returns>
            public IMeasure<Frequency> NewPreserveUnit(double amount, IUnit<Frequency> unit)
            {
                return new Measure<Frequency>(amount, unit);
            }

            /// <summary>
            /// Creates a new measure from the specified <paramref name="amount"/> and <paramref name="unit"/>.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <param name="unit">Unit.</param>
            /// <returns>Measure from the specified <paramref name="amount"/> and <paramref name="unit"/>.</returns>
            public IMeasure<Frequency> NewPreserveUnit(float amount, IUnit<Frequency> unit)
            {
                return new Measure<Frequency>(amount, unit);
            }

            /// <summary>
            /// Creates a new measure from the specified <paramref name="amount"/> and <paramref name="unit"/>.
            /// </summary>
            /// <param name="amount">Amount.</param>
            /// <param name="unit">Unit.</param>
            /// <returns>Measure from the specified <paramref name="amount"/> and <paramref name="unit"/>.</returns>
            public IMeasure<Frequency> NewPreserveUnit(decimal amount, IUnit<Frequency> unit)
            {
                return new Measure<Frequency>(amount, unit);
            }
        }

        #endregion
    }
}
