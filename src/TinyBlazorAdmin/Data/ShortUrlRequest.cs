using System.ComponentModel.DataAnnotations;

namespace TinyBlazorAdmin.Data
{
    public class ShortUrlRequest
    {
        private string _vanity;

        public string Title { get; set; }

        public string Vanity
        {
            get
            {
                return (_vanity != null) ? _vanity : string.Empty;
            }
            set
            {
                _vanity = value;
            }
        }

        [Required]
        public string Url { get; set; }

        public Schedule[] Schedules { get; set; }
    }
}