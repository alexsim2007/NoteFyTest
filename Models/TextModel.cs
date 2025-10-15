using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace NoteFyTest.Models
{
    public class TextModel
    {
        public static string content { get; set; }

        public string fileName { get; set; } = "saved_text.txt";
    }
}