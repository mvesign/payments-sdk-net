﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.Payments.Client.Model;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CM.Payments.Client.Enums;

//<auto-generated>
//	IMPORTANT NOTE:
//	This code is generated by MessageUnitTestGenerator in this project.
//	Date and time: 06-04-2018 14:52:28
//
//	Changes to this file may cause incorrect behavior and will be lost on the next code generation.
//</auto-generated>
namespace CM.Payments.Client.Test
{
	[TestClass, ExcludeFromCodeCoverage]
	public partial class PaymentMethodTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void PaymentMethod_Has_StringEnumConverter()
		{
			var paymentMethod = typeof(PaymentMethod);
			var jsonConverter = paymentMethod.GetCustomAttributes(false).FirstOrDefault(a => a is JsonConverterAttribute) as JsonConverterAttribute;
			Assert.IsNotNull(jsonConverter);
			Assert.IsNotNull(jsonConverter.ConverterType);
			Assert.AreEqual(typeof(StringEnumConverter), jsonConverter.ConverterType);
		}

		[TestMethod]
		public void PaymentMethod_iDEAL()
		{
			var obj = PaymentMethod.iDEAL;
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj, deserialized);
		}

		[TestMethod]
		public void PaymentMethod_PayPal()
		{
			var obj = PaymentMethod.PayPal;
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj, deserialized);
		}

		[TestMethod]
		public void PaymentMethod_AfterPay()
		{
			var obj = PaymentMethod.AfterPay;
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj, deserialized);
		}

		[TestMethod]
		public void PaymentMethod_Creditcard()
		{
			var obj = PaymentMethod.Creditcard;
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj, deserialized);
		}

		[TestMethod]
		public void PaymentMethod_Bancontact()
		{
			var obj = PaymentMethod.Bancontact;
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj, deserialized);
		}

		[TestMethod]
		public void PaymentMethod_WireTransfer()
		{
			var obj = PaymentMethod.WireTransfer;
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj, deserialized);
		}

		[TestMethod]
		public void PaymentMethod_SOFORT()
		{
			var obj = PaymentMethod.SOFORT;
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj, deserialized);
		}

		[TestMethod]
		public void PaymentMethod_DirectDebit()
		{
			var obj = PaymentMethod.DirectDebit;
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj, deserialized);
		}
	}
}
