using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse // POCO - Plain Old C# Object
    {
        // F i e l d s   &&   P r o p e r t i e s
        [Required(ErrorMessage = "Name is Required")]
        public string Name      { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email     { get; set; }

        [Required(ErrorMessage = "Phone is Required")]
        [Phone]
        public string Phone     { get; set; }

        [Required(ErrorMessage = "Are You Going To Attend?")]
        public bool?  WillAttend { get; set; }  // true, false,(?) makes null


        // C o n s t r u c t o r s




        // M e t h o d s


    }
}
