﻿
namespace SD101.Examples.DataTypes
{
    using System;
    using UnityEngine;

    public class DataTypeSample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            ValueTypeSample valueTypeSample = new ValueTypeSample();

            var sampleStruct = new SampleStruct();
            //var sampleClassA = new SampleClass();
            //var sampleClassB = new SampleClass();

            //sampleClassA.sampleInt = 1001;
            //sampleClassB = sampleClassA;

            //sampleClassB.sampleInt = 1002;

            //Debug.Log(sampleClassA.sampleInt);
        }
    }

    public class ValueTypeSample
    {
        byte sampleByte;
        short sampleShort;
        ushort sampleUnsignedShort;
        int sampleInt;
        uint sampleUnsignedInt;
        long sampleLong;
        ulong sampleUnsignedLong;

        float sampleFloat;
        decimal sampleDecimal;
        double sampleDouble;

        bool sampleBool;

        public ValueTypeSample()
        {
            AnalyzeByte();
            AnalyzeShort();
            AnalyzeUnsignedShort();
            AnalyzeInteger();
            AnalyzeUnsignedInteger();
            AnalyzeLong();
            AnalyzeUnsignedLong();

            AnalyzeFloat();
            AnalyzeDecimal();
            AnalyzeDouble();

            AnalyzeBool();

            AnalyzeIncrementionOfAValueType();

        }

        private void AnalyzeByte()
        {
            Debug.Log("default value of byte = " + sampleByte);
            Debug.Log("size of byte = " + sizeof(byte));
            Debug.Log("max value of byte = " + byte.MaxValue);
            Debug.Log("min value of byte = " + byte.MinValue);
            Debug.Log("Type of byte = " + sampleByte.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeShort()
        {
            Debug.Log("default value of short = " + sampleShort);
            Debug.Log("size of short = " + sizeof(short));
            Debug.Log("max value of short = " + short.MaxValue);
            Debug.Log("min value of short = " + short.MinValue);
            Debug.Log("Type of short = " + sampleShort.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeUnsignedShort()
        {
            Debug.Log("default value of unsigned short = " + sampleUnsignedShort);
            Debug.Log("size of unsigned short = " + sizeof(ushort));
            Debug.Log("max value of unsigned short = " + ushort.MaxValue);
            Debug.Log("min value of unsigned short = " + ushort.MinValue);
            Debug.Log("Type of unsigned short = " + sampleUnsignedShort.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeInteger()
        {
            //int unassignedLocalInteger;
            Debug.Log("default value of integer = " + sampleInt);
            Debug.Log("size of integer = " + sizeof(int));
            Debug.Log("max value of integer = " + int.MaxValue);
            Debug.Log("min value of integer = " + int.MinValue);
            Debug.Log("Type of integer = " + sampleInt.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeUnsignedInteger()
        {
            Debug.Log("default value of unsigned integer = " + sampleUnsignedInt);
            Debug.Log("size of unsigned integer = " + sizeof(uint));
            Debug.Log("max value of unsigned integer = " + uint.MaxValue);
            Debug.Log("min value of unsigned integer = " + uint.MinValue);
            Debug.Log("Type of unsigned integer = " + sampleUnsignedInt.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeLong()
        {
            Debug.Log("default value of long = " + sampleLong);
            Debug.Log("size of long = " + sizeof(long));
            Debug.Log("max value of long = " + long.MaxValue);
            Debug.Log("min value of long = " + long.MinValue);
            Debug.Log("Type of long = " + sampleLong.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeUnsignedLong()
        {
            Debug.Log("default value of unsigned long = " + sampleUnsignedLong);
            Debug.Log("size of unsigned long = " + sizeof(ulong));
            Debug.Log("max value of unsigned long = " + ulong.MaxValue);
            Debug.Log("min value of unsigned long = " + ulong.MinValue);
            Debug.Log("Type of unsigned long = " + sampleUnsignedLong.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeFloat()
        {
            Debug.Log("default value of float = " + sampleFloat);
            Debug.Log("size of float = " + sizeof(float));
            Debug.Log("max value of float = " + float.MaxValue);
            Debug.Log("min value of float = " + float.MinValue);
            Debug.Log("Type of float = " + sampleFloat.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeDecimal()
        {
            Debug.Log("default value of decimal = " + sampleDecimal);
            Debug.Log("size of decimal = " + sizeof(decimal));
            Debug.Log("max value of decimal = " + decimal.MaxValue);
            Debug.Log("min value of decimal = " + decimal.MinValue);
            Debug.Log("Type of decimal = " + sampleDecimal.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeDouble()
        {
            Debug.Log("default value of double = " + sampleDouble);
            Debug.Log("size of double = " + sizeof(double));
            Debug.Log("max value of double = " + double.MaxValue);
            Debug.Log("min value of double = " + double.MinValue);
            Debug.Log("Type of double = " + sampleDouble.GetType());

            AddSeperatorLog();
        }

        private void AnalyzeBool()
        {
            Debug.Log("default value of bool = " + sampleBool);
            Debug.Log("size of bool = " + sizeof(bool));
            Debug.Log("Type of double = " + sampleBool.GetType());

            AddSeperatorLog();
        }

        private void AddSeperatorLog()
        {
            Debug.Log(Environment.NewLine);
            Debug.Log("<color=green>******************</color>");
            Debug.Log(Environment.NewLine);
        }

        private void AnalyzeIncrementionOfAValueType()
        {
            int a = 10;
            IncreaseInt(a);
            //IncreaseInt(ref a);//todo open
            Debug.Log("a = " + a);
        }

        private void IncreaseInt(int a)
        {
            Debug.Log("IncreaseInt(int a) called");
            a++;
        }

        private void IncreaseInt(ref int a)
        {
            Debug.Log("IncreaseInt(ref int a) called");
            a++;
        }
    }

    public struct SampleStruct
    {
        public int sampleInt;
        public float sampleFloat;
        public string sampleString;
    }

    public class SampleClass
    {
        public int sampleInt;
        public int sampleFloat;
        public int sampleString;
    }
}
