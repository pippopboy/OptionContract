using System.Runtime.Serialization;
using System.ServiceModel;

namespace OptionContract
{
    
    [ServiceContract]
    public interface IOption
    {
        [OperationContract]
        Author Getauthors();
    }

    [DataContract] 
    public class Author
    {
        [DataMember] 
        public string ProjectName;

        [DataMember] 
        public string GroupName;
    } 
}
