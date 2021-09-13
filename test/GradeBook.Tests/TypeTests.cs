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
    var book2 = GetBook("Book 2");
    //When
    
    //Then
    Assert.Equal("Book 1", book1.Name);
    Assert.Equal("Book 2", book2.Name);
    Assert.NotSame(book1, book2);
    }

    private void SetName(Book book, string name)
    {
      book.Name = name;
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