using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2;

public class Book
{
    public string Title { get; set; }

    public string Author { get; set; }

    public List<string> Genres { get; set; }

    public DateTime PublicationDate {  get; set; }

    public string Annotation { get; set; }

    public string ISBN { get; set; }

    public List<string> Tags { get; set; }


    public override string ToString() 
    {
        return $"{Title} by {Author}, ISBN: {ISBN}"; 
    }
}

