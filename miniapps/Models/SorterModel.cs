using System.ComponentModel;

namespace miniapps.Models
{
    public class SorterModel
    {
        [DisplayName("Text")]
        public string textInput { get; set; }
        [DisplayName("Output")]
        public string textOutput { get; set; }
    }
}
