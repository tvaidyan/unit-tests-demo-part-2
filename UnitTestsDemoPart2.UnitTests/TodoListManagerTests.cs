using Xunit;

namespace UnitTestsDemoPart2.UnitTests
{
    public class TodoListManagerTests
    {
        [Fact]
        public void AddTodo_WhenCalledWithATodoItem_AddsItemToList()
        {
            // Arrange
            var sut = new TodoListManager();

            // Act
            sut.AddTodo("Get milk");

            // Assert
            var result = Assert.Single(sut.TodoList);
            Assert.Equal("Get milk", result);
        }
    }
}
