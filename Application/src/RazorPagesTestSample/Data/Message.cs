using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

// another small change

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "There's a 100 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
