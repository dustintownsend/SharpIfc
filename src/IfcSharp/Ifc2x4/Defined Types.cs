using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    /// <summary>
    /// 
    /// </summary>
    public struct IfcLabel
    {
        public string value;

        public IfcLabel(string x) { this.value = x; }

        public override string ToString() { return value; }

        public static implicit operator IfcLabel(string x) { return new IfcLabel(x); }

        public static explicit operator string(IfcLabel x) { return x.value; }
    }

    public class TESTCLASS
    {
        static void Main()
        {
            var test1 = (IfcLabel)"test_string";
            Console.WriteLine(test1);

            Console.WriteLine(test1.GetType().ToString());
        }
    }

    /// <summary>
    /// Definition from IAI: A measure of the absorbed radioactivity dose.
    /// Usually measured in Gray (Gy, J/kg).
    /// Type: REAL (double)
    /// </summary>
    public struct IfcAbsorbedDoseMeasure
    {
        public double value;

        public IfcAbsorbedDoseMeasure(double x) { this.value = x; }

        public override string ToString() { return this.value.ToString(); }

        public static implicit operator IfcAbsorbedDoseMeasure(double x) { return new IfcAbsorbedDoseMeasure(x); }

        public static explicit operator double(IfcAbsorbedDoseMeasure x) { return x.value; }
    }

    /// <summary>
    /// Definition from IAI: A measure of acceleration.
    /// Usually measured in m/s2.
    /// Type: REAL (double)
    /// </summary>
    public struct IfcAccelerationMeasure
    {
        public double value;

        public IfcAccelerationMeasure(double x) { this.value = x; }

        public override string ToString() { return this.value.ToString(); }

        public static implicit operator IfcAccelerationMeasure(double x) { return new IfcAccelerationMeasure(x); }

        public static explicit operator double(IfcAccelerationMeasure x) { return x.value; }
    }

    /// <summary>
    /// Definition from ISO/CD 10303-41:1992: An amount of substance measure is the value for 
    /// the quantity of a substance when compared with the number of atoms in 0.012kilogram of carbon 12.
    /// Type: REAL (double)
    /// </summary>
    /// <remarks>
    /// Corresponding STEP name: amount_of_substance_measure, please refer to ISO/IS 10303-41 for the final definition of the formal standard.
    /// </remarks>
    public struct IfcAmountOfSubstanceMeasure
    {
        public double value;

        public IfcAmountOfSubstanceMeasure(double x) { this.value = x; }

        public override string ToString() { return this.value.ToString(); }

        public static implicit operator IfcAmountOfSubstanceMeasure(double x) { return new IfcAmountOfSubstanceMeasure(x); }

        public static explicit operator double(IfcAmountOfSubstanceMeasure x) { return x.value; }
    }

    /// <summary>
    /// Definition from IAI: A measure of the velocity of a body measured in terms of angle subtended per unit time.
    /// Usually measured in radians/s.
    /// Type: REAL (double)
    /// </summary>
    public struct IfcAngularVelocityMeasure
    {
        public double value;

        public IfcAngularVelocityMeasure(double x) { this.value = x; }

        public override string ToString() { return this.value.ToString(); }

        public static implicit operator IfcAngularVelocityMeasure(double x) { return new IfcAngularVelocityMeasure(x); }

        public static explicit operator double(IfcAngularVelocityMeasure x) { return x.value; }
    }

    /// <summary>
    /// Definition from ISO/CD 10303-41:1992: An area measure is the value of the extent of a surface.
    /// Usually measured in square metre (m2).
    /// Type: REAL (double)
    /// </summary>
    /// <remarks>
    /// Corresponding STEP name: area_measure, please refer to ISO/IS 10303-41 for the final definition of the formal standard.
    /// </remarks>
    public struct IfcAreaMeasure
    {
        public double value;

        public IfcAreaMeasure(double x) { this.value = x; }

        public override string ToString() { return this.value.ToString(); }

        public static implicit operator IfcAreaMeasure(double x) { return new IfcAreaMeasure(x); }

        public static explicit operator double(IfcAreaMeasure x) { return x.value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcBoolean
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcBoxAlignment
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcCardinalPointReference
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcComplexNumber
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcCompoundPlaneAngleMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcContextDependentMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcCountMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcCurvatureMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDate
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDateTime
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDayInMonthNumber
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDaylightSavingHour
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDescriptiveMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDimensionCount
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDoseEquivalentMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDuration
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcDynamicViscosityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcElectricCapacitanceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcElectricChargeMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcElectricConductanceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcElectricCurrentMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcElectricResistanceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcElectricVoltageMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcEnergyMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcFontStyle
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcFontVariant
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcFontWeight
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcForceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcFrequencyMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcGloballyUniqueId
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcHeatFluxDensityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcHeatingValueMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcHourInDay
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcIdentifier
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcIlluminanceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcInductanceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcInteger
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcIntegerCountRateMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcIonConcentrationMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcIsothermalMoistureCapacityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcKinematicViscosityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLanguageId
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLengthMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLinearForceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLinearMomentMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLinearStiffnessMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLinearVelocityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLogical
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLuminousFluxMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLuminousIntensityDistributionMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcLuminousIntensityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMagneticFluxDensityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMagneticFluxMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMassDensityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMassFlowRateMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMassMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMassPerLengthMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMinuteInHour
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcModulusOfElasticityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcModulusOfLinearSubgradeReactionMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcModulusOfRotationalSubgradeReactionMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcModulusOfSubgradeReactionMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMoistureDiffusivityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMolecularWeightMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMomentOfInertiaMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMonetaryMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcMonthInYearNumber
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcNonNegativeLengthMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcNormalisedRatioMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcNumericMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPHMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcParameterValue
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPlanarForceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPlaneAngleMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPositiveLengthMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPositivePlaneAngleMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPositiveRatioMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPowerMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPresentableText
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcPressureMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcRadioActivityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcRatioMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcReal
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcRotationalFrequencyMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcRotationalMassMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcRotationalStiffnessMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSecondInMinute
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSectionModulusMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSectionalAreaIntegralMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcShearModulusMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSolidAngleMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSoundPowerMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSoundPressureMeasure
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSpecificHeatCapacityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSpecularExponent
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcSpecularRoughness
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTemperatureGradientMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTemperatureRateOfChangeMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcText
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTextAlignment
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTextDecoration
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTextFontName
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTextTransformation
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcThermalAdmittanceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcThermalConductivityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcThermalExpansionCoefficientMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcThermalResistanceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcThermalTransmittanceMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcThermodynamicTemperatureMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTime
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTimeMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTimeStamp
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcTorqueMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcURIReference
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcVaporPermeabilityMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcVolumeMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcVolumetricFlowRateMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcWarpingConstantMeasure
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public struct IfcWarpingMomentMeasure
    {

    }

    /// <summary>
    /// Definition from ISO/CD 10303-41:1992: The year as defined in Gregorian Calendar.
    /// INTEGER
    /// </summary>
    public struct IfcYearNumber
    {
        public int value;

        public IfcYearNumber(int x) { this.value = x; }

        public override string ToString()
        {
            return this.value;
        }
    }



}