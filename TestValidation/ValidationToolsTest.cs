using Validation.Validate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestValidation
{
    
    
    /// <summary>
    ///ValidationToolsTest のテスト クラスです。すべての
    ///ValidationToolsTest 単体テストをここに含めます
    ///</summary>
    [TestClass()]
    public class ValidationToolsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///現在のテストの実行についての情報および機能を
        ///提供するテスト コンテキストを取得または設定します。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 追加のテスト属性
        // 
        //テストを作成するときに、次の追加属性を使用することができます:
        //
        //クラスの最初のテストを実行する前にコードを実行するには、ClassInitialize を使用
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //クラスのすべてのテストを実行した後にコードを実行するには、ClassCleanup を使用
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //各テストを実行する前にコードを実行するには、TestInitialize を使用
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //各テストを実行した後にコードを実行するには、TestCleanup を使用
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///DigitsCheck のテスト
        ///</summary>
        [TestMethod()]
        public void DigitsCheckTest_False()
        {
            string s = "12345678901";
            int digit = 10;
            bool expected = false;
            bool actual;
            actual = ValidationTools.DigitsCheck(s, digit);
            Assert.AreEqual(expected, actual);           
        }

        /// <summary>
        ///DigitsCheck のテスト
        ///</summary>
        [TestMethod()]
        public void DigitsCheckTest_True()
        {
            string s = "1234567890";
            int digit = 10;
            bool expected = true;
            bool actual;
            actual = ValidationTools.DigitsCheck(s, digit);
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///NullCheck のテスト
        ///</summary>
        [TestMethod()]
        public void NullCheckTest_False()
        {
            string s = null;
            bool expected = false;
            bool actual;
            actual = ValidationTools.NullCheck(s);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///NullCheck のテスト
        ///</summary>
        [TestMethod()]
        public void NullCheckTest_True()
        {
            string s = string.Empty;
            bool expected = true;
            bool actual;
            actual = ValidationTools.NullCheck(s);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///NumberCheck のテスト
        ///</summary>
        [TestMethod()]
        public void NumberCheckTest_False()
        {
            string s = "abc";
            bool expected = false;
            bool actual;
            actual = ValidationTools.NumberCheck(s);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///NumberCheck のテスト
        ///</summary>
        [TestMethod()]
        public void NumberCheckTest_True()
        {
            string s = "123";
            bool expected = true;
            bool actual;
            actual = ValidationTools.NumberCheck(s);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///RequiredCheck のテスト
        ///</summary>
        [TestMethod()]
        public void RequiredCheckTest_False()
        {
            string s = string.Empty;
            bool expected = false;
            bool actual;
            actual = ValidationTools.RequiredCheck(s);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///RequiredCheck のテスト
        ///</summary>
        [TestMethod()]
        public void RequiredCheckTest_True()
        {
            string s = "test";
            bool expected = true;
            bool actual;
            actual = ValidationTools.RequiredCheck(s);
            Assert.AreEqual(expected, actual);
        }

    }
}
