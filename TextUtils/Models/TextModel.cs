using System.ComponentModel.DataAnnotations;

namespace TextUtils.Models
{
    public class TextModel
    {
        [Required]
        [DataType(DataType.MultilineText)]
        public string InputText { get; set; }
        
        public string OutputText { get; set; }
    }
}
