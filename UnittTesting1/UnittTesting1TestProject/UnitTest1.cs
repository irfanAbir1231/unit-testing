using UnittTesting1; 
namespace UnittTesting1TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateYearsOfService_ReturnsCorrectValue()
        {
            // Arrange
            var hireDate = new DateTime(2010, 1, 1);
            var employee = new Employee("John Doe", "123 Main St", "555-1234", "johndoe@example.com", hireDate);

            // Act
            var yearsOfService = employee.CalculateYearsOfService();

            // Assert
            Assert.AreEqual(DateTime.Now.Year - hireDate.Year, yearsOfService);
        }
    }
}