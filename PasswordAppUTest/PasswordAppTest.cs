using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;
using PasswordApplication;

[assembly:InternalsVisibleTo("PasswordApplication")]
namespace PassworkAppUTest
{
    [TestClass]
    public class PasswordAppTests
    {
        //Test CategoryExistedChecker.checkIsCategoryExisted().
        [TestMethod]
        public void Check_IfTheNameExistedInThatCategory()
        {
            string checkCategoryName = "email";
            bool actual;
            bool expect = true;
            
            PasswordApplication.Model.Category category = new PasswordApplication.Model.Category();
            category.CategoryName = checkCategoryName;
            category.UserAccountId = 1;

            CategoryExistedChecker cec = new CategoryExistedChecker();
            actual = cec.checkIsCategoryExisted(category);
            Assert.AreEqual(expect, actual);
        }
    }
}