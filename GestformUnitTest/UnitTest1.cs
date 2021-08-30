using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestGestForm.Services;

namespace GestformUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("CreateListTest")]
        public void List_should_not_be_under_2_and_not_exceed_2000()
        {
            RandNumberService randNumberService = new RandNumberService();
            List<short> resultList = randNumberService.CreateList();

            if (resultList.Count <= 2 && resultList.Count > 2000)
                Assert.Fail();
        }

        [TestMethod]
        [TestCategory("CreateListTest")]
        public void List_should_not_be_under_negative_1000_and_not_exceed_1000()
        {
            RandNumberService randNumberService = new RandNumberService();
            List<short> resultList = randNumberService.CreateList();
            foreach (short result in resultList)
            {
                if (result < -1000)
                    Assert.Fail();
                if (result > 1000)
                    Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("CheckShortTest")]
        public void Multiple_of_3_and_5_should_return_gestfrom()
        {
            RandNumberService randNumberService = new RandNumberService();
            short numberMultipleOf3And5 = 900;
            string resultExpected = "Gestform";
            string result = randNumberService.CheckShort(numberMultipleOf3And5);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        [TestCategory("CheckShortTest")]
        public void Multiple_of_3_should_return_gest()
        {
            RandNumberService randNumberService = new RandNumberService();
            short numberMultipleOf3 = 456;
            string resultExpected = "Gest";
            string result = randNumberService.CheckShort(numberMultipleOf3);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        [TestCategory("CheckShortTest")]
        public void Multiple_of_5_should_return_form()
        {
            RandNumberService randNumberService = new RandNumberService();
            short numberMultipleOf3 = 800;
            string resultExpected = "Form";
            string result = randNumberService.CheckShort(numberMultipleOf3);
            Assert.AreEqual(resultExpected, result);
        }
    }
}
