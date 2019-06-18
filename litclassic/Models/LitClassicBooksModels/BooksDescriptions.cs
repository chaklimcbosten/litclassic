using System;
using System.Collections.Generic;

namespace litclassic.LitClassicBooksModels
{
    public partial class BooksDescriptions
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string PreReform { get; set; }
        public string Genre { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BookTitle { get; set; }
        public string Annotation { get; set; }
        public string Date { get; set; }
        public string Coverpage { get; set; }
        public string Lang { get; set; }
        public string SrcLang { get; set; }
        public string TranslatorFirstName { get; set; }
        public string TranslatorMiddleName { get; set; }
        public string TranslatorLastName { get; set; }
        public string TranslatorNickname { get; set; }
        public string TranslatorHomePage { get; set; }
        public string TranslatorEmail { get; set; }
        public string Sequence { get; set; }
        public string DocAuthorFirstName { get; set; }
        public string DocAuthorMiddleName { get; set; }
        public string DocAuthorLastName { get; set; }
        public string DocAuthorNickname { get; set; }
        public string DocAuthorHomePage { get; set; }
        public string DocAuthorEmail { get; set; }
        public string ProgramUsed { get; set; }
        public string DocDate { get; set; }
        public string SrcUrl { get; set; }
        public string SrcOcr { get; set; }
        public string DocId { get; set; }
        public string Version { get; set; }
        public string History { get; set; }
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public string City { get; set; }
        public string Year { get; set; }
        public string Binary { get; set; }
        public string FictionBook { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public virtual Books Book { get; set; }
    }
}
