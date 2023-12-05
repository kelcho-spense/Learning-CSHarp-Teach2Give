using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingExamples;

namespace TestingExamplesTest
{
    [TestClass]
    public class MyMathTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Testing Procedure : Arrange, Act, Assert
            // Arrange
            MyMath math = new MyMath();
            // Act
            int result = math.Add(1, 2);
            // Assert
            Assert.AreEqual(3, math.Add(1, 2));
            
        }
    }
}
