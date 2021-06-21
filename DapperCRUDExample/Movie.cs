using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUDExample
{
    public class Movie
    {
        public int Id { get; set; }
        public int DirectorId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public float Rating { get; set; }
        public float MovieLength { get; set; }
    }
}
