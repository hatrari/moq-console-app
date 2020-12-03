using moq_console_app.IRepos;

namespace moq_console_app.Repos  
{  
  public class ItemRepository : IGetDataRepository  
  {  
    public string GetNameById(int id)  
    {  
      string name;  
      if (id == 1)  
      {  
          name = "Item 1";  
      }  
      else if (id == 2)  
      {  
          name = "Item 2";  
      }  
      else  
      {  
          name = "Not Found";  
      }  
      return name;  
    }  
  }  
}  