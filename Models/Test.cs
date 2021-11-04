using System;

namespace DotNetCoreSqlDb.Models
{
    public class Test
    {
        public string TestId { get; set; }
        
        public string Desc { get; set; }

        public bool ShowTestId => !string.IsNullOrEmpty(TestId);
    }
}