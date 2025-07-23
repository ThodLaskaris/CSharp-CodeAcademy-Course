
class Employees
{
  public int[] EmployeeID = { 111, 222, 333 };
  public string[] EmployeeTitle = { "Project Manager", "Software Developer", "QA Engineer" };

  public List<int> IDList()
  {
    List<int> newList = new List<int>(EmployeeID); // Create a new list from the EmployeeID array
    return newList;
  }
  public List<string> TitleList()
  {
    List<string> newList = new List<string>(EmployeeTitle); // Create a new list from the EmployeeTitle array
    return newList;
  }
}
