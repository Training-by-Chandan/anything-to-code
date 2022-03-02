using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You should enter the first name")]
        [StringLength(20, ErrorMessage = "You should not enter the length more than 20 charaters")]
        [MinLength(3)]
        [Display(Name = "Enter Your First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        [MinLength(3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public int ClassId { get; set; }

        public string ClassNames { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public string ProfilePicture { get; set; }
        public string Pic
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.ProfilePicture)) return "/Themes/Admin/dist/img/avatar.png";

                return this.ProfilePicture;
            }
        }
    }
}