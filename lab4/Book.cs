using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }
    }

    public class Magazine : Book
    {
        private int _issuenumber;
        public int IssueNumber 
        {
            get => _issuenumber;
            set
            {
                if (_issuenumber < 0)
                {
                    throw new ArgumentException("Issue Number must not be negative.");
                }
                else _issuenumber = value;
            }
        }

        public override string GetInfo()
        {
            return $"{Title} by {Author} - Issue {IssueNumber}";
        }
    }
    public class Ebook : Book
    {
        public double FilesizeMB { get; set; }
        public override string GetInfo()
        {
            return $"{Title} by {Author} - Size: {FilesizeMB}";
        }
    }

    public class AudioBook : Book
    {
        public string Narrator { get; set; }
        public TimeSpan Duration { get; set; }
        public override string GetInfo()
        {
            return $"{Title} by {Narrator} - {Duration}";
        }
    }

    public class TextBook : Book
    {
        public string Subject { get; set; }
        public override string GetInfo()
        {
            return $"{Title} by {Author} - Subject: {Subject}";
        }
    }
}