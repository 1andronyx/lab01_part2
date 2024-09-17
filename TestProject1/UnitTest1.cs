using Lab1;


namespace RectangleApp.Tests
{
    [TestFixture]   
    public class RectangleTests
    {

        [Test]
        public void CalculatePerimeter_ReturnsCorrectPerimeter()
        {
            
            double SIDE_a = 16;
            double SIDE_b = 1;
            Rectangle rectangle = new Rectangle(SIDE_a, SIDE_b);

         
            double perimeter = rectangle.Perimeter;

           
            Assert.That(perimeter, Is.EqualTo(34), "Периметр рассчитан неправильно");
        }

        [Test]
        public void Area_WithNegativeSides_ThrowsException()
        {
            
            double SIDE_a = -6;
            double SIDE_b = 3;

            
            Assert.Throws<ArgumentException>(() => new Rectangle(SIDE_a, SIDE_b), "Длины сторон не могут быть отрицательными");
        }

        [Test]
        public void Perimeter_WithZeroSides_ThrowsException()
        {
            // Arrange
            double SIDE_a = 0;
            double SIDE_b = 3;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Rectangle(SIDE_a, SIDE_b), "Длины сторон не могут быть равны нулю");
        }
    }
}
