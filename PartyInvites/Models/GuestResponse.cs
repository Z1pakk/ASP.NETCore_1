using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage ="Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
    // Инфраструктура МVС автоматически обнаруживает атрибуты проверки 
    //достоверности и использует их для проверки данных во время 
    //процесса привязки модели.
    // Мы импортировали пространство имен, которое содержит 
    //атрибуты проверки достоверности, так что к ним можно 
    //обращаться, не указывая полные имена.
}
