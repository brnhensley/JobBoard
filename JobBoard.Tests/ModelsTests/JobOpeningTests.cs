using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Tests
{
  [TestClass]
  public class JobOpeningTest// : IDisposable
  {

    // public void Dispose()
    // {
    //   JobOpening.ClearAll();
    // }

    [TestMethod]
    public void JobOpeningConstructor_CreatesInstanceOfItem_Item()
    {
      JobOpening newJobOpening = new JobOpening("test1", "test2", "test3", "test4", "test5");
      Assert.AreEqual(typeof(JobOpening), newJobOpening.GetType());
    }

    // [TestMethod]
    // public void GetTitle_ReturnsTitle_True()
    // {
    //   JobOpening newJobOpening = new JobOpening("test1", "test2", "test3", "test4", "test5");
    //   string newTitle = newJobOpening.GetTitle();
    //   Assert.AreEqual("test1", newTitle);
    // }
    //
    // [TestMethod]
    // public void GetDescription_ReturnsDescription_True()
    // {
    //   JobOpening newJobOpening = new JobOpening("test1", "test2", "test3", "test4", "test5");
    //   string newDescription = newJobOpening.GetDescription();
    //   Assert.AreEqual("test2", newDescription);
    // }
    //
    // [TestMethod]
    // public void GetName_ReturnsName_True()
    // {
    //   JobOpening newJobOpening = new JobOpening("test1", "test2", "test3", "test4", "test5");
    //   string newName = newJobOpening.GetName();
    //   Assert.AreEqual("test3", newName);
    // }
    //
    // [TestMethod]
    // public void GetAddress_ReturnsAddress_True()
    // {
    //   JobOpening newJobOpening = new JobOpening("test1", "test2", "test3", "test4", "test5");
    //   string newAddress = newJobOpening.GetAddress();
    //   Assert.AreEqual("test4", newAddress);
    // }
    //
    // [TestMethod]
    // public void GetPhone_ReturnsPhone_True()
    // {
    //   JobOpening newJobOpening = new JobOpening("test1", "test2", "test3", "test4", "test5");
    //   string newPhone = newJobOpening.GetPhone();
    //   Assert.AreEqual("test5", newPhone);
    // }

  }
}
