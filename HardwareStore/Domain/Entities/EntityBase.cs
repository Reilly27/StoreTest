using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Domain.Entities
{
    public class EntityBase
    {

        protected EntityBase() => DateAdded = DateTime.UtcNow;


        [Required]
        public Guid Id { get; set; }

        [Display(Name ="Заголовок")]
        public virtual string Title { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string SubTitle { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "Катигория")]
        public virtual string Catygory { get; set; }

        [Display(Name = "Цeна")]
        public virtual decimal Price { get; set; }


        [Display(Name = "Поместить товар в категорию лучших")]
        public virtual bool Best { get; set; }


        [Display(Name = "SEO метатег Title")]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "SEO метатег Discription")]
        public virtual string MetaDiscription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public virtual string Meta { get; set; }


        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }


    }
}
