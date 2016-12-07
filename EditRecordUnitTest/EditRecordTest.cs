using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordApplication;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PasswordApplication")]
namespace EditRecordUnitTest
{
    [TestClass]
    public class EditRecordTest
    {
        [TestMethod]
        public void ValidateEditRecordInputTest()
        {
            //arrange
            EditRecordForm erf = new EditRecordForm();
            bool isValidated = true;
            bool result;
            erf.UserNameTextBox.Text = "Test";
            erf.PasswordTextBox.Text = "Password";
            erf.VerifyPasswordTextBox.Text = "Password";
            erf.ServiceNameTextBox.Text = "Password";
            erf.NoteTextBox.Text = "Note";
            erf.CategoryOptionComboBox.SelectedText = "Bank";
            //act
            if (erf.ValidatingEditRecord(true, true) == true)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            //assert
            Assert.AreEqual(isValidated, result);
        }
    }
}
