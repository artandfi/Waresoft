using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Waresoft
{
    public partial class Comment
    {
        private const string ERR_REQ = "Поле необхідно заповнити";
        public int Id { get; set; }
        
        public int SoftwareId { get; set; }
        
        [Required(ErrorMessage = ERR_REQ)]
        [StringLength(50)]
        [Display(Name = "Автор")]
        public string Name { get; set; }

        [Required(ErrorMessage = ERR_REQ)]
        [Display(Name = "Текст коментаря")]
        public string Text { get; set; }
        
        [Display(Name = "Оцінка")]
        [Range(1, 5)]
        public int Rating { get; set; }

        public virtual Software Software { get; set; }
    }
}
