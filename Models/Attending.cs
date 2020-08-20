using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wedding_Planner_Two.Models
{    
    public class Attending
    {
        [Key]
        public int AttendingId {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        //fk
        public int UserId {get;set;}
        public int WeddingId {get;set;}

       //np

       // Essentially, there is 1 attendingID for many users and many weddings. This is how They are linked via many to 
       // many. By having a one to many from Attending to Wedding, and a one to many from Attending to User
        public User UsersAttending {get;set;}
        public Wedding WeddingsAttending {get;set;}
    }
}
