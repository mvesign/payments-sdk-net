﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.Payments.Client.Model;
using System.Reflection;
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
	public partial class CreditcardDetailsRequestTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void CreditcardDetailsRequest()
		{
			var obj = new CreditcardDetailsRequest
			{
				CallbackUrl = "Lorum_750",
				CancelledUrl = "Lorum_487",
				ExpiredUrl = "Lorum_922",
				FailedUrl = "Lorum_995",
				Issuers = new []
				{
					"Lorum_857",
					"Lorum_669"
				},
				PurchaseId = "Lorum_454",
				Recurring = false,
				SuccessUrl = "Lorum_505"
			};
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj.CallbackUrl, deserialized.CallbackUrl);
			Assert.AreEqual(obj.CancelledUrl, deserialized.CancelledUrl);
			Assert.AreEqual(obj.ExpiredUrl, deserialized.ExpiredUrl);
			Assert.AreEqual(obj.FailedUrl, deserialized.FailedUrl);
			Assert.AreEqual(obj.Issuers.IsFixedSize, deserialized.Issuers.IsFixedSize);
			Assert.AreEqual(obj.Issuers.IsReadOnly, deserialized.Issuers.IsReadOnly);
			Assert.AreEqual(obj.Issuers.IsSynchronized, deserialized.Issuers.IsSynchronized);
			Assert.AreEqual(obj.Issuers.Length, deserialized.Issuers.Length);
			Assert.AreEqual(obj.Issuers.LongLength, deserialized.Issuers.LongLength);
			Assert.AreEqual(obj.Issuers.Rank, deserialized.Issuers.Rank);
			Assert.AreEqual(obj.PurchaseId, deserialized.PurchaseId);
			Assert.AreEqual(obj.Recurring, deserialized.Recurring);
			Assert.AreEqual(obj.SuccessUrl, deserialized.SuccessUrl);
		}
	}
}
