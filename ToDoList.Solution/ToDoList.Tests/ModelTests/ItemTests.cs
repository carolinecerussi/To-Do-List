using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;
using System.Collections.Generic;

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
      Item newItem = new Item("test"); //we pass in "test" as an argument here//
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string updatedDescription = "Do the dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item>{};
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItems_Items_ItemList()
    {
      //arrange
      string description01 = "Walk the Dog";
      string description02 = "Wash the Dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> {newItem1, newItem2};
      //act
      List<Item> result = Item.GetAll();
      //assert
      CollectionAssert.AreEqual(newList,result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange//
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      //Act//
      string result = newItem.Description;
      //Assert//
      Assert.AreEqual(description,result);
    }

  }
}