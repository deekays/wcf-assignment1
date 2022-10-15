using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string isPrime(int num);
        [OperationContract]
        int sumDigits(int num);
        [OperationContract]
        string reverseString(string str);
        [OperationContract]
        string htmlOut(string tag, string data);
        [OperationContract]
        string sortNums(string sort, string nums);
    }

}
