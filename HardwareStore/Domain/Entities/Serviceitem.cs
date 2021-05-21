using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Domain.Entities
{
    public class Serviceitem : EntityBase
    {
        [Required(ErrorMessage = "Заполните описание")]
        [Display(Name = "Название продукта")]
        public virtual string Title { get; set; }

        [Display(Name = "Краткое описание продукта")]
        public virtual string SubTitle { get; set; }

        [Display(Name = "Полное описание продукта")]
        public virtual string Text { get; set; }

        [Display(Name = "Номер категории")]
        public virtual string Catygory { get; set; }

        [Display(Name = "Цeна")]
        public virtual decimal Price { get; set; }

        [Display(Name = "Поместить товар в категорию лучших")]
        public virtual bool Best { get; set; }
    }
}
