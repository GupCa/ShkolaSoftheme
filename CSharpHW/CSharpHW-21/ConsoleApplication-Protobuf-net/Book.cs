using System;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;

namespace ConsoleApplication_ValidateLibrary
{
    [Serializable]
    [ProtoContract]
    public class Book
    {
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }
        
        [ProtoMember(1)]
        public string Name { get; set; }
        
        [ProtoMember(2)]
        public string Author { get; set; }
    }
}