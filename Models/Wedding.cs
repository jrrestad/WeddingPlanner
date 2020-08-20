using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wedding_Planner_Two.Models
{    
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}
        [Required(ErrorMessage="First Wedder can not be empty")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Only alphabetical characters are allowed")]
        [MinLength(2, ErrorMessage="Wedder name is too short")]

        public string WedderOne {get;set;}
        [Required(ErrorMessage="Second Wedder can not be empty")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Only alphabetical characters are allowed")]
        [MinLength(2, ErrorMessage="Wedder name is too short")]

        public string WedderTwo {get;set;}
        [Required(ErrorMessage="The date can not be empty")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")] // allows me to use the ToString() in views
        public DateTime Date {get;set;}
        [Required(ErrorMessage="Address can not be empty")]
        public string Address {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        // fk
        public int UserId {get;set;}
        //np
        
        // user has a 1 to many relationship with weddings and a many to many for attending
        public User Creator {get;set;} 
        public List<Attending> Guests {get;set;}


    }
}