using AugmentoLabs;

namespace AugmentoLabsTest
{
    public class LengthHelperTest
    {
        private readonly LengthHelper _lengthHelper;

        /// <summary>
        /// Constructor of LengthHelperTest
        /// </summary>
        public LengthHelperTest()
        {
            _lengthHelper = new LengthHelper();
        }

        /// <summary>
        /// Find length of empty string
        /// </summary>
        [Fact]
        public void FindLength_EmptyString()
        {
            //Arrange
            string str = "";

            //Act
            int length = _lengthHelper.FindLength(str);

            //Assert
            Assert.True(length == 0);
        }

        /// <summary>
        /// Find length of string with length three
        /// </summary>
        [Fact]
        public void FindLength_Three()
        {
            //Arrange
            string str = "123";

            //Act
            int length = _lengthHelper.FindLength(str);

            //Assert
            Assert.True(length == 3);
        }

        /// <summary>
        /// Find length of string with length twelve
        /// </summary>
        [Fact]
        public void FindLength_Twelve()
        {
            //Arrange
            string str = "123456789010";

            //Act
            int length = _lengthHelper.FindLength(str);

            //Assert
            Assert.True(length == 12);
        }

        /// <summary>
        /// Find length of string with null
        /// </summary>
        [Fact]
        public void FindLength_Null()
        {
            //Arrange
            string? str = null;

            //Act
            int length = _lengthHelper.FindLength(str);

            //Assert
            Assert.True(length == 0);
        }
    }
}