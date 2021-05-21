using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Заголовок")]
        public virtual string Title { get; set; } = "Информационная страница";

        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; } = "Содержание заполняется администратором";


    }
}
