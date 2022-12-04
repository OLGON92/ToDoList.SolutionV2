using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
    //Arrange
    string description = "Walk the dog.";
    Item newItem = new Item(description);

    //Act
    int result = newItem.Id;

    //Assert
    Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      //Arrange-This test arranges multiple sample Item objects.
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);

      //Act-It then calls a static Find() method, passing in the int 2 as an argument because this is the anticipated Id property of the second Item
      Item result = Item.Find(2);

      //Assert-We then assert that Find() will return newItem2 when provided the argument 2
      Assert.AreEqual(newItem2, result);
    }
  }
}