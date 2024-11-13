using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser{

    [Required]
    public string FirstName {get;set;}
    
    [Required]
    public string LastName {get;set;}
   
    [Required]
    [Phone]
    public string PhoneNumber {get;set;}

    [Required]
    public DateTime DateOfBirth {get;set;}
    
}