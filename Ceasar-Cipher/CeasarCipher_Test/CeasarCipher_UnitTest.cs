using Microsoft.VisualStudio.TestTools.UnitTesting;
using CeasarCipherNS;
using System;

namespace CeasarCipher_Test
{
    
    [TestClass]
    public class CeasarCipher_UnitTest
    {
        
        [TestMethod]
        public void PlainTextNoSpace()
        {
            // Arrange
            String plainText = "SimpleTextNoSpaces";
            String cipherText = "";
            String decipheredText = "";
            int key =4; 

            // Act
            cipherText = CeasarCipher.Encipher(plainText,key);
            decipheredText = CeasarCipher.Decipher(cipherText, key);


            // Assert
          
            Assert.AreEqual(plainText, decipheredText, "Not correct");
            //Assert.AreNotEqual(plainText, cipherText, "Not correct");
        }

        [TestMethod]
        public void PlainTextNoSpaceBigKey()
        {
            // Arrange
            String plainText = "SimpleTextNoSpaces";
            String cipherText = "";
            String decipheredText = "";
            int key = 1000;

            // Act
            cipherText = CeasarCipher.Encipher(plainText, key);
            decipheredText = CeasarCipher.Decipher(cipherText, key);


            // Assert

            Assert.AreEqual(plainText, decipheredText, "Not correct");
            Assert.AreNotEqual(plainText, cipherText, "Not correct");
        }        

        [TestMethod]
        public void NumbersNoSpace()
        {
            // Arrange
            String plainText = "555478933115";
            String cipherText = "";
            String decipheredText = "";
            int key = 4;

            // Act
            cipherText = CeasarCipher.Encipher(plainText, key);
            decipheredText = CeasarCipher.Decipher(cipherText, key);


            // Assert
            Assert.AreEqual(plainText, decipheredText, "Not correct");
            Assert.AreNotEqual(plainText, cipherText, "Not correct");
        }

        [TestMethod]
        public void NumbersNoSpaceBigKey()
        {
            // Arrange
            String plainText = "555478933115";
            String cipherText = "";
            String decipheredText = "";
            int key = 1005;

            // Act
            cipherText = CeasarCipher.Encipher(plainText, key);
            decipheredText = CeasarCipher.Decipher(cipherText, key);


            // Assert
            Assert.AreEqual(plainText, decipheredText, "Not correct");
            Assert.AreNotEqual(plainText, cipherText, "Not correct");
        }        

        [TestMethod]
        public void TextAndNumbersNoSpace()
        {
            // Arrange
            String plainText = "Sim5050pletext4no5spa1000ces";
            String cipherText = "";
            String decipheredText = "";
            int key = 4;

            // Act
            cipherText = CeasarCipher.Encipher(plainText, key);
            decipheredText = CeasarCipher.Decipher(cipherText, key);


            // Assert
            Assert.AreEqual(plainText, decipheredText, "Not correct");
            Assert.AreNotEqual(plainText, cipherText, "Not correct");
        }

        [TestMethod]
        public void TextAndNumbersWithSpace()
        {
            // Arrange
            String plainText = "Simple 5050 tex4t  tas5Be10 00With spaces        ";
            String cipherText = "";
            String decipheredText = "";
            int key = 4;

            // Act
            cipherText = CeasarCipher.Encipher(plainText, key);
            decipheredText = CeasarCipher.Decipher(cipherText, key);


            // Assert
            Assert.AreEqual(plainText, decipheredText, "Not correct");
            Assert.AreNotEqual(plainText, cipherText, "Not correct");
        }

        [TestMethod]
        public void TextAndNumbersWithSpaceAndMore()
        {
            // Arrange
            String plainText = "Simple text ///5050 ===++++++=== sss /"+"Text ***--***tas5Be10 00 with spaces'' !@#$%^&*()_+       ";
            String cipherText = "";
            String decipheredText = "";
            int key = 4;

            // Act
            cipherText = CeasarCipher.Encipher(plainText, key);
            decipheredText = CeasarCipher.Decipher(cipherText, key);


            // Assert
            Assert.AreEqual(plainText, decipheredText, "Not correct");
            Assert.AreNotEqual(plainText, cipherText, "Not correct");
        }

        [TestMethod]
        public void TextAndNumbersWithSpaceAndMoreBigKey()
        {
            // Arrange
            String plainText = "Simple text ///5050 ===++++++=== sss /" + "Text ***--***tas5Be10 00 with spaces'' !@#$%^&*()_+       ";
            String cipherText = "";
            String decipheredText = "";
            int key = 1000;

            // Act
            cipherText = CeasarCipher.Encipher(plainText, key);
            decipheredText = CeasarCipher.Decipher(cipherText, key);


            // Assert
            Assert.AreEqual(plainText, decipheredText, "Not correct");
            Assert.AreNotEqual(plainText, cipherText, "Not correct");
        }     

        
    }
}
