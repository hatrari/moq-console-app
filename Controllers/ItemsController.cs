using Microsoft.AspNetCore.Mvc;  
using moq_console_app.IRepos;

namespace moq_console_app.Controllers  
{  
  public class ItemsConroller : Controller  
  {  
    private readonly IGetDataRepository _data;  

    public ItemsConroller(IGetDataRepository data)  
    {  
      _data = data;  
    }  
    
    public string GetNameById(int id)  
    {  
      return _data.GetNameById(id);  
    }  
  }  
} 