using System;
using Xunit;

namespace GradeBook.Tests
{
  public class TypeTests
  {
    [Fact]
    public void CanSetNameFromReference()
    {
    //Given
    var book1 = GetBook("Book 1");
    //When
    SetName(book1, "Juan's Book");
    //Then
    Assert.Equal("Juan's Book", book1.name);
    }

    private void SetName(Book book, string name)
    {
      book.name = name;
    }

    [Fact]
    public void TestName()
    {
    //Given
    var book1 = GetBook("Book 1");
    //When
    var book2 = book1;
    //Then
    Assert.Same(book1, book2);
    }

    private Book GetBook(string name)
    {
      return new Book(name);
    }
  }
}