using NUnit.Framework;

namespace Omega.test
{
    [TestFixture]
    public class Tests
    {
        //one_nonDigit_Word
        [Test]
        public void one_nonDigit_TestValidWord()
        {
            // Arrange
            string word = "hello";

            // Act
            bool result = RegexValidator.one_nonDigit_Word(word);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void one_nonDigit_TestInvalidWordWithDigits()
        {
            // Arrange
            string word = "hello123";

            // Act
            bool result = RegexValidator.one_nonDigit_Word(word);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void one_nonDigit_TestInvalidWordWithSpecialCharacters()
        {
            // Arrange
            string word = "hello!";

            // Act
            bool result = RegexValidator.one_nonDigit_Word(word);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void one_nonDigit_TestEmptyString()
        {
            // Arrange
            string word = "";

            // Act
            bool result = RegexValidator.one_nonDigit_Word(word);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void one_nonDigit_Word_TestNullString()
        {
            // Arrange
            string word = null;

            // Act
            bool result = RegexValidator.one_nonDigit_Word(word);

            // Assert
            Assert.IsFalse(result);
        }

        //one_digit_Word

        [Test]
        public void one_digit_Word_TestValidWord()
        { 
            // Arrange
            string word = "hello123";

            // Act
            bool result = RegexValidator.one_digit_Word(word);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void one_digit_Word_TestInvalidWordWithoutDigits()
        {
            // Arrange
            string word = "hello";

            // Act
            bool result = RegexValidator.one_digit_Word(word);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void one_digit_Word_TestInvalidWordWithSpecialCharacters()
        {
            // Arrange
            string word = "hello!";

            // Act
            bool result = RegexValidator.one_digit_Word(word);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void one_digit_Word_TestEmptyString()
        {
            // Arrange
            string word = "";

            // Act
            bool result = RegexValidator.one_digit_Word(word);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void one_digit_Word_TestNullString()
        {
            // Arrange
            string word = null;

            // Act
            bool result = RegexValidator.one_digit_Word(word);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
