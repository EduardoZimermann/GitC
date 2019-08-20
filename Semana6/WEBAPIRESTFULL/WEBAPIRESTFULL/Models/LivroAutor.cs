namespace WEBAPIRESTFULL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LivroAutor : UserControls
    {
        public virtual Livros Livros { get; set; }
        public virtual Autores Autores { get; set; }
    }
}