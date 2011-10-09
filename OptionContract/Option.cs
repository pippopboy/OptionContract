using System.ServiceModel;

namespace OptionContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Option : IOption
    {
        public Author Getauthors()
        {
            Author au = new Author();
            au.ProjectName = "Chat Application";
            au.GroupName = "Cao Tran Trong Nghia";
            return au;
        }
    }  
}
