using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookDB;

namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            AddressRepo repo = new AddressRepo();
            AddressModel address = new AddressModel();
            address.FirstName = "Tom";
            address.LastName = "Hardy";
            address.Address = "3-234";
            address.State = "Karnataka";
            address.ZIP = "200091";
            address.PhoneNumber = "8639092638";
            address.City = "Bangalore";
            address.Email = "nnn@gmail.com";
            var result = repo.AddAddress(address);
            Assert.IsTrue(result);
        }
    }
}