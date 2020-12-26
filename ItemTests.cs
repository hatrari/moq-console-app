using Moq;
using Xunit;
using MoqConsoleApp.IRepos;
using MoqConsoleApp.Controllers;

namespace MoqConsoleApp  
{   
  public class ItemTests  
  {
    [Fact]
    public void TestMethod()  
    {  
      var mock = new Mock<IGetDataRepository>();  
      mock.Setup(p => p.GetNameById(1)).Returns("name 1");  
      ItemsConroller home = new ItemsConroller(mock.Object);  
      string result = home.GetNameById(1);  
      Assert.Equal("name 1", result);  
    }  
  }  
}  